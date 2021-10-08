using Challenge.SimpleDungeon.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.SimpleDungeon.Pickables
{
    public abstract class Pickable : GridObject
    {
        public int HitPointsEffect { get; protected set; }
        public int DamageEffect { get; protected set; }

        public Pickable(int hpEffect, int dmgEffect) : base(true, true)
        {
            HitPointsEffect = hpEffect;
            DamageEffect = dmgEffect;
        }
    }
}
