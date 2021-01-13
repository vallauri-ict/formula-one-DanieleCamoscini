using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using FormulaOneDLL;
using System.Web.UI.WebControls;

namespace formulaOneWeb
{
    public partial class Default : System.Web.UI.Page
    {
        DBtools myTools = new DBtools();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Inizializzazioni, viene eseguita la prima volta che la pagina viene caricata
            if (!Page.IsPostBack)
            {
                GridView1.DataSource = myTools.getTable("Country");
                GridView1.DataBind();
                DropDownList1.DataSource = myTools.getTableName();
                DropDownList1.DataBind();
            }
            // Elaborazioni, eseguite ogni volta che la pagina viene ricaricata
            else
            {
            }
        }
        protected void selectionChanged(object sender, EventArgs e)
        {
           GridView1.DataSource= myTools.getTable(DropDownList1.SelectedValue);
           GridView1.DataBind();

        }
    }
}