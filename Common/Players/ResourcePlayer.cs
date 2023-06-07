using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using CustomizableGSTS.Common.Configs;
using System;
using System.Globalization;
using System.Collections.Generic;
using Terraria.DataStructures;
using static Terraria.Utilities.UnifiedRandom;

namespace CustomizableGSTS.Common.Players
{
	public class ResourcePlayer : ModPlayer
	{          
		//public override bool PreHurt(bool pvp, bool quiet, ref int damage, ref int hitDirection, ref bool crit, ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
                //{
                        //int Dodge_Chance = ModContent.GetInstance<ModConfigGT>().DodgeChance;
                        
                        //int Dodge_Roll = Main.rand.Next(1, 101);
                        //if (Dodge_Roll <= Dodge_Chance)
                        //{
                                
                                //damage = 0;
                                //Player.immune = true;
                                //Player.immuneTime = 100; 
                                //Player.NinjaDodge();
                                
                                
                                //return false;
                        //}
                        //else {
                                //return true;
                        //}
                        
                //}
                 
                

		public override void PostUpdateMiscEffects() {

                        if (ModContent.GetInstance<ModConfigGT>().GlobalOnOff == true)
                        {
                                if (ModContent.GetInstance<ModConfigGT>().DamageSwitchOffOn == true)
                                {
                                        Player.GetDamage(DamageClass.Generic).Base += ModContent.GetInstance<ModConfigGT>().Damage;
                                }

                                if (ModContent.GetInstance<ModConfigGT>().DefenseSwitchOffOn == true)
                                {
                                        if (ModContent.GetInstance<ModConfigGT>().DefenseRevC == true)
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().DefenseChangeType) 
                                                {
                                                case 1:
                                                        Player.statDefense -= ModContent.GetInstance<ModConfigGT>().Defense;
                                                        break;
                                                case 2:
                                                        Player.statDefense /= ModContent.GetInstance<ModConfigGT>().Defense;
                                                        break;
                                                case 3:
                                                        Player.statDefense = ModContent.GetInstance<ModConfigGT>().Defense;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                

                                        }
                                        else
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().DefenseChangeType) 
                                                {
                                                case 1:
                                                        Player.statDefense += ModContent.GetInstance<ModConfigGT>().Defense;
                                                        break;
                                                case 2:
                                                        Player.statDefense *= ModContent.GetInstance<ModConfigGT>().Defense;
                                                        break;
                                                case 3:
                                                        Player.statDefense = ModContent.GetInstance<ModConfigGT>().Defense;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                

                                        }
                                        

                                }
                                if (ModContent.GetInstance<ModConfigGT>().HealthSwitchOffOn == true)
                                {
                                        if (ModContent.GetInstance<ModConfigGT>().HealthRevC == true)
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().HealthChangeType) 
                                                {
                                                case 1:
                                                        Player.statLifeMax2 -= ModContent.GetInstance<ModConfigGT>().Health;
                                                        break;
                                                case 2:
                                                        Player.statLifeMax2 /= ModContent.GetInstance<ModConfigGT>().Health;
                                                        break;
                                                case 3:
                                                        Player.statLifeMax2 = ModContent.GetInstance<ModConfigGT>().Health;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                

                                        }
                                        else
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().HealthChangeType) 
                                                {
                                                case 1:
                                                        Player.statLifeMax2 += ModContent.GetInstance<ModConfigGT>().Health;
                                                        break;
                                                case 2:
                                                        Player.statLifeMax2 *= ModContent.GetInstance<ModConfigGT>().Health;
                                                        break;
                                                case 3:
                                                        Player.statLifeMax2 = ModContent.GetInstance<ModConfigGT>().Health;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                        }
                                }
                                if (ModContent.GetInstance<ModConfigGT>().HealthRegenSpeedSwitchOffOn == true)
                                {
                                        if (ModContent.GetInstance<ModConfigGT>().HealthRegenSpeedRevC == true)
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().HealthRegenSpeedChangeType) 
                                                {
                                                case 1:
                                                        Player.lifeRegen -= ModContent.GetInstance<ModConfigGT>().HealthRegenSpeed;
                                                        break;
                                                case 2:
                                                        Player.lifeRegen /= ModContent.GetInstance<ModConfigGT>().HealthRegenSpeed;
                                                        break;
                                                case 3:
                                                        Player.lifeRegen = ModContent.GetInstance<ModConfigGT>().HealthRegenSpeed;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                

                                        }
                                        else
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().HealthRegenSpeedChangeType) 
                                                {
                                                case 1:
                                                        Player.lifeRegen += ModContent.GetInstance<ModConfigGT>().HealthRegenSpeed;
                                                        break;
                                                case 2:
                                                        Player.lifeRegen *= ModContent.GetInstance<ModConfigGT>().HealthRegenSpeed;
                                                        break;
                                                case 3:
                                                        Player.lifeRegen = ModContent.GetInstance<ModConfigGT>().HealthRegenSpeed;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                        }
                                }
                                if (ModContent.GetInstance<ModConfigGT>().ManaSwitchOffOn == true)
                                {
                                        if (ModContent.GetInstance<ModConfigGT>().ManaRevC == true)
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().ManaChangeType) 
                                                {
                                                case 1:
                                                        Player.statManaMax2 -= ModContent.GetInstance<ModConfigGT>().Mana;
                                                        break;
                                                case 2:
                                                        Player.statManaMax2 /= ModContent.GetInstance<ModConfigGT>().Mana;
                                                        break;
                                                case 3:
                                                        Player.statManaMax2= ModContent.GetInstance<ModConfigGT>().Mana;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                

                                        }
                                        else
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().ManaChangeType) 
                                                {
                                                case 1:
                                                        Player.statManaMax2 += ModContent.GetInstance<ModConfigGT>().Mana;
                                                        break;
                                                case 2:
                                                        Player.statManaMax2 *= ModContent.GetInstance<ModConfigGT>().Mana;
                                                        break;
                                                case 3:
                                                        Player.statManaMax2 = ModContent.GetInstance<ModConfigGT>().Mana;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                        }
                                }
                                if (ModContent.GetInstance<ModConfigGT>().ManaRegenSwitchOffOn == true)
                                {
                                        if (ModContent.GetInstance<ModConfigGT>().ManaRegenRevC == true)
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().ManaRegenChangeType) 
                                                {
                                                case 1:
                                                        Player.manaRegenBonus -= ModContent.GetInstance<ModConfigGT>().ManaRegen;
                                                        break;
                                                case 2:
                                                        Player.manaRegenBonus /= ModContent.GetInstance<ModConfigGT>().ManaRegen;
                                                        break;
                                                case 3:
                                                        Player.manaRegenBonus = ModContent.GetInstance<ModConfigGT>().ManaRegen;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                

                                        }
                                        else
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().ManaChangeType) 
                                                {
                                                case 1:
                                                        Player.manaRegenBonus+= ModContent.GetInstance<ModConfigGT>().ManaRegen;
                                                        break;
                                                case 2:
                                                        Player.manaRegenBonus *= ModContent.GetInstance<ModConfigGT>().Mana;
                                                        break;
                                                case 3:
                                                        Player.manaRegenBonus= ModContent.GetInstance<ModConfigGT>().ManaRegen;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                        }
                                }
                                if (ModContent.GetInstance<ModConfigGT>().moveSpeedSwitchOffOn == true)
                                {
                                        if (ModContent.GetInstance<ModConfigGT>().moveSpeedRevC == true)
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().moveSpeedChangeType) 
                                                {
                                                case 1:
                                                        Player.moveSpeed -= ModContent.GetInstance<ModConfigGT>().moveSpeed;
                                                        break;
                                                case 2:
                                                        Player.moveSpeed  /= ModContent.GetInstance<ModConfigGT>().moveSpeed;
                                                        break;
                                                case 3:
                                                        Player.moveSpeed  = ModContent.GetInstance<ModConfigGT>().moveSpeed;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                

                                        }
                                        else
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().moveSpeedChangeType) 
                                                {
                                                case 1:
                                                        Player.moveSpeed += ModContent.GetInstance<ModConfigGT>().moveSpeed;
                                                        break;
                                                case 2:
                                                        Player.moveSpeed  *= ModContent.GetInstance<ModConfigGT>().moveSpeed;
                                                        break;
                                                case 3:
                                                        Player.moveSpeed = ModContent.GetInstance<ModConfigGT>().moveSpeed;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                        }
                                }
                                if (ModContent.GetInstance<ModConfigGT>().ManaCostSwitchOffOn == true)
                                {
                                        if (ModContent.GetInstance<ModConfigGT>().ManaCostRevC == true)
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().ManaCostChangeType) 
                                                {
                                                case 1:
                                                        Player.manaCost -= ModContent.GetInstance<ModConfigGT>().ManaCost;
                                                        break;
                                                case 2:
                                                        Player.manaCost  /= ModContent.GetInstance<ModConfigGT>().ManaCost;
                                                        break;
                                                case 3:
                                                        Player.manaCost  = ModContent.GetInstance<ModConfigGT>().ManaCost / 10;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                

                                        }
                                        else
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().ManaCostChangeType) 
                                                {
                                                case 1:
                                                        Player.manaCost += ModContent.GetInstance<ModConfigGT>().ManaCost;
                                                        break;
                                                case 2:
                                                        Player.manaCost  *= ModContent.GetInstance<ModConfigGT>().ManaCost;
                                                        break;
                                                case 3:
                                                        Player.manaCost = ModContent.GetInstance<ModConfigGT>().ManaCost / 10;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                        }
                                }

                                if (ModContent.GetInstance<ModConfigGT>().WingTimeSwitchOffOn == true)
                                {
                                        if (ModContent.GetInstance<ModConfigGT>().WingTimeRevC == true)
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().WingTimeChangeType) 
                                                {
                                                case 1:
                                                        Player.wingTimeMax -= ModContent.GetInstance<ModConfigGT>().WingTime;
                                                        break;
                                                case 2:
                                                        Player.wingTimeMax  /= ModContent.GetInstance<ModConfigGT>().WingTime;
                                                        break;
                                                case 3:
                                                        Player.wingTimeMax  = ModContent.GetInstance<ModConfigGT>().WingTime;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                

                                        }
                                        else
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().WingTimeChangeType) 
                                                {
                                                case 1:
                                                        Player.wingTimeMax += ModContent.GetInstance<ModConfigGT>().WingTime;
                                                        break;
                                                case 2:
                                                        Player.wingTimeMax  *= ModContent.GetInstance<ModConfigGT>().WingTime;
                                                        break;
                                                case 3:
                                                        Player.wingTimeMax = ModContent.GetInstance<ModConfigGT>().WingTime;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                        }
                                }
                                if (ModContent.GetInstance<ModConfigGT>().MaxSentriesSwitchOffOn == true)
                                {
                                        if (ModContent.GetInstance<ModConfigGT>().MaxSentriesRevC == true)
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().MaxSentriesChangeType) 
                                                {
                                                case 1:
                                                        Player.maxTurrets -= ModContent.GetInstance<ModConfigGT>().MaxSentries;
                                                        break;
                                                case 2:
                                                        Player.maxTurrets  /= ModContent.GetInstance<ModConfigGT>().MaxSentries;
                                                        break;
                                                case 3:
                                                        Player.maxTurrets  = ModContent.GetInstance<ModConfigGT>().MaxSentries;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                

                                        }
                                        else
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().MaxSentriesChangeType) 
                                                {
                                                case 1:
                                                        Player.maxTurrets += ModContent.GetInstance<ModConfigGT>().MaxSentries;
                                                        break;
                                                case 2:
                                                        Player.maxTurrets  *= ModContent.GetInstance<ModConfigGT>().MaxSentries;
                                                        break;
                                                case 3:
                                                        Player.maxTurrets = ModContent.GetInstance<ModConfigGT>().MaxSentries;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                        }
                                }
                                if (ModContent.GetInstance<ModConfigGT>().JumpSpeedSwitchOffOn == true)
                                {
                                        if (ModContent.GetInstance<ModConfigGT>().JumpSpeedRevC == true)
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().JumpSpeedChangeType) 
                                                {
                                                case 1:
                                                        Player.jumpSpeed  -= ModContent.GetInstance<ModConfigGT>().JumpSpeed;
                                                        break;
                                                case 2:
                                                        Player.jumpSpeed   /= ModContent.GetInstance<ModConfigGT>().JumpSpeed;
                                                        break;
                                                case 3:
                                                        Player.jumpSpeed   = ModContent.GetInstance<ModConfigGT>().JumpSpeed;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                        

                                        }
                                        else
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().JumpSpeedChangeType) 
                                                {
                                                case 1:
                                                        Player.jumpSpeed += ModContent.GetInstance<ModConfigGT>().JumpSpeed;
                                                        break;
                                                case 2:
                                                        Player.jumpSpeed  *= ModContent.GetInstance<ModConfigGT>().JumpSpeed;
                                                        break;
                                                case 3:
                                                        Player.jumpSpeed  = ModContent.GetInstance<ModConfigGT>().JumpSpeed;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                        }
                                }
                                if (ModContent.GetInstance<ModConfigGT>().JumpHeightSwitchOffOn == true)
                                {
                                        if (ModContent.GetInstance<ModConfigGT>().JumpHeightRevC == true)
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().JumpHeightChangeType) 
                                                {
                                                case 1:
                                                        Player.jumpHeight  -= ModContent.GetInstance<ModConfigGT>().JumpHeight;
                                                        break;
                                                case 2:
                                                        Player.jumpHeight   /= ModContent.GetInstance<ModConfigGT>().JumpHeight;
                                                        break;
                                                case 3:
                                                        Player.jumpHeight   = ModContent.GetInstance<ModConfigGT>().JumpHeight;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                        

                                        }
                                        else
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().JumpHeightChangeType) 
                                                {
                                                case 1:
                                                        Player.jumpHeight += ModContent.GetInstance<ModConfigGT>().JumpHeight;
                                                        break;
                                                case 2:
                                                        Player.jumpHeight  *= ModContent.GetInstance<ModConfigGT>().JumpHeight;
                                                        break;
                                                case 3:
                                                        Player.jumpHeight  = ModContent.GetInstance<ModConfigGT>().JumpHeight;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                        }
                                }
                                if (ModContent.GetInstance<ModConfigGT>().BlockRangeSwitchOffOn == true)
                                {
                                        if (ModContent.GetInstance<ModConfigGT>().BlockRangeRevC == true)
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().BlockRangeChangeType) 
                                                {
                                                case 1:
                                                        Player.blockRange  -= ModContent.GetInstance<ModConfigGT>().BlockRange;
                                                        break;
                                                case 2:
                                                        Player.blockRange   /= ModContent.GetInstance<ModConfigGT>().BlockRange;
                                                        break;
                                                case 3:
                                                        Player.blockRange   = ModContent.GetInstance<ModConfigGT>().BlockRange;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                        

                                        }
                                        else
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().BlockRangeChangeType) 
                                                {
                                                case 1:
                                                        Player.blockRange += ModContent.GetInstance<ModConfigGT>().BlockRange;
                                                        break;
                                                case 2:
                                                        Player.blockRange  *= ModContent.GetInstance<ModConfigGT>().BlockRange;
                                                        break;
                                                case 3:
                                                        Player.blockRange  = ModContent.GetInstance<ModConfigGT>().BlockRange;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                        }
                                }
                                if (ModContent.GetInstance<ModConfigGT>().tileSpeedSwitchOffOn == true)
                                {
                                        if (ModContent.GetInstance<ModConfigGT>().tileSpeedRevC == true)
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().tileSpeedChangeType) 
                                                {
                                                case 1:
                                                        Player.tileSpeed  -= ModContent.GetInstance<ModConfigGT>().tileSpeed;
                                                        break;
                                                case 2:
                                                        Player.tileSpeed   /= ModContent.GetInstance<ModConfigGT>().tileSpeed;
                                                        break;
                                                case 3:
                                                        Player.tileSpeed   = ModContent.GetInstance<ModConfigGT>().tileSpeed;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                        

                                        }
                                        else
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().tileSpeedChangeType) 
                                                {
                                                case 1:
                                                        Player.tileSpeed += ModContent.GetInstance<ModConfigGT>().tileSpeed;
                                                        break;
                                                case 2:
                                                        Player.tileSpeed  *= ModContent.GetInstance<ModConfigGT>().tileSpeed;
                                                        break;
                                                case 3:
                                                        Player.tileSpeed  = ModContent.GetInstance<ModConfigGT>().tileSpeed;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                        }
                                }
                                if (ModContent.GetInstance<ModConfigGT>().wallSpeedSwitchOffOn == true)
                                {
                                        if (ModContent.GetInstance<ModConfigGT>().wallSpeedRevC == true)
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().wallSpeedChangeType) 
                                                {
                                                case 1:
                                                        Player.wallSpeed  -= ModContent.GetInstance<ModConfigGT>().wallSpeed;
                                                        break;
                                                case 2:
                                                        Player.wallSpeed   /= ModContent.GetInstance<ModConfigGT>().wallSpeed;
                                                        break;
                                                case 3:
                                                        Player.wallSpeed   = ModContent.GetInstance<ModConfigGT>().wallSpeed;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                        

                                        }
                                        else
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().wallSpeedChangeType) 
                                                {
                                                case 1:
                                                        Player.wallSpeed += ModContent.GetInstance<ModConfigGT>().wallSpeed;
                                                        break;
                                                case 2:
                                                        Player.wallSpeed  *= ModContent.GetInstance<ModConfigGT>().wallSpeed;
                                                        break;
                                                case 3:
                                                        Player.wallSpeed  = ModContent.GetInstance<ModConfigGT>().wallSpeed;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                        }
                                }
                                if (ModContent.GetInstance<ModConfigGT>().MaxMinionsSwitchOffOn == true)
                                {
                                        if (ModContent.GetInstance<ModConfigGT>().MaxMinionsRevC == true)
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().MaxMinionsChangeType) 
                                                {
                                                case 1:
                                                        Player.maxMinions  -= ModContent.GetInstance<ModConfigGT>().MaxMinions;
                                                        break;
                                                case 2:
                                                        Player.maxMinions   /= ModContent.GetInstance<ModConfigGT>().MaxMinions;
                                                        break;
                                                case 3:
                                                        Player.maxMinions   = ModContent.GetInstance<ModConfigGT>().MaxMinions;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                        

                                        }
                                        else
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().MaxMinionsChangeType) 
                                                {
                                                case 1:
                                                        Player.maxMinions += ModContent.GetInstance<ModConfigGT>().MaxMinions;
                                                        break;
                                                case 2:
                                                        Player.maxMinions  *= ModContent.GetInstance<ModConfigGT>().MaxMinions;
                                                        break;
                                                case 3:
                                                        Player.maxMinions  = ModContent.GetInstance<ModConfigGT>().MaxMinions;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                        }
                                }
                                if (ModContent.GetInstance<ModConfigGT>().MiningSpeedSwitchOffOn == true)
                                {
                                        if (ModContent.GetInstance<ModConfigGT>().MiningSpeedRevC == true)
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().MiningSpeedChangeType) 
                                                {
                                                case 1:
                                                        Player.pickSpeed  -= ModContent.GetInstance<ModConfigGT>().MiningSpeed;
                                                        break;
                                                case 2:
                                                        Player.pickSpeed   /= ModContent.GetInstance<ModConfigGT>().MiningSpeed;
                                                        break;
                                                case 3:
                                                        Player.pickSpeed   = ModContent.GetInstance<ModConfigGT>().MiningSpeed;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                        

                                        }
                                        else
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().MiningSpeedChangeType) 
                                                {
                                                case 1:
                                                        Player.pickSpeed += ModContent.GetInstance<ModConfigGT>().MiningSpeed;
                                                        break;
                                                case 2:
                                                        Player.pickSpeed  *= ModContent.GetInstance<ModConfigGT>().MiningSpeed;
                                                        break;
                                                case 3:
                                                        Player.pickSpeed  = ModContent.GetInstance<ModConfigGT>().MiningSpeed;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                        }
                                }
                                if (ModContent.GetInstance<ModConfigGT>().CritChanceSwitchOffOn == true)
                                {
                                        Player.GetCritChance(DamageClass.Generic)  += ModContent.GetInstance<ModConfigGT>().CritChance;
                                }
                                if (ModContent.GetInstance<ModConfigGT>().AttackSpeedSwitchOffOn == true)
                                {
                                        if (ModContent.GetInstance<ModConfigGT>().AttackSpeedRevC == true)
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().AttackSpeedChangeType) 
                                                {
                                                case 1:
                                                        Player.GetAttackSpeed(DamageClass.Generic) -= ModContent.GetInstance<ModConfigGT>().MaxMinions;
                                                        break;
                                                case 2:
                                                        Player.GetAttackSpeed(DamageClass.Generic)  /= ModContent.GetInstance<ModConfigGT>().MaxMinions;
                                                        break;
                                                case 3:
                                                        Player.GetAttackSpeed(DamageClass.Generic)   = ModContent.GetInstance<ModConfigGT>().MaxMinions;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                        

                                        }
                                        else
                                        {
                                                switch(ModContent.GetInstance<ModConfigGT>().MaxMinionsChangeType) 
                                                {
                                                case 1:
                                                        Player.GetAttackSpeed(DamageClass.Generic) += ModContent.GetInstance<ModConfigGT>().MaxMinions;
                                                        break;
                                                case 2:
                                                        Player.GetAttackSpeed(DamageClass.Generic)  *= ModContent.GetInstance<ModConfigGT>().MaxMinions;
                                                        break;
                                                case 3:
                                                        Player.GetAttackSpeed(DamageClass.Generic)  = ModContent.GetInstance<ModConfigGT>().MaxMinions;
                                                        break;
                                                default:
                                                        ;
                                                        break;
                                                }
                                        }
                                }

                        }

                
                
                
                }
        }
}

		
	
