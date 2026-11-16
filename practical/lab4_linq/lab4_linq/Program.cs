using System;
using System.Collections.Generic;
using System.Linq;

class Voter
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
}

class Program
{
    static void Main()
    {
        List<Voter> voters = new List<Voter>
        {
            new Voter { Name = "Samir", Age = 17,
                Address = "Patan" },

            new Voter { Name = "Sishir", Age = 22,
                Address = "Balaju" },

            new Voter { Name = "Hari", Age = 15,
                Address = "Kathmandu" },

            new Voter { Name = "Saman", Age = 20,
                Address = "Patan" },

            new Voter { Name = "Rashmi", Age = 20,
                Address = "Patan" },

            new Voter { Name = "Sushma", Age = 20,
                Address = "Bhaktapur" }
        };

        var result = from v in voters
                     where v.Age > 18 &&
                           v.Address == "Patan"
                     select v.Name;

        Console.WriteLine(
            "Eligible Voters Living in Patan:");

        foreach (var name in result)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("\n\tBy Suman Pun Magar");
    }
}