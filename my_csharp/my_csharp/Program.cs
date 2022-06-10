// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;

namespace Reactdata {

    class MyClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }


    }
    class Product_details
    {

        public string Category { get; set; }
        public string Price { get; set; }
        public bool Stocked { get; set; } 
        public string Name { get; set; }

    }


    class Program {


        static void Main(string[] args) {
            List<MyClass> mylist = new List<MyClass> {
           new MyClass(){Id = 208, Subject = "some text",Name= "Apple" },
           new MyClass(){Id = 209, Subject = "another text",Name= "juice" },
           new MyClass(){Id = 210, Subject = "one text",Name= "orange" },
           new MyClass(){Id = 211, Subject = "text mix",Name= "lemon" },
           new MyClass(){Id = 211, Subject = "text mix",Name= "Apple" }
            };

            //
            mylist.Add(new MyClass() { Id = 212, Subject = "text mix", Name = "Apple" });
            mylist.Add(new MyClass() { Id = 208, Subject = "text mix", Name = "Apple" });


            List<Product_details> Product_list = new List<Product_details>() {
                new Product_details{Category= "Fruits", Price= "$1", Stocked= true, Name= "Apple" },
                new Product_details{Category= "Fruits", Price= "$1", Stocked= true, Name= "Dragonfruit" },
                new Product_details{Category= "Fruits", Price= "$2", Stocked= false, Name= "Passionfruit" },
                new Product_details{Category= "Vegetables", Price= "$2", Stocked= true, Name= "Spinach" },
                new Product_details{Category= "Vegetables", Price= "$4", Stocked= false, Name= "Pumpkin" },
                new Product_details{Category= "Vegetables", Price= "$1", Stocked= true, Name= "Peas" },
            };
            Product_list.Add(new Product_details
            {
                Category = "Meat",
                Price = "$1",
                Stocked = true,
                Name = "Chicken"
            });

            foreach (MyClass item in mylist) {
               // Console.WriteLine($"{item.Id}");
               //Console.WriteLine($" {item.Name} {item.Subject}");


            }

            //Dictionary<string,List<MyClass>> mydict = new Dictionary<string,List<MyClass>>();

            var mydict = mylist.GroupBy(x => x.Id);// ToDictionary(x => x.Key, x => x);
            var mydict2 = mydict.ToDictionary(x=>x.Key);

            foreach (var item in mydict2)
            {
                Console.WriteLine(item.Key);

                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"{item2.Subject} {item2.Name}");
                  
                } Console.WriteLine(" ");

            }
            var groupBy_category = Product_list.GroupBy(x => x.Category);// ToDictionary(x => x.Key, x => x);
            var Product_dict = groupBy_category.ToDictionary(x => x.Key);

            foreach (var item in Product_dict)
            {
                Console.WriteLine($"Categories {item.Key}");

                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"{item2.Name} {item2.Price}");

                }
                Console.WriteLine(" ");

            }









        }



        }


}

