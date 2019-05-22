using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    abstract class Stats
    {
        private string name;
        private int health;
        private int armorBonus;
        private int damageBonus;
        private int attackBonus;
        private int defenseBonus;
        private int weaponNumberOfDice;
        private int weaponDamageDice;
        private int gold;

        public string Name { get => name; set => name = value; }
        public int Health { get => health; set => health = value; }
        public int ArmorBonus { get => armorBonus; set => armorBonus = value; }
        public int DamageBonus { get => damageBonus; set => damageBonus = value; }
        public int AttackBonus { get => attackBonus; set => attackBonus = value; }
        public int DefenseBonus { get => defenseBonus; set => defenseBonus = value; }
        public int WeaponNumberOfDice { get => weaponNumberOfDice; set => weaponNumberOfDice = value; }
        public int WeaponDamageDice { get => weaponDamageDice; set => weaponDamageDice = value; }
        public int Gold { get => gold; set => gold = value; }
    }
}
