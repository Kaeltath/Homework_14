using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework8;
using Homework9;
using System.ComponentModel;
using GenericSouls;

namespace HomeworksHome
{
   
    class Transaction_hendler
    {
       private int counter = 0;

       GenericSouls.MyQueue<object> ArrQueue;
       GenericSouls.MyStack<object> ArrStack;
       Homework8.DynamicQueue<object> newQueue;
       Homework8.DynamicStack<object> newStack;
       Homework9.DynamicQueue<object> newQueueDyn;
       Homework9.DynamicStack<object> newStackDyn;
       Queue<object> StndQueue;
       Stack<object> StndStack;

        public void ChooseImp(int choose,int choose_typemode, int maxsize) 
        {
            
            if (choose == 1)
            {
                ArrQueue = new GenericSouls.MyQueue<object>(maxsize);
                ArrStack = new GenericSouls.MyStack<object>(maxsize); 
            }
            else if (choose ==2)
            {
                newQueue = new Homework8.DynamicQueue<object>(maxsize);
                newStack = new Homework8.DynamicStack<object>(maxsize);    
            }
            else if (choose == 3)
            {
                 newQueueDyn = new Homework9.DynamicQueue<object>(maxsize);
                 newStackDyn = new Homework9.DynamicStack<object>(maxsize);

            }
            else
            {            
                StndQueue = new Queue<object>(maxsize);
                StndStack = new Stack<object>(maxsize);                 
            }    
        
        }
        

        public void Put(object a, int choose_typemode, int choose) 
        {
            if (choose == 1)
            {
                switch (choose_typemode)
                {
                    case 1:
                        ArrQueue.Enqueue(a);
                        counter++;
                        break;
                    case 2:
                        ArrStack.Push(a);
                        counter++;
                        break;
                }
            }
            else if (choose == 2)
            {
                switch (choose_typemode)
                {
                    case 1:
                        newQueue.Enqueue(a);
                        counter++;
                        break;
                    case 2:
                        newStack.Push(a);
                        counter++;
                        break;
                }

            }
            else if (choose == 3)
            {
                switch (choose_typemode)
                {
                    case 1:
                        newQueueDyn.Enqueue(a);
                        counter++;
                        break;
                    case 2:
                        newStackDyn.Push(a);
                        counter++;
                        break;
                }

            }
            else 
            {
            switch (choose_typemode)
            {
                case 1:
                    StndQueue.Enqueue(a);
                    counter++;
                    break;
                case 2:
                    StndStack.Push(a);
                    counter++;
                    break;
            }

            }    
            
        }

        public object pull(int choose_typemode,int choose) 
        {
            object temp;
            if (choose == 1)
            {

                switch (choose_typemode)
                {
                    case 1:
                        temp = ArrQueue.Dequeue();
                        counter--;
                        return temp;

                    case 2:
                        temp = ArrStack.Pop();
                        counter--;
                        return temp;

                    default:
                        return default(object);
                }
            }      
            else if (choose == 2)
            {
                switch (choose_typemode)
                {
                    case 1:
                        temp = newQueue.Dequeue();
                        counter--;
                        return temp;

                    case 2:
                        temp = newStack.Pop();
                        counter--;
                        return temp;

                    default:
                        return default(object);
                }      

            }
            else if (choose == 3)
            {
                switch (choose_typemode)
                {
                    case 1:                            
                        temp = newQueueDyn.Dequeue();
                        counter--;
                        return temp;

                    case 2:
                        temp = newStackDyn.Pop();
                        counter--;
                        return temp;

                    default:
                        return default(object);
                }      

            }
            else 
           {
               switch (choose_typemode)
               {
                   case 1:
                       temp = StndQueue.Dequeue();
                       counter--;
                       return temp;

                   case 2:
                       temp = StndStack.Pop();
                       counter--;
                       return temp;

                   default:
                       return default(object);
               }      
           }
            
        }

        public int SizeFact 
        {
            get { return counter; }
        }
        
    }
}
