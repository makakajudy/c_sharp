// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Linq;

namespace Practise_csharp{

    public class Product_details
    { //properties
    public string Caterory { get; set; }
    public string Price { get; set; }

    public bool Stocked { get; set; }
    public string Name { get; set; }
        
        public void my_method()
        {
            Console.WriteLine($"My products category =  {Caterory}" +
                $"product price={Price}" +
                $"product stocked={Stocked}" +
                $"product name{Name}");
        }                    
        

    }
    public class MyClass { 
        public int Id { get; set; }    
        public  string Subject { get; set; }
        public String Name { get; set; }
    
    }   

    class Program
    {
        static void Main(string[] args)

         {
            var dict = new Dictionary<string, List<Product_details>>();


            //product_detail class obj
           // Product_details product_obj=new Product_details();
           //my list name Product_list
            List<Product_details> Product_list = new List<Product_details>() {
                new Product_details{Caterory= "Fruits", Price= "$1", Stocked= true, Name= "Apple" },
                new Product_details{Caterory= "Fruits", Price= "$1", Stocked= true, Name= "Dragonfruit" },
                new Product_details{Caterory= "Fruits", Price= "$2", Stocked= false, Name= "Passionfruit" },
                new Product_details{Caterory= "Vegetables", Price= "$2", Stocked= true, Name= "Spinach" },
                new Product_details{Caterory= "Vegetables", Price= "$4", Stocked= false, Name= "Pumpkin" },
                new Product_details{Caterory= "Vegetables", Price= "$1", Stocked= true, Name= "Peas" },
             };
            for (var item = 0; item < Product_list.Count; item++)
            {
               /* Console.WriteLine($"category :  {Product_list[item].Caterory } " +
               $"product price : {Product_list[item].Price} " +
               $"product stocked : {Product_list[item].Stocked} " +
               $"product name : {Product_list[item].Name} ");*/
            }
            Console.WriteLine(" ");
            //
            var category_names = Product_list.GroupBy(x => x.Caterory);//.Select(user => user.Key);
            foreach (var name in category_names)
            { 
                Console.WriteLine(name.Key);
                foreach (var item in name)
                {
                    Console.WriteLine($"{item.Name}  {item.Price} {item.Stocked}");

                }
                Console.WriteLine(" ");


            }
            MyClass obj=new MyClass();//not necessary
            List<MyClass> mylist = new List<MyClass> {
           new MyClass(){Id = 208, Subject = "some text",Name= "Apple" },
           new MyClass(){Id = 209, Subject = "another text",Name= "juice" },
           new MyClass(){Id = 210, Subject = "one text",Name= "orange" },
           new MyClass(){Id = 211, Subject = "text mix",Name= "lemon" },
          // new MyClass(){Id = 211, Subject = "text mix",Name= "Apple" }
            };

            Dictionary<int, MyClass> dicts = mylist.ToDictionary(obj => obj.Id,obj=>obj);
            foreach ((var k,var v) in dicts)
            {
                Console.WriteLine(k);
                Console.WriteLine($"{v.Subject} {v.Name} ");
            }



            //var res = Product_list.Distinct().ToDictionary(x => x.Caterory,x=>x.Caterory);
            /*foreach ((var k,var v) in res)
            {
                Console.WriteLine($" Category :{k}{v.SelectMany()} ");//{res.Values}
                
                //Console.WriteLine($"{v} {v.Price} {v.Stocked}");
                Console.WriteLine(" ");

            }*/














        }

    }
}