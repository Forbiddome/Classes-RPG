using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesRPG.src.Entities
{
        public class Skills
        {
            public string Name{get;set;}
            public string DamageType{get;set;}
            public int Damage{get;set;}
            public int Duration{get;set;}

            public Skills (string Name, string DamageType, int Damage) {
                this.Name = Name;
                this.DamageType = DamageType;
                this.Damage = Damage;
            }
            //SOBRECARGA DO METODO CONSTRUTOR
            public Skills (string Name, string DamageType, int Damage, int Duration) {
                this.Name = Name;
                this.DamageType = DamageType;
                this.Damage = Damage;
            }
        }
}