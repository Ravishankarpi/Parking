using parking_lot.Info;
using parking_lot.Exception;
using parking_lot.Functions;
using parking_lot.INOU;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace parking_lot
{
    public class Program
    {
        public static functions provider;


        static void Main(string[] args)
        {
            provider = new Parkinginfo();
            PrintInput.PrintWelcomeMessage();


            if (args.Length != 0)
            {
                //Input from a file

                string line;
       
                try
                {
                    System.IO.StreamReader file = new StreamReader(args[0]);
                    while ((line = file.ReadLine()) != null)
                    {
                        if (provider.Validate(line))
                        {
                            try
                            {
                                provider.Execute(line);
                            }
                            catch (ParkingException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                    }
                    file.Close();
                    Console.Read();
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                return;
            }
            else
            {
                //Input Arguments
                PrintInput.PrintCommands();
                while (true)
                {
                    try
                    {
                        var input = Console.ReadLine();
                        if (input.ToLower().Equals("exit"))
                        {
                            break;
                        }
                        else
                        {
                            if (provider.Validate(input))
                            {
                                try
                                {
                                    provider.Execute(input);
                                }
                                catch (ParkingException e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }
                            else
                            {
                                PrintInput.PrintCommands();
                            }
                        }

                    }
                    catch (System.Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                }
            }
        }




    }
}
