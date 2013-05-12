using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameworkTest
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ContactsDb db = new ContactsDb();
            Repeater1.DataSource = db.Contacts;
            Repeater1.DataBind();
        }       
    }
}
