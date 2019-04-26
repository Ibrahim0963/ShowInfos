using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ShowInfos
{

    class Program
    {
        private string name;
        private int age;
        private string work;
        private string hobbys;


        public string Name
        {
            get{return name;}
            set{name = value;}
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Work
        {
            get { return work; }
            set { work = value; }
        }
        public string Hobbys
        {
            get { return hobbys; }
            set { hobbys = value; }
        }
        public void GetData()
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            AskAge:
            try
            {
                Console.Write("Enter your age: ");
                age = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\nError !!!!!!\nPlease enter just your age [Number] !!\n");
                goto AskAge;
            }

            Console.Write("Enter your work: ");
            work = Console.ReadLine();

            Console.Write("Enter your hobbys: ");
            hobbys = Console.ReadLine();
        }
        public void PrintData()
        {
            Console.Clear();
            Console.WriteLine("Loading Data...");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Your Infos : ");
            Console.WriteLine("\nYour name is : " + name);
            Console.WriteLine("Your age is : " + age);
            Console.WriteLine("Your work is : " + work);
            Console.WriteLine("Your hobbys is/are : " + hobbys);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\nShow Infos Data  :");
            Console.WriteLine("--------------------");
            Program p = new Program();
            p.GetData();
            p.PrintData();

            Console.ReadKey();
        }
    }
}
