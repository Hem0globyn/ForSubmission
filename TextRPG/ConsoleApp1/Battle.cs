using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Battle
    {
        Inventory inventory;
        Status status;
        public Battle(Inventory maininventory, Status mainstatus)
        {
            inventory = maininventory;
            status = mainstatus;
        }
        public void StartBattle(int propdef)
        {
            if (status.defense + status.equipDEF < propdef)
            {
                Random random = new Random();
                int clearrate = random.Next(0, 10);
                if (clearrate < 4)
                {
                    Console.WriteLine("던전 클리어 성공");
                    HPcal(propdef);
                    Console.WriteLine($"현재 체력 {status.hp}");
                }
                else
                {
                    Console.WriteLine("던전 클리어 실패");
                    Console.WriteLine($"소모된 체력{status.hp / 2}");
                    status.hp /= 2;
                    Console.WriteLine($"현재 체력{status.hp}");
                    return;
                }
            }
            else
            {
                Console.WriteLine("던전 클리어 성공");
                HPcal(propdef);
                Console.WriteLine($"현재 체력 {status.hp}");
            }
            Reward(propdef);
        }
        public void HPcal(int propdef)
        {
            int defdiff = propdef - (status.defense + status.equipDEF);
            Random random = new Random();
            int damage = random.Next(20 + defdiff , 36 + defdiff);
            Console.WriteLine($"소모된 체력 : {damage}");
            status.hp -= damage;
        }

        public void Reward(int propdef)
        {
            Random random = new Random();
            if (propdef == 5)
            {
                double reward = 1000;
                reward = (int)(reward * ((100.0f + (random.NextDouble() + 1) * (status.attack + status.equipATK)) / 100.0f));
                Console.WriteLine($"보상으로 {reward}골드를 획득했습니다.");
                status.gold += (int)reward;
                Console.WriteLine($"공격력으로 인한 추가 보상{status.attack+status.equipATK}% ~ {2*(status.attack + status.equipATK)}");
                Console.WriteLine($"현재 보유 금액: {status.gold} gold");
            }
            else if (propdef == 11)
            {
                double reward = 1700;
                reward = (int)(reward * ((100.0f + (random.NextDouble() + 1) * (status.attack + status.equipATK)) / 100.0f));
                Console.WriteLine($"보상으로 {reward}골드를 획득했습니다.");
                status.gold += (int)reward;
                Console.WriteLine($"공격력으로 인한 추가 보상{status.attack + status.equipATK}% ~ {2 * (status.attack + status.equipATK)}");
                Console.WriteLine($"현재 보유 금액: {status.gold} gold");
            }
            else if (propdef == 17)
            {
                double reward = 2500;
                reward = (int)(reward * ((100.0f + (random.NextDouble() + 1) * (status.attack + status.equipATK)) / 100.0f));
                Console.WriteLine($"보상으로 {reward}골드를 획득했습니다.");
                status.gold += (int)reward;
                Console.WriteLine($"공격력으로 인한 추가 보상{status.attack + status.equipATK}% ~ {2 * (status.attack + status.equipATK)}");
                Console.WriteLine($"현재 보유 금액: {status.gold} gold");
            }
            else
                return;
        }
    }
}
