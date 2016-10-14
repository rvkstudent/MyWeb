using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ВебФормы
{
    public partial class Sumary : System.Web.UI.Page
    {
        public void GreetingBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("myweb.aspx");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Click += new EventHandler(this.GreetingBtn_Click);
        }

      
    }
}