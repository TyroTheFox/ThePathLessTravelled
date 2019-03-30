using System.Collections;
using System.Collections.Generic;
using SpriteMan3D;
using UnityEngine;
using ORKFramework;
using ORKFramework.Behaviours;

public class PartyAnimator : PersonController
{
    /// <summary>
    /// Determines if this character can move.
    /// </summary>
    public bool canMove = true;
    /// <summary>
    /// Determines if this character can jump.
    /// </summary>
    public bool canJump = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (ORK.Initialized)
        {
            canMove = !ORK.Control.InMenu && !ORK.Control.InShop;
            canJump = !ORK.Control.InMenu || !ORK.Control.InShop || !ORK.Control.InEvent;
        }

        //HandleMove();
    }
    
    void HandleMove()
    {
        Transform leader = GameObject.FindWithTag("Player").transform;
        transform.localScale = leader.lossyScale;
    }
}
