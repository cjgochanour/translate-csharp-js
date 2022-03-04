using System;
using System.Collections.Generic;

namespace dinner_party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Guest> Guests = new List<Guest>()
            {
                new Guest()
                {
                    Name = "Marilyn Monroe",
                    Occupation = "entertainer",
                    Bio =  "(1926 - 1962) American actress, singer, model"
                },
                new Guest()
                {
                    Name = "Abraham Lincoln",
                    Occupation = "politician",
                    Bio = "(1809 - 1865) US President during American civil war"
                },
                new Guest()
                {
                    Name = "Martin Luther King",
                    Occupation = "activist",
                    Bio = "(1929 - 1968)  American civil rights campaigner"
                },
                new Guest()
                {
                    Name = "Rosa Parks",
                    Occupation = "activist",
                    Bio = "(1913 - 2005)  American civil rights activist"
                },
                new Guest()
                {
                    Name = "Peter Sellers",
                    Occupation = "entertainer",
                    Bio = "(1925 - 1980) British actor and comedian"
                },
                new Guest()
                {
                    Name = "Alan Turing",
                    Occupation = "computer scientist",
                    Bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
                },
                new Guest()
                {
                    Name = "Admiral Grace Hopper",
                    Occupation = "computer scientist",
                    Bio = "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
                },
                new Guest()
                {
                    Name = "Indira Gandhi",
                    Occupation = "politician",
                    Bio = "(1917 - 1984) Prime Minister of India 1966 - 1977",
                }
            };

            Dictionary<string, List<Guest>> Tables = new Dictionary<string, List<Guest>>()
            {
                {"Table 1", new List<Guest>()},
                {"Table 2", new List<Guest>()}
            };

            foreach (Guest eachGuest in Guests)
            {
                List<string> Table1Occupations = new List<string>();
                foreach (Guest g in Tables["Table 1"])
                {
                    Table1Occupations.Add(g.Occupation);
                };
                if (Table1Occupations.Contains(eachGuest.Occupation))
                {
                    Tables["Table 2"].Add(eachGuest);
                }
                else
                {
                    Tables["Table 1"].Add(eachGuest);
                }
            }

            foreach (KeyValuePair<string, List<Guest>> eachTable in Tables)
            {
                Console.WriteLine($"{eachTable.Key}");
                foreach (Guest eachGuest in eachTable.Value)
                {
                    Console.WriteLine($"{eachGuest.Name} ({eachGuest.Occupation}) ({eachGuest.Bio})");
                }
            }
        }
    }
}
