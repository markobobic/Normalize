using System;
using System.Collections.Generic;
using Normalization.ExtensionMethods;
using Normalization.Utilis;

namespace Normalization
{
    class Program
    {
        // Amount of check:              D0 666 43
        //Tax ID #                       1009,5r
        //PTAN                           303866A
        //Medicare Number                l19z20l43OG
        //Medicare Claim Number          333-560-112 6C
        //Claim Amount Refunded $        t00, 00
        //PTAN                           303866A
        static void Main(string[] args)
        {
            Console.WriteLine("----------Before----------:");
            ErrorsInExtraction.ErrorsList.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("----------After----------:"); 
            ErrorsInExtraction.ErrorsList.ForEach(x => Console.WriteLine(x.ToNumberString()));
            Console.ReadLine();

        }
    }
}
