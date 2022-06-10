
using System;
using System.Collections.Generic;
using System.Text.Json;


namespace DeserializeExtra
{
    public class Rootobject
    {
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public string[] Roles { get; set; }
    }


    public class Program
    {
        public static void Main(string[] args)
        {

                        string json = @"{
              'Email': 'james@example.com',
              'Active': true,
              'CreatedDate': '2013-01-20T00:00:00Z',
              'Roles': [
                'User',
                'Admin'
              ]
            }";


            Rootobject obj = JsonSerializer.Deserialize<Rootobject>(json);
            Console.WriteLine(obj.Email);   

        }
        


    }









}