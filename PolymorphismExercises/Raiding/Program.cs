using Raiding;
using System;
using System.Collections.Generic;

namespace MyApp 
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<BaseHero> raidGroup = new List<BaseHero>();

            int count = 0;

            while (n!=count)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();
                try
                {

                    switch (heroType)
                    {
                        case "Druid":
                            Druid druid = new Druid(heroName);
                            raidGroup.Add(druid);
                            count++;
                            break;

                        case "Warrior":
                            Warrior warrior = new Warrior(heroName);
                            raidGroup.Add(warrior);
                            count++;
                            break;

                        case "Paladin":
                            Paladin paladin = new Paladin(heroName);
                            raidGroup.Add(paladin);
                            count++;
                            break;

                        case "Rogue":
                            Rogue rogue = new Rogue(heroName);
                            raidGroup.Add(rogue);
                            count++;
                            break;
                        default:
                            Console.WriteLine("Invalid hero!");
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
               

            }

            int sumOfGroup = 0;   

            int bossPower = int.Parse(Console.ReadLine());

            foreach (BaseHero hero in raidGroup)
            {
                sumOfGroup += hero.Power;
                Console.WriteLine(hero.CastAbility());

            }

            if (sumOfGroup>=bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }


        }
    }
}