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
using System.Globalization;
using System.Threading;

public partial class modulo_conjuntoHabitacional_Tabs_DocumentoListado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                string idDoc = Request.QueryString["ic"].ToString();
                string key = Request.QueryString["key"].ToString();
                if (!string.IsNullOrEmpty(idDoc) && !string.IsNullOrEmpty(key))
                {
                    this.eliminarDocumento(idDoc);
                }
            }
            catch (Exception ex) { }

            this.cargarConjuntosPaginados("", "", new DateTime(1900, 2, 2), new DateTime(1900, 2, 2), 1);
        }
        else
        {
        }
    }

    private void cargarConjuntosPaginados(string folio, string nombre, 
        DateTime fechaDocumento,DateTime fechaVencimiento, int pagina)
    {
        ConjuntoHabitacional_ENT conjunto = (ConjuntoHabitacional_ENT)Session["conjuntoHabitacionalSeleccionado"];
        int all = 0;
        if (folio.Equals("") && nombre.Equals("") && fechaDocumento.Year.Equals(1900) && 
            fechaVencimiento.Year.Equals(1900))
            all = 1;
        Documento_BSS documento = new Documento_BSS();
        documento.IdConjuntoHabitacional = conjunto.IdConjuntoHabitacional;
        documento.Folio = folio;
        documento.Nombre = nombre;
        documento.FechaDocumento = fechaDocumento;
        documento.FechaVencimiento = fechaVencimiento;
        documento.CantidadRegistros = Convert.ToInt32(new Utilidad().traerParametro("cantRegistros"));
        documento.generarResultado(all);
        this.cargarFormulario(conjunto,documento.Elementos);
    }
    private void eliminarDocumento(string id)
    {
        Documento_ENT documento = new Documento_BSS().getDocumentoID(new Documento_ENT() { IdDocumento = Convert.ToInt32(id) });
        new Utilidad().eliminarArchivo(Server.MapPath(new Utilidad().traerParametro("rutaUpload") + documento.ArchivoNombre));
        new Documento_BSS().deleteDocumento(new Documento_ENT() { IdDocumento=Convert.ToInt32(id) });

    }
    private void cargarFormulario(ConjuntoHabitacional_ENT conjunto, List<Documento_ENT> documentos)
    {
        txtCodigoConjunto.Text = conjunto.CodigoConjunto;
        txtNombreConjunto.Text = conjunto.NombreConjunto;
        txtEtapa.Text = conjunto.Etapa;
        int i = 1;
        foreach (Documento_ENT documento in documentos)
        {
            HtmlTableRow row = new HtmlTableRow();
            row.Cells.Add(new HtmlTableCell() { InnerHtml = i.ToString() });
            row.Cells.Add(new HtmlTableCell() { InnerHtml = documento.Folio.ToString() });
            row.Cells.Add(new HtmlTableCell() { InnerHtml = documento.Nombre });
            row.Cells.Add(new HtmlTableCell() { InnerHtml = documento.FechaDocumento.Year.Equals(1900)?"": documento.FechaDocumento.ToShortDateString() });
            row.Cells.Add(new HtmlTableCell() { InnerHtml = documento.FechaVencimiento.Year.Equals(1900)?"": documento.FechaVencimiento.ToShortDateString() });
            row.Cells.Add(new HtmlTableCell()
            {
                InnerHtml = "<button class='btn btn-mini btn-info' type='button' onclick=\"JAVASCRIPT:visualizarDoc('" + Page.ResolveClientUrl("~/modulo/conjuntoHabitacional/archivosCargados/") + documento.ArchivoNombre + "');\">Ver archivo</button> " +
                    "<button class='btn btn-mini btn-warning' type='button' onclick=\"JAVASCRIPT:modificarDoc(" + documento.IdDocumento + ",'" + new Utilidad().getMD5(documento.IdDocumento.ToString(), DateTime.Now.ToShortDateString()) + "');\">Modificar</button> " +
                    "<button class='btn btn-mini btn-danger' type='button' onclick=\"JaVASCRIPT:confirmarEliminarDoc('" + documento.Nombre + "'," + documento.IdDocumento + ",'" + new Utilidad().getMD5(documento.IdDocumento.ToString(), DateTime.Now.ToShortDateString()) + "');\">Eliminar</button>"
            });
            i++;
            tablaDocumentos.Rows.Add(row);
        }
    }
    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        this.cargarConjuntosPaginados(txtFolio.Text, txtNombre.Text,
            txtFechaDocumento.Text.Equals("") ? new DateTime(1900, 2, 2) : Convert.ToDateTime(txtFechaDocumento.Text),
            txtFechaVencimiento.Text.Equals("") ? new DateTime(1900, 2, 2) : Convert.ToDateTime(txtFechaVencimiento.Text), 
            1);
    }
}
