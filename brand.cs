using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mashinconsoletask
{
    class Brand
    {
        public readonly int Id;
        private static int Count;
        public string Name { get; set; }
        private Model[] Models;
        public Brand()
        {
            Count++;
            Id = Count;
            Models = new Model[0];
        }

        public void AddModel(Model model)
        {
            Array.Resize(ref Models, Models.Length + 1);
            Models[Models.Length - 1] = model;
        }
        public override string ToString()
        {
             return $"{Id} {Name}";
        }
        public void ModelList()
        {
            foreach (Model model in Models)
            {
                Console.WriteLine(model);
            }
        }
        public void IsExist(string Name, string Color, int Year)
        {
            foreach (Model item in Models)
            {
                if (Name == item.Name && Color == item.Color && Year == item.Year)
                {
                    if (item.Count != 0)
                    { Console.WriteLine("Mehsul eldedir"); }

                    else
                    {
                        Console.WriteLine("elde yoxdur");
                    }
                }
            }
        }
            
        


        public void SaleModel(string Name, double price, string color, int count, int Year )
        {
            Model model = new Model();

            foreach (Model item in Models)
            {
                if (item.Name == Name&& item.Color==color && item.Year==Year)
                {
                    model = item;
                    break;
                }
            }

            if (model != null)
            {
                if (model.Count >= count)
                {
                    if ((count * model.Price) <= price)
                    {
                        model.Count -= count;
                        Console.WriteLine($"Satish ugurlu oldu ");
                    }
                    else
                    {
                        Console.WriteLine($"Mebleg Kifayet Etmedi.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine($"Isdediyniz qeder model yoxdur. ");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Isdediyniz model yoxdur");
                return;
            }
        }


            
    }

}

