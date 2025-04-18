using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Status
    {
        public string name;
        public string job;
        public int level = 1;
        public int hp = 100;
        public int attack = 10;
        public int defense = 5;
        public int equipATK = 0;
        public int equipDEF = 0;
        public int gold =1500;
        public void ShowStatus()
        {
            Console.WriteLine();
            Console.WriteLine($"{name} ({job})");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"체력: {hp}");
            if (equipATK == 0)
                Console.WriteLine($"공격력: {attack}");
            else
                Console.WriteLine($"공격력: {attack} + {equipATK}");
            if (equipDEF == 0)
                Console.WriteLine($"방어력: {defense}");
            else
                Console.WriteLine($"방어력: {defense} + {equipDEF}");
            Console.WriteLine($"골드: {gold}");
        }

    }



}
