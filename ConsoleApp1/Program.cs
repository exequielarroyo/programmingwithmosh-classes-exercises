using ClassLibrary1.Extentions;
using ClassLibrary1.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int> sample = number => number * 2;
            //Console.WriteLine(sample(100));
            //var c = sample(100);
            //Action<int, int> sample2 = NewFunc2;
            //sample2 += (a, b) => { Console.WriteLine(a + b + c); };
            //sample2(1, 2);
            //MyClass.Func<int, string> func = () => { Console.WriteLine("hello"); };
            //func += NewFunc<int, string>;
            //func();

            //var click = new Click();
            //var button = new Button();
            //var mouse = new Mouse();
            //click.ClickedEvents += mouse.MouseClicked;
            //click.ClickedEvents += button.ButtonClicked;
            //click.Clicked("admin123");

            IEnumerable<int> sample = new List<int>();
            sample.Max();
            List<string> list = new List<string>();
            IActivity activity = new WebService();
            String a = "asd";
            Console.WriteLine(a.Run());

            Console.ReadLine();

        }


        public static void NewFunc2(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void NewFunc<T, a>()
        {
            Console.WriteLine("hi");
        }

        // generic delegates
        public class MyClass
        {
            public delegate void Func<T, U>();
        }
    }
}

