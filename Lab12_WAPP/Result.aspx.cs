using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab12_WAPP
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            decimal a = Convert.ToDecimal(Request.QueryString["a"]);
            decimal b = Convert.ToDecimal(Request.QueryString["b"]);
            string o = Request.QueryString["o"];
            string op = "";
            ServiceReference1.Service1Client sluzba = new ServiceReference1.Service1Client();

            decimal response = sluzba.Spocti(a, b, o);

            if (a != null && b != null && o != null)
            {
                switch (o)
                {
                    case "plus":
                        op = "+";
                        break;
                    case "minus":
                        op = "-";
                        break;
                    case "mult":
                        op = "*";
                        break;
                    case "divide":
                        op = "/";
                        break;
                    default:
                        break;
                }

                Response.Write(String.Format("{0} {1} {2} = {3}", a, op, b, response));
            }
        }
    }
}