using System;
using static System.Console;
using ClassesRPG.src.Entities;

namespace ClassesRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            //P.O.O. EM SÍ
            Skills Skill1 = new Skills("Cross Cut","Físico",5);
            Skills Skill2 = new Skills("Fire Ball","Mágico",12);
            Skills Skill3 = new Skills("Cure","Mágico",6);
            Skill3.Duration = 5;
            Claude Claudio = new Claude("Claudio","Espadachim",6,250,Skill1);
            Azerutan Azerutan = new Azerutan ("Azerutan","Mago",5,82.5f,Skill2,Skill3);

            WriteLine(Claudio);
            WriteLine(Azerutan);
            WriteLine();
            WriteLine(Claudio.DamageDealt());
            WriteLine(Azerutan.DamageDealt());
            WriteLine();



        }
    }
}
