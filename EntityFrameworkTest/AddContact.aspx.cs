using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameworkTest
{
    public partial class AddContact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == string.Empty ||
                TextBox2.Text == string.Empty ||
                TextBox3.Text == string.Empty)
            {
                Label1.Text = "Please enter proper details first";
                return;
            }

            Contact con = new Contact();
            con.fname = TextBox1.Text;
            con.lname = TextBox2.Text;
            con.phone = TextBox3.Text;

            ContactsDb db = new ContactsDb();
            db.Contacts.AddObject(con);
            if (db.SaveChanges() == 1)
            {
                Label1.Text = "Contact added Successfully";
            }
        }
    }
}