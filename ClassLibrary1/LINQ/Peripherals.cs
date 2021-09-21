using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.LINQ
{
    public class Peripherals
    {
        public List<Mouse> GetAllMouse()
        {
            return new List<Mouse> {
                new Mouse() { Brand = "AOC", Model = "MD123" , Price = 149},
                new Mouse() { Brand = "ROG", Model = "RGB38" , Price = 899.50m},
                new Mouse() { Brand = "MSI", Model = "Max" , Price = 499.99m},
                new Mouse() { Brand = "ASUS", Model = "MS390" , Price = 1259.89m},
                new Mouse() { Brand = "Acer", Model = "KI8F3", Price = 399.90m}
            };
        }
    }
}
