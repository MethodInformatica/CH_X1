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

public partial class modulo_conjuntoHabitacional_Tabs_DocumentoListado : System.Web.UI.Page
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
        List<Documento_ENT> documentos = new Documento_BSS().listAllByIdConjunto(conjunto.IdConjuntoHabitacional);
        int i = 1;
        foreach (Documento_ENT documento in documentos)
        {
            HtmlTableRow row = new HtmlTableRow();
            row.Cells.Add(new HtmlTableCell() { InnerHtml = i.ToString() });
            row.Cells.Add(new HtmlTableCell() { InnerHtml = documento.Folio.ToString() });
            row.Cells.Add(new HtmlTableCell() { InnerHtml = documento.Nombre });
            row.Cells.Add(new HtmlTableCell() { InnerHtml = documento.FechaDocumento.ToShortDateString() });
            row.Cells.Add(new HtmlTableCell() { InnerHtml = documento.FechaVencimiento.ToShortDateString() });
            row.Cells.Add(new HtmlTableCell()
            {
                InnerHtml = "<button class='btn btn-mini btn-info' type='button'>Ver archivo</button> " +
                    "<button class='btn btn-mini btn-info' type='button'>Visualizar</button> " +
                    "<button class='btn btn-mini btn-danger' type='button' onclick=\"JaVASCRIPT:confirmarEliminarDoc('" + documento.Nombre + "');\">Eliminar</button>"
            });
            i++;
            tablaDocumentos.Rows.Add(row);
        }
    }

    
}
