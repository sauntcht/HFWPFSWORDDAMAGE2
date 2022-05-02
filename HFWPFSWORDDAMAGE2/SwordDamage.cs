﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFWPFSWORDDAMAGE2
{
    internal class SwordDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;

        public int Roll;
        public decimal MagicMultiplier = 1m;
        public int FlamingDamage = 0;
        public int Damage;

        public void CalcutlateDamage()
        {
            Damage = (int)(Roll * MagicMultiplier) + BASE_DAMAGE + FlamingDamage;
        }
        public void SetMagic(bool isMagic)
        {
            if (isMagic)
            {
                MagicMultiplier = 1.75m;
            }
            else
            {
                MagicMultiplier = 1m;
            }
        }
        public void SetFlaming(bool isFlaming)
        { 
        CalcutlateDamage();
            if (isFlaming)
            {
                Damage += FLAME_DAMAGE;
            }
        
        }


    }
}
