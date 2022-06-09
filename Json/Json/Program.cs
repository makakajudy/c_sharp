using Newtonsoft.Json;
using System;
using System.Collections.Generic;

public class Account
{
    public string Email { get; set; }
    public bool Active { get; set; }
    public DateTime CreatedDate { get; set; }
    public IList<string> Roles { get; set; }

}
class Program
    //serialise:convert an obj to json
{
    static void Main(string[] args)

    {// create an obj and add data to the properties
        Account account = new Account()
        {
            Email = "james@example.com",
            Active = true,
            CreatedDate = new DateTime(2013, 1, 20, 0, 0, 0, DateTimeKind.Utc),
            Roles = new List<string>
                    {
                        "User",
                        "Admin"
                    }
        };
         // from the Newtonsoft.Json package get JsonConvert that access serialisedObj()
         //thisfunc take 2args the obj beinf sealised and the format for the json output
        string json = JsonConvert.SerializeObject(account, Formatting.Indented);
        Console.WriteLine(json);

        //desealise: convert json to obj
                string json2 = @"{
          'Email': 'james@example.com',
          'Active': true,
          'CreatedDate': '2013-01-20T00:00:00Z',
          'Roles': [
            'User',
            'Admin'
          ]
        }";
        Account account2 = JsonConvert.DeserializeObject<Account>(json2);
        Console.WriteLine(account2.Email);








    }
}
