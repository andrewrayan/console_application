using consoleappliation.Fasade.BusinessLogic;
using consoleappliation.Fasade.Skeleton;
using consoleappliation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleappliation
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqTutorials linqTutorial = new LinqTutorials();
            Practise practise = new Practise();
            string result = practise.Triangle(5);
            Console.WriteLine(result);
            //var studentsList = linqTutorial.GetStudents();
            //var standardList = linqTutorial.GetStandards();

            //var joinList = studentsList.Join(standardList,
            //                                 student => student.StandardID,
            //                                 standard => standard.StandardID,
            //                                 (student, standard) => new
            //                                 {
            //                                     standard = standard.StandardName,
            //                                     studentName = student.StudentName
            //                                 });
            //foreach(var item in joinList)
            //{
            //    Console.WriteLine("Name:{0} Standard:{1}", item.studentName, item.standard);
            //}

            //IList<string> strList = new List<String>() { "One", "Two", "Three", "Four", "Five" };
            //var stringResponse = strList.Aggregate((s1,s2)=>s1+","+s2);
            //Console.WriteLine(stringResponse);

            //Singleton singleton = new Singleton();
            //singleton.Print("This is example of singleton");

            IPurchaseItem purchaseItem = new PurchaseItem(new Order(), new Cart());
            purchaseItem.AddToCart(1);
            purchaseItem.PlaceOrder(1);
            Console.Read();
        }
        static void Print(string value)
        {
            Console.WriteLine(value);
        }
    }

    public class Node
    {
        public string data { get; set; }
        public Node next { get; set; }
    }

    class LinkedListClass
    {
        public Node head { get; set; }

        public void AddNode(string data)
        {
            if (head == null)
            {
                head = new Node();
                head.data = data;
                head.next = new Node();
            }
            else
            {
                Node newNode = new Node();
                newNode.data = data;
                newNode.next = new Node();
                Node node = head;
                while (node.next.data != null)
                {
                    node = node.next;
                }
                node.next = newNode;
            }
        }

        public void RemoveNode(string data)
        {
            var node = head;
            var previousNode = new Node();
            while (node.next != null && node.data != data)
            {
                previousNode = node;
                node = node.next;
            }
            if (node.next == null)
            {
                return;
            }
            previousNode.next = node.next;
        }

        public int GetSize()
        {
            int count = 0;
            if (head == null)
            {
                return count;
            }
            else
            {
                Node node = head;
                while (node.next != null)
                {
                    node = node.next;
                    count++;
                }
                return count;
            }
        }
    }
}
