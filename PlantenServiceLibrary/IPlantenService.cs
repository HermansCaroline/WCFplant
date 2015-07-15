using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PlantenServiceLibrary
{
    [ServiceContract(Namespace = "http://vdab.be/plantenservice")]
    public interface IPlantenService
    {
        [OperationContract]
        List<Plant> GetPlantenVanTotPrijs(decimal minPrijs, decimal maxPrijs);
        [OperationContract]
        List<Plant> GetPlantenMetWoord(string woord);
    }
}
