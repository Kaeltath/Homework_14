using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSouls
{
    class Program
    {
         static void Main(string[] args)
        {
            int choose;
            Console.WriteLine("enter 1 for queue simulation");
            Console.WriteLine("enter 2 for stack simulation");
            Console.WriteLine("enter 3 for bubble sorting");
            Console.WriteLine("enter 4 for insertion sorting");
            if (!int.TryParse(Console.ReadLine(), out choose) || choose < 1 || choose > 4)
            {
                Console.WriteLine("unsuported expression");
                Console.ReadKey();
                return;
            }

             switch (choose)
             {
                 case 1:
                     MyQueue<string> tryQueue = new MyQueue<string>(12);
                     for (int j = 1; j < 40; j++)
                     {
                         Console.WriteLine("plese input next element to be put in queue");
                         string value = Console.ReadLine();
                         tryQueue.Enqueue(value);
                         if (j%1 == 0)
                         {
                             if (!tryQueue.IsEmpty())
                             {
                                 tryQueue.Dequeue();
                             }
                             else
                             {
                                 Console.WriteLine("queue is empty");
                             }
                         }
                         tryQueue.Print();
                     }
                     break;
                 case 2:
                     MyStack<string> tryStack = new MyStack<string>(12);
                     string topush;
                     for (int i = 1; i < 20; i++){

                        //Console.WriteLine("Please input next element to be pushed to stack");
                        topush = Console.ReadLine();
                        tryStack.Push(topush);
                      

                        if (i % 2 == 0)
                        {
                            if (!tryStack.IsEmpty())
                            {
                                tryStack.Pop();
                                
                            }
                            else
                            {
                                Console.WriteLine("Stack is empty");
                            }

                        }
                        tryStack.Print();

                    }
                    /*   int topeek;
                       if (!tryStack.isEmpty())
                       {
                           Console.WriteLine("{0}", topeek);
                       }
                       else
                       {
                           Console.WriteLine("Stack is empty");
                       }*/


                     break;
                 
                 case 3:

                     TestingCollection[] itemList = new TestingCollection[5];
                     {
                         itemList[0] = new TestingCollection("Lord Of Cinder Gwinn", 200);
                         itemList[1] = new TestingCollection("Soler", 28);
                         itemList[2] = new TestingCollection("Loscutic", 19);
                         itemList[3] = new TestingCollection("Gorogoil", 80);
                         itemList[4] = new TestingCollection("Lotrah", 32);
                     }
                    BubbleSorter<TestingCollection> tryBubble = new BubbleSorter<TestingCollection>(itemList);
                    tryBubble.Sort();
                    tryBubble.Print();
                    Console.ReadLine();
                    break;

                 case 4:
                    
                     TestingCollection[] itemListIns = new TestingCollection[5];
                     {
                         itemListIns[0] = new TestingCollection("Lord Of Cinder Gwinn", 200);
                         itemListIns[1] = new TestingCollection("Soler", 28);
                         itemListIns[2] = new TestingCollection("Loscutic", 19);
                         itemListIns[3] = new TestingCollection("Gorogoil", 80);
                         itemListIns[4] = new TestingCollection("Lotrah", 32);
                     } 
                    InsertionSorter<TestingCollection> tryInsertion = new InsertionSorter<TestingCollection>(itemListIns);
                    tryInsertion.Sort();
                    tryInsertion.Print();
                    Console.ReadLine();
                    break;
                                                            
             }
        }
    }
}
