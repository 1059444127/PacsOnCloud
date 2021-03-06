﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lords.DataModel
{
    public class Sword : BattleBase
    {                
        public Sword(string id)
            : base(id)
        {
            AttackInterval = 0.8;
            Health = 220;
            Hit = 32;
            Armor = 12;
            NoArmorHurt = 0;
        }
    }

    public class SwordArmy : Army
    {
        public SwordArmy(string id)
            : base(id)
        {
            _maxCount = 50;
            RecruitRound = 1;
            InitializeBattleUnits(_maxCount);
        }

        protected override BattleBase NewBattleBase(string id)
        {
            string theId = "Sword " + id;
            return new Sword(theId);
        }
    }
}
