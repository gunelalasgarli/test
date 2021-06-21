using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mashinconsoletask
{
    class Program
    {
        static void Main(string[] args)
        {

            Model model1 = new Model { Name = "f10", Price = 35000, Color = "green", Year = 2010, Count = 5 };
            Model model2 = new Model { Name = "x5", Price = 30000, Color = "black", Year = 2011, Count = 3 };
            Model model3 = new Model { Name = "x6", Price = 33000, Color = "white", Year = 2009, Count = 4 };

            Brand brand = new Brand();
            brand.Name = "Bmw";
            brand.AddModel(model1);
            brand.AddModel(model2);
            brand.AddModel(model3);

            brand.ModelList();

            brand.IsExist("x5", "black", 2011);

            brand.SaleModel("x5", 30000, "black", 1, 2011);

            brand.ModelList();


            //Console.WriteLine(model1);
            //Console.WriteLine(model2);
            //Console.WriteLine(model3);
        }
    }
}
