using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameworkTest
{
    public partial class UpdateContact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                if (Request.QueryString["id"] == null)
                {
                    Response.Redirect("default.aspx");
                }

                int idToupdate = Convert.ToInt32(Request.QueryString["id"].ToString());
                ContactsDb db = new ContactsDb();
                Contact con = db.Contacts.SingleOrDefault(p => p.id == idToupdate);

                Label1.Text = con.id.ToString();
                Label2.Text = con.fname;
                Label3.Text = con.lname;

                TextBox1.Text = con.phone;
                Session["updatingContact"] = con;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int idToupdate = Convert.ToInt32(Request.QueryString["id"].ToString());
           ContactsDb db = new ContactsDb();
           Contact con = db.Contacts.SingleOrDefault(p =>  p.id == idToupdate);

           con.phone = TextBox1.Text;
           db.SaveChanges();

           Label4.Text = "Contact updated Successfully";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            {
                //delete this contact
                int idToupdate = Convert.ToInt32(Request.QueryString["id"].ToString());
                ContactsDb db = new ContactsDb();
                Contact con = db.Contacts.SingleOrDefault(p => p.id == idToupdate);

                db.Contacts.DeleteObject(con);
                db.SaveChanges();
                Response.Redirect("default.aspx");
            }
            return;
        }
    }
}