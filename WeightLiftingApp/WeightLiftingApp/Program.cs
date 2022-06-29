namespace WeightLiftingApp
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static double _Value = 0, Total = 0;
        public static void Main(string[] args)
        {
           
            Console.Write("Enter a value: ");
            double valueUser = Convert.ToDouble(Console.ReadLine());
            double[] plates = { 45, 35, 25, 10, 5, 2.5 };
            try
            {
                while (valueUser >= 5)
                {
                    _Value = valueUser;
                    Dictionary<double, int> resultPlates = new Dictionary<double, int>();
                    
                    foreach (double plateValue in plates)
                    {
                        resultPlates.Add( plateValue, calculatePlates(_Value, plateValue) );
                    }
                    foreach (KeyValuePair<double, int> result in resultPlates)
                    {
                        Console.WriteLine("Weight Plates Results:\n {0} lbs, plates: {1}\n", result.Key, result.Value);
                    }
                    Console.WriteLine($"Total Weight to Lift:{Total}.\n");
                    Total = 0;
                    Console.Write("Enter a value: ");
                    valueUser = Convert.ToDouble(Console.ReadLine());
                }
                if (valueUser <= 0)
                    Console.WriteLine("Thanks you for use the WeightLifting App service. :)");
                else
                {
                    Console.WriteLine("You can't lift less than 5lbs because we don't have weight plates under 2.5lbs. You should eat more and take protein bro... ;)");
                }
                Console.WriteLine("Press ENTER to exit...");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"the following exception occurred:{ex.Message}");
                Console.WriteLine("Press ENTER to exit...");
                Console.ReadLine();
            }
         
        }

      
        public static int calculatePlates(double valueUser, double num)
        {
            int plates = 0;
            valueUser = valueUser / num;
            if (valueUser >= 2)
            {
                plates = (int)valueUser % 2 == 0 ? (int)valueUser : (int)valueUser - 1;
                Total = Total + num * plates;
                _Value = _Value - plates * num;
            }

            return plates;
        }
        
       
    }
    
}
