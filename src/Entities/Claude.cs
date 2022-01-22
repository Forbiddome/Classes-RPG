using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesRPG.src.Entities
{
    public class Claude : Heroes
    {        
        public Claude (string Name, string Class, int Level, double HP,Skills Skill) {
        this.Name = Name;
        this.Class = Class;
        this.Level = Level;
        this.HP = HP;
        this.Skill = Skill;
        }
        public override string DamageDealt(){
                return ($@"
A habilidade {this.Skill.Name} vai causar {this.Skill.Damage} pontos de dano {this.Skill.DamageType}.
E os ataques básicos agora causam dano Verdadeiro");
        }

    }
}