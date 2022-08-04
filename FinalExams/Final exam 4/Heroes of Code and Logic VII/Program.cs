using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var hero = new Dictionary<string, Dictionary<int, int>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] token = input.Split();

                string name = token[0];
                int hp = int.Parse(token[1]);
                int mana = int.Parse(token[2]);

                hero.Add(name, new Dictionary<int, int>());
                hero[name].Add(hp, mana);
            }

            string command = "";
            while (command != "End")
            {
                command = Console.ReadLine();
                string[] token = command.Split(" - ");

                string type = token[0];
                switch (type)
                {
                    case "CastSpell":
                        SpellMethod(token, hero);
                        break;
                    case "TakeDamage":
                        DamageMethod(token, hero);
                        break;
                    case "Recharge":
                        IncreaseMethod(token, hero);
                        break;
                    case "Heal":
                        HealMethod(token, hero);
                        break;
                }
            }
            foreach (var item in hero)
            {
                int hp = item.Value.FirstOrDefault().Key;
                int mana = item.Value.FirstOrDefault().Value;

                Console.WriteLine(item.Key);
                Console.WriteLine($"  HP: {hp}");
                Console.WriteLine($"  MP: {mana}");
            }
        }

        private static void HealMethod(string[] token, Dictionary<string, Dictionary<int, int>> hero)
        {
            string heroName = token[1];
            int amount = int.Parse(token[2]);
            int currMana = hero[heroName].Values.First();
            int currHP = hero[heroName].Keys.First();

            if (hero[heroName].Keys.First() + amount > 100)
            {
                hero[heroName].Clear();
                hero[heroName].Add(100, currMana);
                Console.WriteLine($"{heroName} healed for {100 - currHP} HP!");
            }
            else
            {
                currHP += amount;
                hero[heroName].Clear();
                hero[heroName].Add(currHP, currMana);
                Console.WriteLine($"{heroName} healed for {amount} HP!");
            }
        }

        private static void IncreaseMethod(string[] token, Dictionary<string, Dictionary<int, int>> hero)
        {
            string heroName = token[1];
            int amount = int.Parse(token[2]);
            int currMana = hero[heroName].Values.First();
            int currHP = hero[heroName].Keys.First();           
          
            if(hero[heroName].Values.First() + amount > 200)
            {
                hero[heroName].Clear();
                hero[heroName].Add(currHP, 200);
                Console.WriteLine($"{heroName} recharged for {200 - currMana} MP!");
            }
            else
            {
                currMana += amount;
                hero[heroName].Clear();
                hero[heroName].Add(currHP, currMana);
                Console.WriteLine($"{heroName} recharged for {amount} MP!");
            }
        }

        private static void DamageMethod(string[] token, Dictionary<string, Dictionary<int, int>> hero)
        {
            string heroName = token[1];
            int damage = int.Parse(token[2]);
            string attacker = token[3];
            int currMana = hero[heroName].Values.First();
            int currHP = hero[heroName].Keys.First();

            currHP -= damage;
            hero[heroName].Clear();
            hero[heroName].Add(currHP, currMana);          

            if(hero[heroName].Keys.First() <= 0)
            {
                Console.WriteLine($"{heroName} has been killed by {attacker}!");
                hero.Remove(heroName);
            }
            else
            {
                Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {currHP} HP left!");
            }
        }

        private static void SpellMethod(string[] token, Dictionary<string, Dictionary<int, int>> hero)
        {
            string heroName = token[1];
            int needed = int.Parse(token[2]);
            string spell = token[3];
            int currMana = hero[heroName].Values.First();
            int currHP = hero[heroName].Keys.First();

            if (hero[heroName].Values.First() >= needed)
            {
                currMana -= needed;
                hero[heroName].Clear();
                hero[heroName].Add(currHP, currMana);
                Console.WriteLine($"{heroName} has successfully cast {spell} and now has {currMana} MP!");
            }
            else
            {
                Console.WriteLine($"{heroName} does not have enough MP to cast {spell}!");
            }
        }
    }
}
