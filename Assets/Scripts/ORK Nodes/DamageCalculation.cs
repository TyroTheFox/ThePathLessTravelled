using UnityEngine;
using ORKFramework;
using ORKFramework.Formulas;
using ORKFramework.Events;
using System.Collections.Generic;

namespace ORKFramework.Formulas.Steps
{
	//The Physical Damage Calculation
	//Node Tags for the help box and menu placement
	[ORKEditorHelp("Damage Calculation", "A Custom Damage Calculation Node", "")]
	[ORKNodeInfo("Combatant")]
    public class DamageCalculation : BaseFormulaStep
    {
		//Node Options with tags that describe how they work
			[ORKEditorHelp("Operator", "The operator decides how this formula step is calculated to the current value of the formula:\n" +
				"- Add: Adds this step's result to the current value of the formula.\n" +
				"- Sub: Subtracts this step's result from the current value of the formula.\n" +
				"- Multiply: Multiplies the current value of the formula with this step's value.\n" +
				"- Divide: Divides the current value of the formula by this step's value.\n" +
				"- Modulo: Uses the modulo operator, current value of the formula % this step's value.\n" +
				"- Power Of: The current formula value to the power of this step's value.\n" +
				"- Log: The current formula value is used in a logarithmic calculation with this step's value as base.\n" +
				"- Set: Sets the current formula value to this step's result.", "")]
			public FormulaOperator formulaOperator = FormulaOperator.Set;
		
			[ORKEditorInfo(separator=true)]
			public FormulaStatusOrigin origin = new FormulaStatusOrigin();
		
			[ORKEditorHelp("Class Level", "The class level of the combatant is used.\n" +
			                              "If disabled, the base level is used.", "")]
			[ORKEditorInfo(separator=true)]
			public bool useClass = false;
		
			[ORKEditorHelp("Value Origin", "Select which value will be used:\n" +
				"- Base: The base value, without any bonuses.\n" +
				"- Current: The actual/real value (including bonuses).\n" +
				"- Maximum: The maximum value the status value can reach.", "")]
			public StatusValueOrigin svOrigin = StatusValueOrigin.Current;
		
			[ORKEditorHelp("Only Battle", "Only the battle members are used.\n" +
				"If disabled, the whole group will be used.", "")]
			[ORKEditorLayout("wholeGroup", true)]
			public bool onlyBattle = true;
		
			public DamageCalculation()
			{
		
			}
		
			public override int Calculate(FormulaCall call)
			{
				//Get combatant
				Combatant c = this.origin.GetCombatant(call);
				if(c != null)
				{
					//Calculate level factor of the damage
					float leveling = (2 * call.user.Status.Level) / 5 + 2;
					//Get attack power level from the formula (should be the initial value)
					float power = call.result;
					//Get the attack stat of the user
					float attack = call.user.Status.GetValueAtLevel(4, call.user.Status.Level);
					//Get the defence stat of the target
					float defense = call.target.Status.GetValueAtLevel(5, call.target.Status.Level);
					//Calculate a ratio based on the user's attack and the target's defence that will effect the final outcome
					float AD = attack / defense;
					//Calculate the final outcome
					float value = (leveling * power * AD)/5 + 2;
					//Send value to the formula handler
					ValueHelper.UseOperator(ref call.result, value, this.formulaOperator);
				}
				return this.next;
			}
		
			public override int CalculatePreview(FormulaCall call)
			{
				//Same thing as the normal calculation
				Combatant c = this.origin.GetCombatant(call);
				if(c != null)
				{
					float leveling = (2 * call.user.Status.Level) / 5 + 2;
					float power = call.result;
					float attack = call.user.Status.GetValueAtLevel(4, call.user.Status.Level);
					float defense = call.target.Status.GetValueAtLevel(5, call.target.Status.Level);
					float AD = attack / defense;
					float value = (leveling * power * AD)/5 + 2;
					
					ValueHelper.UseOperator(ref call.result, value, this.formulaOperator);
				}
				return this.next;
			}
			/*
============================================================================
Name functions
============================================================================
*/
			public override string GetNodeDetails()
			{
				return this.formulaOperator + " " + this.origin.GetInfoText() + 
				       (this.useClass ? "Class Level" : "Level");
			}
    }
    
	//The Special Damage Calculation
    [ORKEditorHelp("Special Damage Calculation", "A Custom Special Damage Calculation Node", "")]
	[ORKNodeInfo("Combatant")]
    public class SpecialDamageCalculation : BaseFormulaStep
    {
		// operator
			[ORKEditorHelp("Operator", "The operator decides how this formula step is calculated to the current value of the formula:\n" +
				"- Add: Adds this step's result to the current value of the formula.\n" +
				"- Sub: Subtracts this step's result from the current value of the formula.\n" +
				"- Multiply: Multiplies the current value of the formula with this step's value.\n" +
				"- Divide: Divides the current value of the formula by this step's value.\n" +
				"- Modulo: Uses the modulo operator, current value of the formula % this step's value.\n" +
				"- Power Of: The current formula value to the power of this step's value.\n" +
				"- Log: The current formula value is used in a logarithmic calculation with this step's value as base.\n" +
				"- Set: Sets the current formula value to this step's result.", "")]
			public FormulaOperator formulaOperator = FormulaOperator.Set;
		
			[ORKEditorInfo(separator=true)]
			public FormulaStatusOrigin origin = new FormulaStatusOrigin();
		
			[ORKEditorHelp("Class Level", "The class level of the combatant is used.\n" +
			                              "If disabled, the base level is used.", "")]
			[ORKEditorInfo(separator=true)]
			public bool useClass = false;
		
