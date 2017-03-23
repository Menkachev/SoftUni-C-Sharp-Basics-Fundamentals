namespace Extended___LambdaAndLINQ___More_Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LambadaExpressions
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> lambadaExpressions = new Dictionary<string, Dictionary<string, string>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "lambada")
            {
                string[] inputParams = inputLine
                    .Split(new[] { ' ', '=', '>', '.' }, StringSplitOptions.RemoveEmptyEntries);

                if (inputParams.Length > 1) // The length > 1, because 'dance' will be read as a single char.
                {
                    string selector = inputParams[0];
                    string selectorObject = inputParams[1];
                    string property = inputParams[2];

                    if (!lambadaExpressions.ContainsKey(selector))
                    {
                        lambadaExpressions.Add(selector, new Dictionary<string, string>());
                    }

                    lambadaExpressions[selector][selectorObject] = property;
                }
                else // If we have "dance".
                {
                    lambadaExpressions = lambadaExpressions // Will change the expressions
                        .ToDictionary(selector => selector.Key, selector => selector.Value // For each Key, takes key's key & value.
                        .ToDictionary(selectorObject => selectorObject.Key, // Change the value -> takes value's key...
                        selectorObject => selectorObject.Key + "." + selectorObject.Value)); // and for value's value concatenate 
                    //                                                                          value's key + "." + value's value.
                }

                    inputLine = Console.ReadLine();
                }

            lambadaExpressions
                .ToList()
                .ForEach(selector => selector.Value
                .ToList()
                .ForEach(selectorObject => Console.WriteLine(
                    "{0} => {1}.{2}",
                selector.Key,
                selectorObject.Key,
                selectorObject.Value)));
            }
        }
    }