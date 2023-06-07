using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace CustomizableGSTS.Common.Configs
{
	public class ModConfigGT : ModConfig
	{
		
		public override ConfigScope Mode => ConfigScope.ServerSide;


		[Header("Global settings")]
		//-------------------------------------------------------------------------------------------------------------------------
		
		[Label("Global On/Off")]
		[Tooltip("Turns the mod on off. Useful if you want quick look at how values affect gameplay")]
		[DefaultValue(true)]

		public bool GlobalOnOff;

		[Header("Attack and Defense Stats")] 

	    // Damage Increase
		[Label("[i:4956] Damage")] 
		[Tooltip("Whatever value you set here, your damage is going to be modified by that value.")]	
		[DefaultValue(0)] 
		[Range(-100000,10000000)] 
		[BackgroundColor(255,0,0)]
		public int Damage;  
		
		[Label("[i:513] Dynamic On/Off")] 
		[Tooltip("Switch the stat changes on/off. Useful if you want to quickly see the changes without resetting every field.")]	
		[DefaultValue(true)] 

		public bool DamageSwitchOffOn;

		

		
		//-------------------------------------------------------------------------------------------------------------------------
		// Defense Increase
		[Label("[i:938] Defense")]
		[Tooltip("Whatever value you set here, your defense is going to be modified by that value.")]
		[DefaultValue(0)]
		[Range(-100000, 10000000)]
		[BackgroundColor(255,0,0)]
		public int Defense;

		[Label("[i:513] Dynamic On/Off")] 
		[Tooltip("Switch the stat changes on/off. Useful if you want to quickly see the changes without resetting every field.")]	
		[DefaultValue(true)] 

		public bool DefenseSwitchOffOn;

		[Label("[i:3608] Change type")] 
		[Tooltip("Sets the way stat changes are going to be handled. 0 - Not affected 1 - The value is added to the stat, 2 - The stat is multiplied by the value, 3 - The stat is set to the value")]	
		[DefaultValue(1)] 
		[Range(1,3)]
		[Slider]

		public int DefenseChangeType;

		[Label("Reverse change type")]
		[Tooltip("Reverses the change type (addition turns into substraction, multiplication into division (third option is not affected)")]
		[DefaultValue(false)]
		
		public bool DefenseRevC;
		//-------------------------------------------------------------------------------------------------------------------------
		[Label("[i:901] Damage Reduction")]
		[Tooltip("Whatever value you set here, your damage reduction is going to be modified by that value. Value here is in percent (negative increases the damage taken)")]
		[DefaultValue(0)]
		[BackgroundColor(255,0,0)]
		[Range(-10000, 100)]
		public int Endurance;

		[Label("[i:513] Dynamic On/Off")] 
		[Tooltip("Switch the stat changes on/off. Useful if you want to quickly see the changes without resetting every field.")]	
		[DefaultValue(true)] 

		public bool EnduranceSwitchOffOn;

		
		//-------------------------------------------------------------------------------------------------------------------------

		[Label("[i:1300] Armor Penetration")]
		[Tooltip("Whatever value you set here, your armor penetration is going to be modified by that value.")]
		[DefaultValue(0)]
		[Range(0, 1000000)]
		[BackgroundColor(255,0,0)]
		public int ArmorPenetration;

		[Label("[i:513] Dynamic On/Off")] 
		[Tooltip("Switch the stat changes on/off. Useful if you want to quickly see the changes without resetting every field.")]	
		[DefaultValue(true)] 

		public bool ArmorPenetrationSwitchOffOn;

		[Label("[i:3608] Change type")] 
		[Tooltip("Sets the way stat changes are going to be handled. 0 - Not affected 1 - The value is added to the stat, 2 - The stat is multiplied by the value, 3 - The stat is set to the value")]	
		[DefaultValue(1)] 
		[Range(1,3)]
		[Slider]
		
		public int ArmorPenetrationChangeType;

		[Label("Reverse change type")]
		[Tooltip("Reverses the change type (addition turns into substraction, multiplication into division (third option is not affected)")]
		[DefaultValue(false)]
		
		public bool ArmorPenetrationRevC;
		//-------------------------------------------------------------------------------------------------------------------------
		

		[Header("Health Stats")] 
		[Label("[i:29] Health")]
		[Tooltip("Whatever value you set here, your health is going to be modified by that value.")]
		[DefaultValue(0)]
		[Range(-100000, 10000000)]
		[BackgroundColor(255,0,0)]
		public int Health;

		[Label("[i:513] Dynamic On/Off")] 
		[Tooltip("Switch the stat changes on/off. Useful if you want to quickly see the changes without resetting every field.")]	
		[DefaultValue(true)] 

		public bool HealthSwitchOffOn;

		[Label("[i:3608] Change type")] 
		[Tooltip("Sets the way stat changes are going to be handled. 0 - Not affected 1 - The value is added to the stat, 2 - The stat is multiplied by the value, 3 - The stat is set to the value")]	
		[DefaultValue(1)] 
		[Range(1,3)]
		[Slider]

		public int HealthChangeType;

		[Label("Reverse change type")]
		[Tooltip("Reverses the change type (addition turns into substraction, multiplication into division (third option is not affected)")]
		[DefaultValue(false)]
		
		public bool HealthRevC;
		//-------------------------------------------------------------------------------------------------------------------------


		[Label("[i:289] Health regen speed")]
		[Tooltip("Whatever value you set here, your health regen speed is going to be modified by that value.")]
		[DefaultValue(0)]
		[Range(0, 10000000)]
		[BackgroundColor(255,0,0)]
		public int HealthRegenSpeed;
		

		[Label("[i:513] Dynamic On/Off")] 
		[Tooltip("Switch the stat changes on/off. Useful if you want to quickly see the changes without resetting every field.")]	
		[DefaultValue(true)] 

		public bool HealthRegenSpeedSwitchOffOn;

		[Label("[i:3608] Change type")] 
		[Tooltip("Sets the way stat changes are going to be handled. 0 - Not affected 1 - The value is added to the stat, 2 - The stat is multiplied by the value, 3 - The stat is set to the value")]	
		[DefaultValue(1)] 
		[Range(1,3)]
		[Slider]

		public int HealthRegenSpeedChangeType;

		[Label("Reverse change type")]
		[Tooltip("Reverses the change type (addition turns into substraction, multiplication into division (third option is not affected)")]
		[DefaultValue(false)]
		
		public bool HealthRegenSpeedRevC;
		//-------------------------------------------------------------------------------------------------------------------------


		


		

		
		

		[Header("Mana Stats")]


		[Label("[i:109] Mana")]
		[Tooltip("Whatever value you set here, your mana is going to be modified by that value.")]
		[DefaultValue(0)]
		[Range(-100000, 10000000)]
		[BackgroundColor(255,0,0)]
		public int Mana;
		

		[Label("[i:513] Dynamic On/Off")] 
		[Tooltip("Switch the stat changes on/off. Useful if you want to quickly see the changes without resetting every field.")]	
		[DefaultValue(true)] 

		public bool ManaSwitchOffOn;

		[Label("[i:3608] Change type")] 
		[Tooltip("Sets the way stat changes are going to be handled. 0 - Not affected 1 - The value is added to the stat, 2 - The stat is multiplied by the value, 3 - The stat is set to the value")]	
		[DefaultValue(1)] 
		[Range(1,3)]
		[Slider]

		public int ManaChangeType;

		[Label("Reverse change type")]
		[Tooltip("Reverses the change type (addition turns into substraction, multiplication into division (third option is not affected)")]
		[DefaultValue(false)]
		
		public bool ManaRevC;
		//-------------------------------------------------------------------------------------------------------------------------

		


		[Label("[i:111] Mana cost")]
		[Tooltip("Whatever value you set here, your mana cost is going to be modified by that value.")]
		[DefaultValue(0)]
		[Range(-100000, 10000000)]
		[BackgroundColor(255,0,0)]
		public int ManaCost;
		

		[Label("[i:513] Dynamic On/Off")] 
		[Tooltip("Switch the stat changes on/off. Useful if you want to quickly see the changes without resetting every field.")]	
		[DefaultValue(true)] 

		public bool ManaCostSwitchOffOn;

		[Label("[i:3608] Change type")] 
		[Tooltip("Sets the way stat changes are going to be handled. 0 - Not affected 1 - The value is added to the stat, 2 - The stat is multiplied by the value, 3 - The stat is set to the value")]	
		[DefaultValue(1)] 
		[Range(1,3)]
		[Slider]

		public int ManaCostChangeType;

		[Label("Reverse change type")]
		[Tooltip("Reverses the change type (addition turns into substraction, multiplication into division (third option is not affected)")]
		[DefaultValue(false)]
		
		public bool ManaCostRevC;
		//-------------------------------------------------------------------------------------------------------------------------

		
		

		[Label("[i:555] Mana regen speed")]
		[Tooltip("Whatever value you set here, your mana regen is going to be modified by that value.")]
		[DefaultValue(0)]
		[Range(-100000, 10000000)]
		[BackgroundColor(255,0,0)]
		public int ManaRegen;
		

		[Label("[i:513] Dynamic On/Off")] 
		[Tooltip("Switch the stat changes on/off. Useful if you want to quickly see the changes without resetting every field.")]	
		[DefaultValue(true)] 

		public bool ManaRegenSwitchOffOn;

		[Label("[i:3608] Change type")] 
		[Tooltip("Sets the way stat changes are going to be handled. 0 - Not affected 1 - The value is added to the stat, 2 - The stat is multiplied by the value, 3 - The stat is set to the value")]	
		[DefaultValue(1)] 
		[Range(1,3)]
		[Slider]

		public int ManaRegenChangeType;

		[Label("Reverse change type")]
		[Tooltip("Reverses the change type (addition turns into substraction, multiplication into division (third option is not affected)")]
		[DefaultValue(false)]
		
		public bool ManaRegenRevC;
		//-------------------------------------------------------------------------------------------------------------------------

		

		

		[Header("Movement Stats")]
		
		[Label("[i:54] Movement Speed")]
		[Tooltip("Whatever value you set here, your speed is going to be modified by that value.")]
		[DefaultValue(0)]
		[Range(-10000, 10000000)]
		[BackgroundColor(255,0,0)]
		public int moveSpeed;
		

		[Label("[i:513] Dynamic On/Off")] 
		[Tooltip("Switch the stat changes on/off. Useful if you want to quickly see the changes without resetting every field.")]	
		[DefaultValue(true)] 

		public bool moveSpeedSwitchOffOn;

		[Label("[i:3608] Change type")] 
		[Tooltip("Sets the way stat changes are going to be handled. 0 - Not affected 1 - The value is added to the stat, 2 - The stat is multiplied by the value, 3 - The stat is set to the value")]	
		[DefaultValue(1)] 
		[Range(1,3)]
		[Slider]

		public int moveSpeedChangeType;

		[Label("Reverse change type")]
		[Tooltip("Reverses the change type (addition turns into substraction, multiplication into division (third option is not affected)")]
		[DefaultValue(false)]
		
		public bool moveSpeedRevC;
		//-------------------------------------------------------------------------------------------------------------------------

		
		[Label("[i:1506] Mining speed")]
		[Tooltip("Whatever value you set here, your mining speed is going to be modified by that value.")]
		[DefaultValue(0)]
		[BackgroundColor(255,0,0)]
		[Range(-10000, 10000000)]
		public int MiningSpeed;
		

		[Label("[i:513] Dynamic On/Off")] 
		[Tooltip("Switch the stat changes on/off. Useful if you want to quickly see the changes without resetting every field.")]	
		[DefaultValue(true)] 

		public bool MiningSpeedSwitchOffOn;

		[Label("[i:3608] Change type")] 
		[Tooltip("Sets the way stat changes are going to be handled. 0 - Not affected 1 - The value is added to the stat, 2 - The stat is multiplied by the value, 3 - The stat is set to the value")]	
		[DefaultValue(1)] 
		[Range(1,3)]
		[Slider]

		public int MiningSpeedChangeType;

		[Label("Reverse change type")]
		[Tooltip("Reverses the change type (addition turns into substraction, multiplication into division (third option is not affected)")]
		[DefaultValue(false)]
		
		public bool MiningSpeedRevC;
		//-------------------------------------------------------------------------------------------------------------------------

		[Label("[i:1923] Tile placement speed")]
		[Tooltip("Whatever value you set here, your tile placement speed is going to be modified by that value.")]
		[DefaultValue(0)]
		[BackgroundColor(255,0,0)]
		[Range(-100, 10000000)]
		public int tileSpeed;

		[Label("[i:513] Dynamic On/Off")] 
		[Tooltip("Switch the stat changes on/off. Useful if you want to quickly see the changes without resetting every field.")]	
		[DefaultValue(true)] 

		public bool tileSpeedSwitchOffOn;

		[Label("[i:3608] Change type")] 
		[Tooltip("Sets the way stat changes are going to be handled. 0 - Not affected 1 - The value is added to the stat, 2 - The stat is multiplied by the value, 3 - The stat is set to the value")]	
		[DefaultValue(1)] 
		[Range(1,3)]
		[Slider]

		public int tileSpeedChangeType;

		[Label("Reverse change type")]
		[Tooltip("Reverses the change type (addition turns into substraction, multiplication into division (third option is not affected)")]
		[DefaultValue(false)]
		
		public bool tileSpeedRevC;
		//-------------------------------------------------------------------------------------------------------------------------
		
		[Label("[i:1923] Wall placement speed")]
		[Tooltip("Whatever value you set here, your wall placement speed is going to be modified by that value.")]
		[DefaultValue(0)]
		[BackgroundColor(255,0,0)]
		[Range(-100, 10000000)]
		public int wallSpeed;


		[Label("[i:513] Dynamic On/Off")] 
		[Tooltip("Switch the stat changes on/off. Useful if you want to quickly see the changes without resetting every field.")]	
		[DefaultValue(true)] 

		public bool wallSpeedSwitchOffOn;

		[Label("[i:3608] Change type")] 
		[Tooltip("Sets the way stat changes are going to be handled. 0 - Not affected 1 - The value is added to the stat, 2 - The stat is multiplied by the value, 3 - The stat is set to the value")]	
		[DefaultValue(1)] 
		[Range(1,3)]
		[Slider]

		public int wallSpeedChangeType;

		[Label("Reverse change type")]
		[Tooltip("Reverses the change type (addition turns into substraction, multiplication into division (third option is not affected)")]
		[DefaultValue(false)]
		
		public bool wallSpeedRevC;
		//-------------------------------------------------------------------------------------------------------------------------

		[Label("[i:1343] Attack speed")]
		[Tooltip("Whatever value you set here, your attack speed is going to be modified by that value.")]
		[DefaultValue(0)]
		[Range(-10000, 10000000)]
		[BackgroundColor(255,0,0)]
		public int AttackSpeed;
		
		[Label("[i:513] Dynamic On/Off")] 
		[Tooltip("Switch the stat changes on/off. Useful if you want to quickly see the changes without resetting every field.")]	
		[DefaultValue(true)] 

		public bool AttackSpeedSwitchOffOn;

		[Label("[i:3608] Change type")] 
		[Tooltip("Sets the way stat changes are going to be handled. 0 - Not affected 1 - The value is added to the stat, 2 - The stat is multiplied by the value, 3 - The stat is set to the value")]	
		[DefaultValue(1)] 
		[Range(1,3)]
		[Slider]

		public int AttackSpeedChangeType;

		[Label("Reverse change type")]
		[Tooltip("Reverses the change type (addition turns into substraction, multiplication into division (third option is not affected)")]
		[DefaultValue(false)]
		
		public bool AttackSpeedRevC;
		//-------------------------------------------------------------------------------------------------------------------------

		[Label("[i:2430] Jump Speed")]
		[Tooltip("Whatever value you set here, your jump speed is going to be modified by that value.")]
		[DefaultValue(0)]
		[Range(-10000, 10000000)]
		[BackgroundColor(255,0,0)]
		public int JumpSpeed;
		

		[Label("[i:513] Dynamic On/Off")] 
		[Tooltip("Switch the stat changes on/off. Useful if you want to quickly see the changes without resetting every field.")]	
		[DefaultValue(true)] 

		public bool JumpSpeedSwitchOffOn;

		[Label("[i:3608] Change type")] 
		[Tooltip("Sets the way stat changes are going to be handled. 0 - Not affected 1 - The value is added to the stat, 2 - The stat is multiplied by the value, 3 - The stat is set to the value")]	
		[DefaultValue(1)] 
		[Range(1,3)]
		[Slider]

		public int JumpSpeedChangeType;

		[Label("Reverse change type")]
		[Tooltip("Reverses the change type (addition turns into substraction, multiplication into division (third option is not affected)")]
		[DefaultValue(false)]
		
		public bool JumpSpeedRevC;
		//-------------------------------------------------------------------------------------------------------------------------

		[Label("[i:486] Jump Height")]
		[Tooltip("Whatever value you set here, your jump height is going to be modified by that value.")]
		[DefaultValue(0)]
		[Range(-10000, 10000000)]
		[BackgroundColor(255,0,0)]
		public int JumpHeight;

		[Label("[i:513] Dynamic On/Off")] 
		[Tooltip("Switch the stat changes on/off. Useful if you want to quickly see the changes without resetting every field.")]	
		[DefaultValue(true)] 

		public bool JumpHeightSwitchOffOn;

		[Label("[i:3608] Change type")] 
		[Tooltip("Sets the way stat changes are going to be handled. 0 - Not affected 1 - The value is added to the stat, 2 - The stat is multiplied by the value, 3 - The stat is set to the value")]	
		[DefaultValue(1)] 
		[Range(1,3)]
		[Slider]

		public int JumpHeightChangeType;

		[Label("Reverse change type")]
		[Tooltip("Reverses the change type (addition turns into substraction, multiplication into division (third option is not affected)")]
		[DefaultValue(false)]
		
		public bool JumpHeightRevC;
		//-------------------------------------------------------------------------------------------------------------------------


		
		[Header("Misc Stats")]

		[Label("[i:1254] Crit chance")]
		[Tooltip("Whatever value you set here, your crit chance is going to be modified by that value.")]
		[DefaultValue(0)]
		[Range(-100, 100)]
		[BackgroundColor(255,0,0)]
		public int CritChance;

		[Label("[i:513] Dynamic On/Off")] 
		[Tooltip("Switch the stat changes on/off. Useful if you want to quickly see the changes without resetting every field.")]	
		[DefaultValue(true)] 

		public bool CritChanceSwitchOffOn;

		
		//-------------------------------------------------------------------------------------------------------------------------

		[Label("[i:1845] Max minions")]
		[Tooltip("Whatever value you set here, your max minions is going to be modified by that value.")]
		[DefaultValue(0)]
		[Range(-10000, 10000000)]
		[BackgroundColor(255,0,0)]
		public int MaxMinions;
		

		[Label("[i:513] Dynamic On/Off")] 
		[Tooltip("Switch the stat changes on/off. Useful if you want to quickly see the changes without resetting every field.")]	
		[DefaultValue(true)] 

		public bool MaxMinionsSwitchOffOn;

		[Label("[i:3608] Change type")] 
		[Tooltip("Sets the way stat changes are going to be handled. 0 - Not affected 1 - The value is added to the stat, 2 - The stat is multiplied by the value, 3 - The stat is set to the value")]	
		[DefaultValue(1)] 
		[Range(1,3)]
		[Slider]

		public int MaxMinionsChangeType;

		[Label("Reverse change type")]
		[Tooltip("Reverses the change type (addition turns into substraction, multiplication into division (third option is not affected)")]
		[DefaultValue(false)]
		
		public bool MaxMinionsRevC;
		//-------------------------------------------------------------------------------------------------------------------------

		[Label("[i:493] Wing Fly Time")]
		[Tooltip("Whatever value you set here, your wing fly time is going to be modified by that value.")]
		[DefaultValue(0)]
		[Range(-10000, 10000)]
		[BackgroundColor(255,0,0)]
		public int WingTime;
		

		[Label("[i:513] Dynamic On/Off")] 
		[Tooltip("Switch the stat changes on/off. Useful if you want to quickly see the changes without resetting every field.")]	
		[DefaultValue(true)] 

		public bool WingTimeSwitchOffOn;

		[Label("[i:3608] Change type")] 
		[Tooltip("Sets the way stat changes are going to be handled. 0 - Not affected 1 - The value is added to the stat, 2 - The stat is multiplied by the value, 3 - The stat is set to the value")]	
		[DefaultValue(1)] 
		[Range(1,3)]
		[Slider]

		public int WingTimeChangeType;

		[Label("Reverse change type")]
		[Tooltip("Reverses the change type (addition turns into substraction, multiplication into division (third option is not affected)")]
		[DefaultValue(false)]
		
		public bool WingTimeRevC;
		//-------------------------------------------------------------------------------------------------------------------------

		

		
		
		[Label("[i:3824] Max sentries")]
		[Tooltip("Whatever value you set here, your max sentries is going to be modified by that value.")]
		[DefaultValue(0)]
		[BackgroundColor(255,0,0)]
		[Range(-100, 10000000)]
		public int MaxSentries;


		[Label("[i:513] Dynamic On/Off")] 
		[Tooltip("Switch the stat changes on/off. Useful if you want to quickly see the changes without resetting every field.")]	
		[DefaultValue(true)] 

		public bool MaxSentriesSwitchOffOn;

		[Label("[i:3608] Change type")] 
		[Tooltip("Sets the way stat changes are going to be handled. 0 - Not affected 1 - The value is added to the stat, 2 - The stat is multiplied by the value, 3 - The stat is set to the value")]	
		[DefaultValue(1)] 
		[Range(1,3)]
		[Slider]

		public int MaxSentriesChangeType;

		[Label("Reverse change type")]
		[Tooltip("Reverses the change type (addition turns into substraction, multiplication into division (third option is not affected)")]
		[DefaultValue(false)]
		
		public bool MaxSentriesRevC;
		//-------------------------------------------------------------------------------------------------------------------------

		

		[Label("[i:486] Tile and wall placement range")]
		[Tooltip("Whatever value you set here, your tile and wall placement range is going to be increased by that value.")]
		[DefaultValue(0)]
		[BackgroundColor(255,0,0)]

		[Range(-100, 10000000)]
		public int BlockRange;


		[Label("[i:513] Dynamic On/Off")] 
		[Tooltip("Switch the stat changes on/off. Useful if you want to quickly see the changes without resetting every field.")]	
		[DefaultValue(true)] 

		public bool BlockRangeSwitchOffOn;

		[Label("[i:3608] Change type")] 
		[Tooltip("Sets the way stat changes are going to be handled. 0 - Not affected 1 - The value is added to the stat, 2 - The stat is multiplied by the value, 3 - The stat is set to the value")]	
		[DefaultValue(1)] 
		[Range(1,3)]
		[Slider]

		public int BlockRangeChangeType;

		[Label("Reverse change type")]
		[Tooltip("Reverses the change type (addition turns into substraction, multiplication into division (third option is not affected)")]
		[DefaultValue(false)]
		
		public bool BlockRangeRevC;
		//-------------------------------------------------------------------------------------------------------------------------

		
		








		


		


		




		


		



		
	}


	
}