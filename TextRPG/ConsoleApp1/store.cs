using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class store
    {
        Inventory inventory;
        public List<equipment> shopList = new List<equipment>();
        
        public store(Inventory sharedinventory)
        {
            inventory = sharedinventory;
            shopList.Add(new RustySword());
            shopList.Add(new BronzeAxe());
            shopList.Add(new SpartanSpear());
            shopList.Add(new TrainerArmor());
            shopList.Add(new MetalPlate());
            shopList.Add(new SpartanArmor());
            shopList.Add(new MyItem());
        }

        public void Showshop()
        {
            Console.WriteLine("상점에 오신 것을 환영합니다.");
            int i = 1;
            foreach (var item in shopList)
            {
                if (item.isSold == false)
                {
                    if (item.type == equipment.ItemType.Weapon)
                        Console.WriteLine($"{i}. {item.name} (가격: {item.price} gold) | 공격력 {item.ATK} | {item.text}");
                    else
                        Console.WriteLine($"{i}. {item.name} (가격: {item.price} gold) | 방어력 {item.DEF} | {item.text}");
                }
                else
                {
                    if (item.type == equipment.ItemType.Weapon)
                        Console.WriteLine($"{i}. {item.name} (가격: {item.price} gold) | 공격력 {item.ATK} | {item.text} ---Sold Out");
                    else
                        Console.WriteLine($"{i}. {item.name} (가격: {item.price} gold) | 방어력 {item.DEF} | {item.text} ---Sold Out");
                }
                i++;
            }
            Console.WriteLine("0. 상점 나가기");
        }
        public void buyItem(int itemIndex, Status status)
        {

            equipment item = shopList[itemIndex - 1];
            if (item.isSold == true)
            {
                Console.Clear();
                Console.WriteLine("이미 판매된 아이템입니다.\n");
                return;
            }
            if (status.gold >= item.price)
            {
                Console.Clear();
                Console.WriteLine($"{item.name}을(를) 구매했습니다.\n");
                status.gold -= item.price;
                item.isSold = true;
                inventory.addItem(item);

            }
            else
            {
                Console.WriteLine("금액이 부족합니다.");
            }
        }
    }
}
