using System;
using System.ComponentModel.Design;
using System.Numerics;
using System.Xml.Linq;

namespace ConsoleApp1
{
   
    internal class Program
    {
        static string answer;
        // 캐릭터 생성
        static void Main(string[] args)
        {
            Status status = new Status();
            Inventory inventory = new Inventory(status);
            store store = new store(inventory);

            Console.WriteLine("게임을 시작합니다.\n");
            Console.WriteLine("캐릭터를 생성합니다.\n");
            while (true)
            {
                Console.WriteLine("이름을 입력하세요: ");
                status.name = Console.ReadLine();
                Console.WriteLine("이름: " + status.name);
                Console.WriteLine("이름이 맞습니까?");
                Console.WriteLine("1. 맞습니다 / 2. 다시 입력합니다");
                answer = Console.ReadLine();
                if (answer == "1")
                {
                    Console.WriteLine("\n");
                    break;
                }
                else if (answer == "2")
                {
                    Console.WriteLine("이름을 다시 입력하세요.\n");
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 시도하세요.\n");
                }
            }
            while (true)
            {
                Console.WriteLine("직업을 선택해주세요");
                Console.WriteLine("1. 전사  /  2: 도적");
                Console.Write("직업을 선택하세요: ");
                status.job = Console.ReadLine();
                if (status.job == "1")
                {
                    Console.WriteLine("전사를 선택하셨습니다.\n");
                    Console.WriteLine("전사로 시작합니다.");
                    Console.WriteLine("1. Yes / 2. No");
                    answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        Console.WriteLine("전사로 시작합니다.");
                        status.job = "전사";
                        break;
                    }
                    else if (answer == "2")
                    {
                        Console.WriteLine("직업을 다시 선택하세요.\n");
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다. 다시 시도하세요.");
                    }
                }
                else if (status.job == "2")
                {
                    Console.WriteLine("도적을 선택하셨습니다.\n");
                    Console.WriteLine("도적으로 시작합니다.");
                    Console.WriteLine("1. Yes / 2. No");
                    answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        Console.WriteLine("도적으로 시작합니다.");
                        status.job = "도적";
                        break;
                    }
                    else if (answer == "2")
                    {
                        Console.WriteLine("직업을 다시 선택하세요.\n");
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다. 다시 시도하세요.\n");
                    }
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 시도하세요.\n");
                }
            }
            
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("이름: " + status.name);
                Console.WriteLine("직업: " + status.job + "\n");
                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.\n이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");
                Console.WriteLine("1. 상태 보기 / 2. 인벤토리 / 3. 상점\n");
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                answer = Console.ReadLine();
                if (answer == "1")
                {
                    status.ShowStatus();
                    Console.WriteLine("0. 나가기");
                    while (true)
                    {
                        answer = Console.ReadLine();
                        if (answer == "0")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다.\n");
                        }
                    }
                }
                else if (answer == "2")
                {
                    while (true)
                    {
                        Console.WriteLine("인벤토리");
                        inventory.ShowInventory();
                        Console.WriteLine("\n0. 나가기\n1.장착관리");
                    
                        answer = Console.ReadLine();
                        if (answer == "0")
                        {
                            break;
                        }
                        else if (answer == "1")
                        {
                            bool isint;
                            while (true)
                            {
                                Console.WriteLine("장착할 아이템의 번호를 입력하세요.");
                                inventory.ShowInventory(1);
                                isint = Int32.TryParse(Console.ReadLine(), out int result);
                                if (isint == true && 0 < result && result <= inventory.itemList.Count)
                                {
                                    Console.Clear();
                                    inventory.equipItem(result);
                                    Console.WriteLine("");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("잘못된 입력입니다.\n");
                                    break;
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다.\n");
                        }
                    }
                }
                else if (answer == "3")
                {
                    while (true)
                    {
                        Console.WriteLine($"현재 보유 금액: {status.stat[6]} gold\n");
                        store.Showshop();
                        
                        if (Int32.TryParse(Console.ReadLine(), out int shopindex))
                        {
                            if (shopindex == 0)
                            {
                                Console.Clear();
                                break;
                            }
                            else if (shopindex <= store.shopList.Count && shopindex > 0)
                            {
                                store.buyItem(shopindex, status);
                            }else
                                Console.WriteLine("잘못된 입력입니다.\n");
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다.\n");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.\n");
                }
            }
        }
    }
}
