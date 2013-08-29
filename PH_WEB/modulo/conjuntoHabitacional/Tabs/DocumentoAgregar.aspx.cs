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

public partial class modulo_conjuntoHabitacional_Tabs_DocumentoAgregar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ConjuntoHabitacional_ENT conjunto = (ConjuntoHabitacional_ENT)Session["conjuntoHabitacionalSeleccionado"];
            this.cargarFormulario(conjunto);
        }
        else
        {
        }
    }
    private void cargarFormulario(ConjuntoHabitacional_ENT conjunto)
    {
        txtCodigoConjunto.Text = conjunto.CodigoConjunto;
        txtNombreConjunto.Text = conjunto.NombreConjunto;
        txtEtapa.Text = conjunto.Etapa;
    }
    protected void btn_grabar_docAsociada_Click(object sender, EventArgs e)
    {
        ClientScript.RegisterStartupScript(this.GetType(), "", "cargarContenido(2);");
    }
}
