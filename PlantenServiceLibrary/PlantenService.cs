using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantenServiceLibrary
{
    public class PlantenService : IPlantenService
    {
        private static List<Plant> planten = new List<Plant>(){
            new Plant{Nummer=1,Naam="Azalea",Prijs=4.95M},
            new Plant{Nummer=2,Naam="Vlinderstruik",Prijs=5M},
            new Plant{Nummer=3,Naam="Hortensia",Prijs=4M}
        };

        public List<Plant> GetPlantenVanTotPrijs(decimal minPrijs, decimal maxPrijs)
        {
            return (from plant in planten
                    where plant.Prijs >= minPrijs && plant.Prijs <= maxPrijs
                    select plant).ToList();
        }

        public List<Plant> GetPlantenMetWoord(string woord)
        {
            return (from plant in planten
                    where plant.Naam.Contains(woord)
                    select plant).ToList();
        }
    }
}
