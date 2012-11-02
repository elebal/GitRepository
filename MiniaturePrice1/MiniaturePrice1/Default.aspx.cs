using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace MiniaturePrice1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {

            PricingService.PricingService service = new PricingService.PricingService();

            lblFutureContract.Text ="The Future contract is: "+
                service.CalculateFutureContract(decimal.Parse(txtCurrentPrice.Text), short.Parse(txtDays.Text)).ToString() + " $";
        }

       
    }
}