			[ORKEditorHelp("Value Origin", "Select which value will be used:\n" +
				"- Base: The base value, without any bonuses.\n" +
				"- Current: The actual/real value (including bonuses).\n" +
				"- Maximum: The maximum value the status value can reach.", "")]
			public StatusValueOrigin svOrigin = StatusValueOrigin.Current;
		
			[ORKEditorHelp("Only Battle", "Only the battle members are used.\n" +
				"If disabled, the whole group will be used.", "")]
			[ORKEditorLayout("wholeGroup", true)]
			public bool onlyBattle = true;
		
			public SpecialDamageCalculation()
			{
		
			}
		
			public override int Calculate(FormulaCall call)
			{
				//Get User Combatant
				Combatant c = this.origin.GetCombatant(call);
				if(c != null)
				{
					//Calculate level factor of the damage
					float leveling = (2 * call.user.Status.Level) / 5 + 2;
					//Get attack power level from the formula (should be the initial value)
					float power = call.result;
					//Get the user's special attack value
					float attack = call.user.Status.GetValueAtLevel(7, call.user.Status.Level);
					//Get the target's special defence value
					float defense = call.target.Status.GetValueAtLevel(8, call.target.Status.Level);
					//Calculate a ratio based on the user's special attack and the target's special defence that will effect the final outcome
					float AD = attack / defense;
					//Calculate the final outcome
					float value = (leveling * power * AD)/5 + 2;
					//Send value to the formula handler
					ValueHelper.UseOperator(ref call.result, value, this.formulaOperator);
				}
				return this.next;
			}
		
			public override int CalculatePreview(FormulaCall call)
			{
				//Same as normal calculation
				Combatant c = this.origin.GetCombatant(call);
				if(c != null)
				{
					float leveling = (2 * call.user.Status.Level) / 5 + 2;
					float power = call.result;
					float attack = call.user.Status.GetValueAtLevel(7, call.user.Status.Level);
					float defense = call.target.Status.GetValueAtLevel(8, call.target.Status.Level);
					float AD = attack / defense;
					float value = (leveling * power * AD)/5 + 2;
					ValueHelper.UseOperator(ref call.result, value, this.formulaOperator);
				}
				return this.next;
			}
			/*
============================================================================
Name functions
============================================================================
*/
			public override string GetNodeDetails()
			{
				return this.formulaOperator + " " + this.origin.GetInfoText() + 
				       (this.useClass ? "Class Level" : "Level");
			}
    }
    
	//Heal Calculation Node
     [ORKEditorHelp("Heal Calculation", "A Custom Heal Calculation Node", "")]
	[ORKNodeInfo("Combatant")]
    public class HealCalculation : BaseFormulaStep
    {
		// operator
			[ORKEditorHelp("Operator", "The operator decides how this formula step is calculated to the current value of the formula:\n" +
				"- Add: Adds this step's result to the current value of the formula.\n" +
				"- Sub: Subtracts this step's result from the current value of the formula.\n" +
				"- Multiply: Multiplies the current value of the formula with this step's value.\n" +
				"- Divide: Divides the current value of the formula by this step's value.\n" +
				"- Modulo: Uses the modulo operator, current value of the formula % this step's value.\n" +
				"- Power Of: The current formula value to the power of this step's value.\n" +
				"- Log: The current formula value is used in a logarithmic calculation with this step's value as base.\n" +
				"- Set: Sets the current formula value to this step's result.", "")]
			public FormulaOperator formulaOperator = FormulaOperator.Set;
		
			[ORKEditorInfo(separator=true)]
			public FormulaStatusOrigin origin = new FormulaStatusOrigin();
		
			[ORKEditorHelp("Class Level", "The class level of the combatant is used.\n" +
			                              "If disabled, the base level is used.", "")]
			[ORKEditorInfo(separator=true)]
			public bool useClass = false;
		
			[ORKEditorHelp("Value Origin", "Select which value will be used:\n" +
				"- Base: The base value, without any bonuses.\n" +
				"- Current: The actual/real value (including bonuses).\n" +
				"- Maximum: The maximum value the status value can reach.", "")]
			public StatusValueOrigin svOrigin = StatusValueOrigin.Current;
		
			[ORKEditorHelp("Only Battle", "Only the battle members are used.\n" +
				"If disabled, the whole group will be used.", "")]
			[ORKEditorLayout("wholeGroup", true)]
			public bool onlyBattle = true;
		
			public HealCalculation()
			{
		
			}
		
			public override int Calculate(FormulaCall call)
			{
				Combatant c = this.origin.GetCombatant(call);
				if(c != null)
				{
					//Largely the same as a special attack but doesn't take into account the special defence of the target and reduces the damage further
					float leveling = (2 * call.user.Status.Level) / 5 + 2;
					float power = call.result;
					float attack = call.user.Status.GetValueAtLevel(7, call.target.Status.Level);
					float value = (leveling * power * attack)/7.5f;
					ValueHelper.UseOperator(ref call.result, value, this.formulaOperator);
				}
				return this.next;
			}
		
			public override int CalculatePreview(FormulaCall call)
			{
				Combatant c = this.origin.GetCombatant(call);
				if(c != null)
				{
					float leveling = (2 * call.user.Status.Level) / 5 + 2;
					float power = call.result;
					float attack = call.user.Status.GetValueAtLevel(7, call.target.Status.Level);
					float value = (leveling * power * attack)/7.5f + 2;
					ValueHelper.UseOperator(ref call.result, value, this.formulaOperator);
				}
				return this.next;
			}
			/*
============================================================================
Name functions
============================================================================
*/
			public override string GetNodeDetails()
			{
				return this.formulaOperator + " " + this.origin.GetInfoText() + 
				       (this.useClass ? "Class Level" : "Level");
			}
    }
}