using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Inventory
    {
        Status status;
        public Inventory(Status sharedstatus)
        {
            status = sharedstatus;
        }
        public List<equipment> itemList = new List<equipment>();

        public void addItem(equipment item)
        {
            itemList.Add(item);
        }

        public void ShowInventory(int i)
        {
            Console.WriteLine("[아이템 목록]");

            var sortedList = itemList.OrderBy(item => item.type).ThenBy(item => item.price).ToList();
            int t = 1;
            foreach (var item in sortedList)
            {
                item.showItem(i, t);
                t++;
            }
        }
        public void ShowInventory()
        {
            var sortedList = itemList.OrderBy(item => item.type).ThenBy(item => item.price).ToList();
            Console.WriteLine("[아이템 목록]");
            int t = 1;
            foreach (var item in sortedList)
            {
                item.showItem(0, 0);
            }
        }

        public void equipItem(int itemID)
        {
            string equipname = itemList[itemID - 1].name;
            foreach (var item in itemList)
            {
                if (equipname == item.name)
                {
                    if (item.isEquip == true)
                    {
                        Console.WriteLine("장착을 해제합니다.");
                        status.equipATK -= item.ATK;
                        status.equipDEF -= item.DEF;
                        item.isEquip = false;
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"{item.name}을(를) 장착합니다.");
                        item.isEquip = true;
                        status.equipATK += item.ATK;
                        status.equipDEF += item.DEF;
                        return;
                    }
                }
            }
        }
    }
}
