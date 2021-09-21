using ClassLibrary1.Extentions;
using ClassLibrary1.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary1.LINQ;

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

            //IEnumerable<int> sample = new List<int>() { 1,2,3,4};
            //sample.Max();
            //List<string> list = new List<string>();
            //IActivity activity = new WebService();
            //String a = "asd";
            //Console.WriteLine(a.Run());

            //var peripherals = new Peripherals().GetAllMouse();
            ////var cheaper = new List<ClassLibrary1.LINQ.Mouse>();
            ////foreach (var item in peripherals)
            ////{
            ////    if (item.Price < 500)
            ////        cheaper.Add(item);
            ////}
            //// LINQ Extention methods
            //var cheaper = peripherals
            //    .Where(p => p.Price < 500)
            //    .OrderBy(p => p.Brand)
            //    .Select(p => p.Brand);
            //// LINQ Query Operator
            //var cheapMouse = from p in peripherals
            //                 where p.Price < 500
            //                 orderby p.Brand
            //                 select p.Brand;
            ////foreach (var item in cheaper)
            ////{
            ////    Console.WriteLine(item);
            ////}
            ////foreach (var item in cheapMouse)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //var total = peripherals.Sum(p => p.Price);
            //var printThis = peripherals.Where(p => p.Brand == "ASUS");
            //Console.WriteLine(total);
            //var average = peripherals.Average((p) => p.Price);
            //Console.WriteLine(average);

            //Nullable<DateTime> dateTime = new DateTime(2000, 11, 12);
            DateTime? dateTime = new DateTime(2000, 11, 12);
            Console.WriteLine(dateTime.HasValue);
            Console.WriteLine(dateTime ?? DateTime.Now);
            //if (dateTime == null)
            //{
            //    dateTime = DateTime.Now;
            //    Console.WriteLine(dateTime);
            //}
            //else
            //{
            //    Console.WriteLine(dateTime.GetValueOrDefault());
            //}
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

