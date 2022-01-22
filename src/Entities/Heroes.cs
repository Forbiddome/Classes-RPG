using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace ClassesRPG.src.Entities
{
    public class Heroes
    {
        //ABSTRAÇÃO E ENCAPSULAMENTO DE ATRIBUTOS
        public string Name{get;set;}
        public string Class{get;set;}
        public double HP{get;set;}
        public int Level{get;set;}
        public Skills Skill{get;set;}

        //ABSTRAÇÃO DE MÉTODOS
        public virtual string DamageDealt(){
                return ($@"A habilidade {this.Skill.Name} causou {this.Skill.Damage} pontos como dano {this.Skill.DamageType}.
                E agora os ataques básicos causam dano físico.");
        }
        public override string ToString(){
            return ($@"
            Name: {this.Name}
            Class: {this.Class}
            Level: {this.Level}
            HP: {this.HP}
            Skill: {this.Skill.Name}");
        }
    }
}