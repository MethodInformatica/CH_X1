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
using System.Collections.Generic;
using PH_BSS;

public partial class modulo_conjuntoHabitacional_Listado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.cargarConjuntos();
        }
        else
        {

        }
    }
    private void cargarConjuntos() {
        List<ConjuntoHabitacional_ENT> conjuntos = new ConjuntoHabitacional_BSS().listConjuntoHabitacional();
        int i = 1;
        foreach (ConjuntoHabitacional_ENT conjunto in conjuntos)
        {
            HtmlTableRow row = new HtmlTableRow();
            row.Cells.Add(new HtmlTableCell() { InnerHtml = i.ToString() });
            row.Cells.Add(new HtmlTableCell() { InnerHtml = "<a href='#' style='text-decoration:underline'>"+conjunto.CodigoConjunto+"</a>" });
            row.Cells.Add(new HtmlTableCell() { InnerHtml = conjunto.NombreConjunto });
            row.Cells.Add(new HtmlTableCell() { InnerHtml = conjunto.NombreComunaConjunto });
            row.Cells.Add(new HtmlTableCell()
            {
                InnerHtml = "<button class='btn btn-mini btn-primary' type='button' onclick=\"JAVASCRIPT:ingresarCJ(" + conjunto.CodigoConjunto + ",'"+new Utilidad().getMD5(conjunto.CodigoConjunto,DateTime.Now.ToShortDateString())+"');\">Ingresar</button> " +
                    "<button class='btn btn-mini btn-danger' type='button' onclick=\"JAVASCRIPT:confirmarEliminarCJ(" + conjunto.CodigoConjunto + ");\">Eliminar</button>"
            });
            i++;
            tableConjuntos.Rows.Add(row);
        }
    }

    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/modulo/conjuntoHabitacional/Agregar.aspx");
    }
}
