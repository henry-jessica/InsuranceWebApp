using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InsuranceWebApp
{

    public partial class InsuranceForm : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            CalcPremium(int.Parse(txbAge.Text), tbxLocation.Text);

            lblResult.Text = (CalcPremium(int.Parse(txbAge.Text), tbxLocation.Text)).ToString();


        }
        public double CalcPremium(int age, string location)
        {
            double premium;

            if (location == "rural")
                if ((age >= 18) && (age <= 30))
                    premium = 5.0;
                else
                    if (age >= 31)
                    premium = 2.50;
                else
                    premium = 0.0;
            else
    if (location == "urban")
                if ((age >= 18) && (age <= 35))
                    premium = 6.0;
                else
                   if (age >= 36)
                    premium = 5.0;
                else
                    premium = 0.0;
            else
                premium = 0.0;

            if (age >= 50)
                premium = premium * 0.15;
            return premium;

        }
    }
}