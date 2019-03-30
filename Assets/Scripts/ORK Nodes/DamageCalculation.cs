using UnityEngine;
using ORKFramework;
using ORKFramework.Formulas;
using ORKFramework.Events;
using System.Collections.Generic;

namespace ORKFramework.Formulas.Steps
{
	[ORKEditorHelp("Damage Calculation", "A Custom Damage Calculation Node", "")]
	[ORKNodeInfo("Combatant")]
    public class DamageCalculation : BaseFormulaStep
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
		
			public DamageCalculation()
			{
		
			}
		
			public override int Calculate(FormulaCall call)
			{
				Combatant c = this.origin.GetCombatant(call);
				if(c != null)
				{
					float leveling = (2 * call.user.Status.Level) / 5 + 2;
					float power = call.result;
					float attack = call.user.Status.GetValueAtLevel(4, call.user.Status.Level);
					float defense = call.target.Status.GetValueAtLevel(5, call.target.Status.Level);
					float AD = attack / defense;
					float value = (leveling * power * AD)/5 + 2;
					Debug.Log("FINAL PHYSICAL DAMAGE: " + value);
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
				Combatant c = this.origin.GetCombatant(call);
				if(c != null)
				{
					float leveling = (2 * call.user.Status.Level) / 5 + 2;
					float power = call.result;
					float attack = call.user.Status.GetValueAtLevel(7, call.user.Status.Level);
					float defense = call.target.Status.GetValueAtLevel(8, call.target.Status.Level);
					float AD = attack / defense;
					float value = (leveling * power * AD)/5 + 2;
					Debug.Log("FINAL SPECIAL DAMAGE: " + value);
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