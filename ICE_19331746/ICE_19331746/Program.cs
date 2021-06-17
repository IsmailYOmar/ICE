using System;
using System.Collections.Generic;

namespace ICE_19331746
{
    class Program
    {
        static void Main(string[] args)
        {
            try //choose between 1 and 2 
            {
                Console.WriteLine("Enter 1 to create a Fibonacci sequence or 2 to check whether a list is even prone or not:");
                int ans = Convert.ToInt32(Console.ReadLine());

                if (ans.Equals(1))
                {
                    Fibonacci_Sequence();
                }
                else if (ans.Equals(2))
                {
                    List_Prone();
                }
                else
                {
                    Console.WriteLine("Please only enter 1 or 2");
                    Main(null);
                }
            }
            catch (System.Exception ex) //error checking 
            {
                Console.WriteLine(ex.Message);
                Main(null);
            }

            try // give user option to run program again
            {

                Console.WriteLine("\nWould you like to run the program again");
                Console.WriteLine("\t Enter 1 for yes");
                Console.WriteLine("\t Enter 2 for no");
                int ans = Convert.ToInt32(Console.ReadLine());

                if (ans.Equals(1))
                {
                    Main(null);
                }
                else if (ans.Equals(2))
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Please only enter 1 or 2");
                    Main(null);
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void List_Prone()
        {
            List<int> myList = new List<int>(); //create list
            try //ask user for values of the list
            {
                Console.WriteLine("Please enter the values of the list below :");

                Console.WriteLine("Please enter the first value of the list: ");
                myList.Add(Convert.ToInt32(Console.ReadLine()));
            }
            catch (System.Exception ex)//error checking
            {
                Console.WriteLine(ex.Message);
                List_Prone();
            }

            bool add = false;
            while (!add)
            {
                try //add more values to list 

                {
                    Console.WriteLine("\nWould you like to add another value to the list:");
                    Console.WriteLine("\t\t1. Yes");
                    Console.WriteLine("\t\t2. No");
                    int add_List = 0;
                    bool isSuccessful = false;
                    while (!isSuccessful)
                    {
                        try
                        {
                            Console.Write("Enter 1 or 2 to select an option : ");
                            add_List = Convert.ToInt32(Console.ReadLine());
                            isSuccessful = true;
                        }
                        catch (System.Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    if (add_List.Equals(1)) // if user enters 1 then
                    {
                        Console.WriteLine("Enter the next value of the list");
                        myList.Add(Convert.ToInt32(Console.ReadLine()));
                    }
                    else if (add_List.Equals(2)) // if user enters 2 then stop adding to list
                    {
                        add = true;
                    }
                }
                catch (System.Exception ex) // error checking 
                {
                    Console.WriteLine(ex.Message);
                }
            }
            if (ComputeEvenProne(myList).Equals(1)) //output
            {
                Console.WriteLine("\n{0}.The list is even prone", ComputeEvenProne(myList));
            }
            else
            {
                Console.WriteLine("\n{0}.The list is not even prone", ComputeEvenProne(myList));
            }

            
        }

        private static int  ComputeEvenProne(List<int> myList)
        {
            int even = 0, odd = 0; 
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            if(even>odd) //check if num of even is greater than odd
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        private static void Fibonacci_Sequence() //ask for number n
            {
                int n = 0;
                try
                {
                    Console.WriteLine("Enter any number that is greater than 1");
                    n = Convert.ToInt32(Console.ReadLine());
                    //added validate for negative values
                    while (n <= 1)
                    {
                        Console.WriteLine("ERROR! Amount can not be equal to 1 or less than 1.\nPlease enter amount again: ");
                        n = Convert.ToInt32(Console.ReadLine());
                    }
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Fibonacci_Sequence();
                }

                ComputeFibonacciSequence(n);
                Console.ReadLine();

            }
        public static void ComputeFibonacciSequence(int n) //output Fibonacci Sequence
        {
                int a = 0, b = 1, c = 0;
                Console.Write("{0} {1}", a, b);
                for (int i = 2; i < n; i++)
                {
                    c = a + b;
                    Console.Write(" {0}", c);
                    a = b;
                    b = c;
                }
            }
        }
    }


