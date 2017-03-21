namespace _03.A_Miner_Task
{
    using System;
    using System.Collections.Generic;

    public class MinerTask
    {
        //// You are given a sequence of strings, each on a new line. Every odd line on the console 
        //// is representing a resource (e.g.Gold, Silver, Copper, and so on), and every even – quantity.
        //// Your task is to collect the resources and print them each on a new line.

        //// Print the resources and their quantities in format:
        //// {resource} –> {quantity}
        //// The quantities inputs will be in the range[1 … 2 000 000 000]
        
        public static void Main()
        {
            var resources = new Dictionary<string, decimal>();

            var inputLine = Console.ReadLine();

            while (inputLine != "stop")
            {
                var resource = inputLine;   
                var quantity = decimal.Parse(Console.ReadLine());
                //// The "quantity" variable is to keep the different values in case if some of the 
                //// resources repeat more than once. Take a look at the description bellow!       

                if (!resources.ContainsKey(resource))                   
                {                                                       
                    resources[resource] = 0;                            
                }                                                       
                                                                           
                //// The following code sums the different values          
                //// of the equal resources, which repeat more than once.  
                resources[resource] += quantity;

                inputLine = Console.ReadLine();
            }

            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}