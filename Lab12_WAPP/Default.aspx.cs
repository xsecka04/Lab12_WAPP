using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab12_WAPP
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            Response.Redirect(String.Format("Result.aspx?a={0}&b={1}&o={2}", Operand1.Text, Operand2.Text, Operator.Text));
        }
    }
}