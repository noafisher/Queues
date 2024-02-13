using System;

using Queues.Models;
namespace Queues
{
    internal class Program
    {

     
        static void Main(string[] args)
        {
            Queue<int> q1= new Queue<int>();    
            q1.Insert(1);
            q1.Insert(2);
            q1.Insert(3);
            q1.Insert(4);
            q1.Insert(5);
            Console.WriteLine(q1);
            QueueHelper.InsertToMid(q1, 10);
            Console.WriteLine(q1);
        }
    }
}