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
        public int[] stat = { 1, 100, 10, 5, 0, 0, 5000 }; // level, hp, attack, defense, equipATK, equipDEF, gold

        public void ShowStatus()
        {
            Console.WriteLine();
            Console.WriteLine($"{name} ({job})");
            Console.WriteLine($"레벨: {stat[0]}");
            Console.WriteLine($"체력: {stat[1]}");
            if (stat[4] == 0)
                Console.WriteLine($"공격력: {stat[2]}");
            else
                Console.WriteLine($"공격력: {stat[2]} + {stat[4]}");
            if (stat[5] == 0)
                Console.WriteLine($"방어력: {stat[3]}");
            else
                Console.WriteLine($"방어력: {stat[3]} + {stat[5]}");
            Console.WriteLine($"골드: {stat[6]}");
        }

    }



}
