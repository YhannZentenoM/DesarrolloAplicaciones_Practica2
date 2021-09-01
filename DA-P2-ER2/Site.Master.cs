using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DA_P2_ER2
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                Artefactos.Items.Add(new ListItem("Microondas", "1"));
                Artefactos.Items.Add(new ListItem("Refrigeradora", "2"));
                Artefactos.Items.Add(new ListItem("Cocina", "3"));
                Artefactos.Items.Add(new ListItem("Horno", "4"));
            }
        }
    }
}