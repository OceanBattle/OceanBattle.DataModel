﻿using Newtonsoft.Json;
using OceanBattle.DataModel.Game.Abstractions;

namespace OceanBattle.DataModel.Game.EnviromentElements
{
    public class Armour : Cell
    {
        public int MaxHP { get; private set; }

        public int HP { get; private set; }

        [JsonConstructor]
        public Armour(int hp, int maxHP)
        {
            HP = hp;
            MaxHP = maxHP;
            IsPopulated = true;
        }

        public Armour(int hp)        {
            MaxHP = hp;
            HP = hp;
            IsPopulated = true;
        }

        public override void Hit(int damage)
        {
            if (HP > damage)
                HP -= damage;
            else
                HP = 0;

            base.Hit(damage);
        }
    }
}
