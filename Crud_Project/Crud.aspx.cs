using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Crud_Project
{
    public partial class Crud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            
        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            SqlDataSource1.InsertParameters["Name"].DefaultValue =
            ((TextBox)GridView1.FooterRow.FindControl("name")).Text;

            SqlDataSource1.InsertParameters["Gender"].DefaultValue =
            ((DropDownList)GridView1.FooterRow.FindControl("gender")).SelectedValue;

            SqlDataSource1.InsertParameters["Class"].DefaultValue =
            ((TextBox)GridView1.FooterRow.FindControl("class")).Text;

            SqlDataSource1.Insert();
        }
    }
}