using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficemanFantasy.Models
{
    public class Unit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public string AvatarURL { get; set; }

        public Unit(string name, int health, string avatarURL)
        {
            Name = name;
            Health = health;
            AvatarURL = avatarURL;
        }

        public void ApplyDamage(int damage)
        {
            Health -= damage;
        }
    }
}
