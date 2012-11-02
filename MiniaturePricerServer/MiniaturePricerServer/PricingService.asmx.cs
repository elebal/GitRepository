using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MiniaturePricerServer
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PricingService : System.Web.Services.WebService
    {

        [WebMethod]
        public decimal CalculateFutureContract(decimal currentPrice, short dayInYear)
        {
            double interestRate = getInterestRate(dayInYear);

            decimal futureContract = Math.Round(Convert.ToDecimal(currentPrice * (decimal)Math.Pow(Math.E, (dayInYear * (interestRate / 365)))), 2);
            return futureContract;
        }

        [WebMethod]
        public List<decimal> CalculateFutureContractList(List<decimal> currentPriceList, short dayInYear)
        {
            double interestRate = getInterestRate(dayInYear);

            List<decimal> returnList = new List<decimal>();
            foreach (decimal currentPrice in currentPriceList)
            {
                decimal futureContract = Convert.ToDecimal(currentPrice * (decimal)Math.Pow(Math.E, (dayInYear * (interestRate / 365))));
                returnList.Add(futureContract);
            }
            return returnList;
        }

        private double getInterestRate(short dayInYear)
        {
            double[] daysArray = new double[5] { 1, 30, 60, 90, 210 };
            double[] IntrstArray = new double[5] { 0.1, 0.05, 0.04, 0.02, 0.02 };
            double ineterestRate = Interpolation.lagrange((double)dayInYear, daysArray, IntrstArray);
            return ineterestRate;
        }

    }
}