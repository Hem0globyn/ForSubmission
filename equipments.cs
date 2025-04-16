using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class equipment
    {
        public string name;
        public bool isEquip = false;
        public bool isSold = false;
        public int price;
        public ItemType type;
        public string text;
        public int ATK;
        public int DEF;
        public enum ItemType
        {
            Weapon = 1,
            Armor
        }
        public void showItem(int k, int t)
        {
            if (k == 0)
            {
                if (isEquip == false)
                    Console.WriteLine("-" + text);
                else
                    Console.WriteLine("-[E]" + text);
            }
            else if (k == 1)
            {
                if (isEquip == false)
                    Console.WriteLine($"- {t} {text}");
                else
                    Console.WriteLine($"-[E] {t} {text}");

            }

        }
    }
    ////////////////////////////////////////////    아래에 장비 종류를 추가가능    //////////////////////////////////////
    public class RustySword : equipment
    {
        public RustySword()
        {
            name = "녹슨검";
            type = ItemType.Weapon;
            price = 600;
            ATK = 2;
            isEquip = false;
            text = "녹슨검 | 공격력 +2 | 쉽게 볼 수 있는 낡은 검.";
        }
    }
    public class MetalPlate : equipment
    {
        public MetalPlate()
        {
            name = "무쇠갑옷";
            type = ItemType.Armor;
            price = 2000;
            DEF = 10;
            isEquip = false;
            text = "무쇠갑옷 | 방어력 +10 | 무쇠로 만들어져 튼튼한 갑옷.";
        }
    }
    public class SpartanSpear : equipment
    {
        public SpartanSpear()
        {
            name = "스파르타의 창";
            type = ItemType.Weapon;
            price = 3000;
            ATK = 7;
            isEquip = false;
            text = "스파르타의 창 | 공격력 +7 | 스파르타의 전사들이 사용했다는 전설의 창.";
        }
    }
    public class TrainerArmor : equipment
    {
        public TrainerArmor()
        {
            name = "수련자 갑옷";
            type = ItemType.Armor;
            price = 1000;
            DEF = 5;
            isEquip = false;
            text = "수련자 갑옷 | 방어력 +5 | 수련에 도움을 주는 갑옷입니다.";
        }
    }
    public class SpartanArmor : equipment
    {
        public SpartanArmor()
        {
            name = "스파르타 갑옷";
            type = ItemType.Armor;
            price = 3500;
            DEF = 15;
            isEquip = false;
            text = "스파르타 갑옷 | 방어력 +15 | 스파르타 전사들이 사용했다는 전설의 갑옷.";
        }
    }
    public class BronzeAxe : equipment
    {
        public BronzeAxe()
        {
            name = "청동 도끼";
            type = ItemType.Weapon;
            price = 1500;
            ATK = 5;
            isEquip = false;
            text = "청동 도끼 | 공격력 | 어디선가 사용됐던것 같은 도끼.";
        }
    }
}
