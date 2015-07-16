using ConsolePlantenClient.PlantenService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePlantenClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var plantenService = new PlantenServiceClient("httpPlanten"))
            {
                Console.Write("Prijs vanaf: ");
                var van = decimal.Parse(Console.ReadLine());
                Console.Write("Prijs tot: ");
                var tot = decimal.Parse(Console.ReadLine());
                foreach (var plant in plantenService.GetPlantenVanTotPrijs(van, tot))
                {
                    Console.WriteLine("{0}  {1} euro", plant.Naam.PadLeft(20), plant.Prijs);
                }
                Console.Write("bevat woord: ");
                var woord = Console.ReadLine();
                foreach (var plant in plantenService.GetPlantenMetWoord(woord))
                {
                    Console.WriteLine("{0}  {1} euro", plant.Naam.PadLeft(20), plant.Prijs);
                }
            }
        }
    }
}
