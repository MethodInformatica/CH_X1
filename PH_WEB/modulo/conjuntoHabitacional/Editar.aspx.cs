using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using PH_ENT;
using PH_BSS;

public partial class modulo_conjuntoHabitacional_Editar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                string idConjunto = Request.QueryString["id"].ToString();
                if (!string.IsNullOrEmpty(idConjunto))
                {
                    ConjuntoHabitacional_ENT conjunto = new ConjuntoHabitacional_BSS().getConjuntoHabitacionalID(
                        new ConjuntoHabitacional_ENT() { IdConjuntoHabitacional = Convert.ToInt32(idConjunto) });
                    Session["conjuntoHabitacionalSeleccionado"] = conjunto;
                    string key = Request.QueryString["key"].ToString();
                }
                else
                {
                    Response.Redirect("~/modulo/conjuntoHabitacional/Listado.aspx");
                }
            }
            catch (Exception ex)
            {
                Response.Redirect("~/modulo/conjuntoHabitacional/Listado.aspx");
            }
        }
        else
        {

        }
    }
}
