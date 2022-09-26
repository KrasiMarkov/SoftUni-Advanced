using System;
using System.Linq;
using System.Collections.Generic;
namespace SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();

            HashSet<string> regularGuests = new HashSet<string>();

            while (true)
            {
                string person = Console.ReadLine();

                if (person == "PARTY")
                {
                    bool flag = false;

                    while (true)
                    {
                        string actuallyGuests = Console.ReadLine();

                        if (actuallyGuests == "END")
                        {
                            flag = true;

                            break;
                        }

                        bool check = vipGuests.Contains(actuallyGuests);

                        if (check == true)
                        {
                            vipGuests.Remove(actuallyGuests);
                        }

                        else
                        {
                            regularGuests.Remove(actuallyGuests);
                        }
                    }

                    if (flag == true)
                    {
                        break;
                    }
                }



                char symbol = person[0];

                if (char.IsDigit(symbol))
                {
                    vipGuests.Add(person);
                }

                else
                {
                    regularGuests.Add(person);
                }







            }

            int countVip = vipGuests.Count;

            int countRegular = regularGuests.Count;

            int total = countRegular + countVip;

            Console.WriteLine(total);

            if (vipGuests.Any())
            {
                foreach (var item in vipGuests)
                {
                    Console.WriteLine(item);
                }
            }

            if (regularGuests.Any())
            {
                foreach (var item in regularGuests)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
