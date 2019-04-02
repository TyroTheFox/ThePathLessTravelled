using ORKFramework;
using ORKFramework.Behaviours;
using UnityEngine;
using Rewired;
namespace SpriteMan3D
{
    /// <summary>
    /// A simple Input controller for detecting player actions.
    /// </summary>
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(Collider))]
    public class PersonPlayerController : PersonController
    {
        /// <summary>
        /// A character's walking speed.
        /// </summary>
        public float walkSpeed = 2f;
        /// <summary>
        /// A character's running speed.
        /// </summary>
        public float runSpeed = 3f;
        /// <summary>
        /// A character's jump velocity.
        /// </summary>
        /// <remarks>
        /// Increase your project's Physics gravity and increase this value to make a character jump quickly.
        /// </remarks>
        public float jumpVelocity;

        /// <summary>
        /// How far to look for the distance to ground.
        /// </summary>
        public float groundDistanceOffset = 0.2f;

        /// <summary>
        /// The collider used for a mellee attack.
        /// </summary>
        public Collider attackCollider;

        /// <summary>
        /// Determines if this character can move.
        /// </summary>
        public bool canMove = true;
        /// <summary>
        /// Determines if this character can jump.
        /// </summary>
        public bool canJump = true;
        /// <summary>
        /// Determines if this character can attack.
        /// </summary>
        public bool canAttack = true;

        private Rigidbody rb;
        private float distToGround;
        private Collider charCollider;

        public float attackCooldown = 0.2f;
        private float attackTimer = 0f;
        
        private static Rewired.Player playerIn; // The Rewired Player
        public InteractionController interactionController; // Ork Interaction Controller

        public Transform currentCamera;
        
        void Start()
        {
            playerIn = ReInput.players.GetPlayer(0);
            rb = transform.GetComponent<Rigidbody>();

            // get the distance to ground
            charCollider = GetComponent<Collider>();
            distToGround = charCollider.bounds.extents.y;
        }

        Vector3 offset;

        void Update()
        {
            IsGrounded = Physics.Raycast(transform.position, -Vector3.up, distToGround + groundDistanceOffset);
            HandleInteract();
            HandleJump();
            
        }

        void FixedUpdate()
        {
            if (ORK.Initialized)
            {
                canMove = !(ORK.Battle.InBattle || ORK.Control.InMenu || ORK.Control.InShop || ORK.Control.InEvent);
            }

            HandleMove();
        }

        void HandleMove()
        {
            if (canMove)
            {
                var speed = walkSpeed;

                // detect input movement
                var moveHorizontal = playerIn.GetAxis("MoveLeftRight");
                var moveVertical = playerIn.GetAxis("MoveUpDown");
                IsMoving = moveHorizontal != 0 || moveVertical != 0;

                IsRunning = playerIn.GetButton("Run");
                if(IsRunning)
                {
                    speed = runSpeed;
                }

                // rotate the character
                var movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
                if (currentCamera != null)
                {
                    movement = currentCamera.rotation * movement;
                    movement.y = 0.0f;
                }
                var rot = movement * (speed / 10);

                if (attackTimer <= 0 && movement != Vector3.zero)
                {
                    var newRotation = Quaternion.LookRotation(rot);
                    rb.rotation = Quaternion.RotateTowards(transform.rotation, newRotation, 360f);
                }

                // move the character
                if (IsMoving && offset.y != 0f)
                {
                    movement.y = offset.normalized.y * movement.magnitude;
                }
                movement *= (speed / 10);

                var characterMovement = transform.position + movement;
                if (attackTimer <= 0 || !IsGrounded)
                {
                    rb.MovePosition(characterMovement);
                }
            }
            else
            {
                var currentVelocity = GetComponent<Rigidbody>().velocity;
                IsMoving = currentVelocity.magnitude > 0;
            }
        }

        private void HandleJump()
        {
            if (canJump)
            {
                // detect jump
                JumpStarted = playerIn.GetButtonDown("Jump");

                // make the character jump
                if (JumpStarted && IsGrounded)
                {
                    var velocity = rb.velocity;
                    velocity.y = jumpVelocity;
                    rb.velocity = velocity;
                }
            }
        }

        private void HandleInteract()
        {
            if (canMove)
            {
                if (playerIn.GetButtonDown("Action") && interactionController != null)
                {
                    interactionController.Interact();
                }
            }
        }

        private void HandleAttack()
        {
            if (canAttack)
            {
                if (attackTimer <= 0)
                {
                    // detect attack
                    AttackStarted = playerIn.GetButtonDown("Fire1");
                    if (AttackStarted)
                    {
                        attackTimer = attackCooldown;
                    }
                }
                else
                {
                    if(AttackStarted)
                    {
                        AttackStarted = false;
                    }
                    attackTimer -= Time.deltaTime;
                }
            }
        }

        /// <summary>
        /// called as animation event from Attack animation.
        /// </summary>
        public void StartAttack()
        {
            attackCollider.enabled = true;
        }

        /// <summary>
        /// called as animation event from Attack animation.
        /// </summary>
        public void EndAttack()
        {
            attackCollider.enabled = false;
        }

        public static bool CheckPause()
        {
            return playerIn.GetButtonUp("Menu");
        }
        
        public static bool CheckCancel()
        {
            return playerIn.GetButtonUp("Return");
        }
        
        public static bool CheckAccept()
        {
            return playerIn.GetButtonDown("Action");
        }
        
        public static float CheckMoveLeftRight()
        {
            return playerIn.GetAxis("MoveLeftRight");
        }        
        
        public static float CheckMoveUpDown()
        {
            return playerIn.GetAxis("MoveUpDown");
        }
    }
}