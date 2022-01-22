using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesRPG.src.Entities
{
    public class Azerutan : Heroes
    {
        //ADICIONANDO O ATRIBUTO 6 PARA O CONSTRUTOR DE 6 ARGUMENTOS)
        public Skills Skill3;
        public Azerutan (string Name, string Class, int Level, double HP, Skills Skill, Skills Skill3) {
        this.Name = Name;
        this.Class = Class;
        this.Level = Level;
        this.HP = HP;
        this.Skill = Skill;
        this.Skill3 = Skill3;
        }
        //POLIMORFISMOS
        public override string DamageDealt(){
                return ($@"
A habilidade {this.Skill.Name} vai causar {this.Skill.Damage} pontos de dano {this.Skill.DamageType}. Agora os ataques básicos causam 
dano mágico e é ativado a habilidade {this.Skill3.Name} recebendo por segundo vida igual a {this.Skill3.Damage} de vida durante {this.Skill3.Duration} segundos.");
        }

    } 
}