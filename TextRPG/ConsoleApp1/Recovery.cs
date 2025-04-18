using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Recovery
    {
        public void StartRecovery(Status sharedstatue)
        {
            if (sharedstatue.gold > 500)
            { 
                if(sharedstatue.hp == 100)
                {
                    Console.WriteLine("체력이 가득 차 있습니다.");
                    return;
                }
                sharedstatue.hp = 100;
                sharedstatue.gold -= 500;
                Console.WriteLine("체력을 최대까지 회복했습니다.");
                Console.WriteLine($"남은 골드: {sharedstatue.gold}");
            }
            else
            {
                Console.WriteLine("회복할 골드가 부족합니다.");
                return;
            }
        }
    }
}
