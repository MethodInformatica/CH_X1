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

public partial class modulo_conjuntoHabitacional_Tabs_DocumentoEditar : System.Web.UI.Page
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
                    ConjuntoHabitacional_ENT conjunto = (ConjuntoHabitacional_ENT)Session["conjuntoHabitacionalSeleccionado"];
                    this.cargarFormulario(conjunto, idDoc);
                }
            }
            catch (Exception ex) { }
        }
        else
        {
            ConjuntoHabitacional_ENT conjunto = (ConjuntoHabitacional_ENT)Session["conjuntoHabitacionalSeleccionado"];
            txtCodigoConjunto.Text = conjunto.CodigoConjunto;
            txtNombreConjunto.Text = conjunto.NombreConjunto;
            txtEtapa.Text = conjunto.Etapa;
        }
    }
    private void cargarFormulario(ConjuntoHabitacional_ENT conjunto, string idDocumento)
    {
        txtCodigoConjunto.Text = conjunto.CodigoConjunto;
        txtNombreConjunto.Text = conjunto.NombreConjunto;
        txtEtapa.Text = conjunto.Etapa;
        Documento_ENT documento = new Documento_BSS().getDocumentoID(new Documento_ENT() { IdDocumento=Convert.ToInt32(idDocumento) });
        txtFolioDocumento.Text = documento.Folio;
        txtNombreDocumento.Text = documento.Nombre;
        txtDescripcion.InnerText = documento.Descripcion;
        txtFechaDocumento.Text = documento.FechaDocumento.Year.Equals(1900) ? "" : documento.FechaDocumento.ToShortDateString();
        txtFechaVencimiento.Text = documento.FechaVencimiento.Year.Equals(1900) ? "" : documento.FechaVencimiento.ToShortDateString();
        divArchivo.InnerHtml = "<button class='btn btn-mini btn-info' type='button' onclick=\"JAVASCRIPT:window.open('" + Page.ResolveClientUrl("~/modulo/conjuntoHabitacional/archivosCargados/") + documento.ArchivoNombre + "','_blank');\">Ver Archivo Actual</button>";
        hdId.Value = documento.IdDocumento.ToString();
    }
    private bool validar()
    {
        if (!new Utilidad().validarLargo(txtFolioDocumento.Text, 1, 15))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe ingresar el folio del documento"));
            return false;
        }
        if (!new Utilidad().validarLargo(txtNombreConjunto.Text, 1, 30))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "",
                JavaScript.alert("Debe ingresar el nombre del documento"));
            return false;
        }
        return true;
    }

    private Documento_ENT cargarDocumento()
    {
        ConjuntoHabitacional_ENT conjunto = (ConjuntoHabitacional_ENT)Session["conjuntoHabitacionalSeleccionado"];
        Documento_ENT documento = new Documento_ENT();
        documento.IdConjuntoHabitacional = conjunto.IdConjuntoHabitacional;
        documento.Nombre = txtNombreDocumento.Text;
        documento.Folio = txtFolioDocumento.Text;
        documento.FechaDocumento = txtFechaDocumento.Text.Equals("") ? new DateTime(1900, 1, 1) : Convert.ToDateTime(txtFechaDocumento.Text);
        documento.FechaVencimiento = txtFechaVencimiento.Text.Equals("") ? new DateTime(1900, 1, 1) : Convert.ToDateTime(txtFechaVencimiento.Text);
        documento.FechaIngreso = DateTime.Now;
        documento.Descripcion = txtDescripcion.InnerText;
        documento.Estado = true;
        documento.IdDocumento = Convert.ToInt32(hdId.Value);
        return documento;

    }

    protected void btn_grabar_docAsociada_Click(object sender, EventArgs e)
    {
        if (this.validar())
        {
            Documento_ENT documento = this.cargarDocumento();
            Documento_ENT oDocumento = new Documento_BSS().getDocumentoID(new Documento_ENT() { IdDocumento = documento.IdDocumento });

            if (fileArchivo.HasFile)
            {
                string nombreDocumento = new Utilidad().getMD5(fileArchivo.FileName, DateTime.Now.ToShortDateString()).ToUpper();
                int resultadoUpload = new Utilidad().uploadArchivo(fileArchivo,
                    Server.MapPath(new Utilidad().traerParametro("rutaUpload")),
                    new Utilidad().traerParametro("extensionUpload").Split('/'),
                    nombreDocumento);
                if (resultadoUpload.Equals(1))
                {
                    documento.ArchivoNombre = nombreDocumento + System.IO.Path.GetExtension(fileArchivo.FileName).ToLower();
                    documento.ArchivoExtencion = System.IO.Path.GetExtension(fileArchivo.FileName).ToLower();
                    documento.ArchivoTipo = documento.ArchivoExtencion.Replace(".", "");
                    documento.FechaIngreso = oDocumento.FechaIngreso;
                    documento.Estado = oDocumento.Estado;
                    documento.IdConjuntoHabitacional = oDocumento.IdConjuntoHabitacional;
                    new Documento_BSS().update(documento);
                    ClientScript.RegisterStartupScript(this.GetType(), "", JavaScript.alert("Documento Actualizado Exitósamente"));
                    Response.Redirect("~/modulo/conjuntoHabitacional/Tabs/DocumentoListado.aspx");
                }
                else if (resultadoUpload.Equals(2))
                    ClientScript.RegisterStartupScript(this.GetType(), "", JavaScript.alert("La extensión del archivo no esta permitida"));
                else
                    ClientScript.RegisterStartupScript(this.GetType(), "", JavaScript.alert("Error al cargar archivo, intente nuevamente, si el problema persiste consulte con su administrador"));
            }
            else
            {
                documento.FechaIngreso = oDocumento.FechaIngreso;
                documento.Estado = oDocumento.Estado;
                documento.IdConjuntoHabitacional = oDocumento.IdConjuntoHabitacional;
                documento.ArchivoExtencion = oDocumento.ArchivoExtencion;
                documento.ArchivoNombre = oDocumento.ArchivoNombre;
                documento.ArchivoTipo = oDocumento.ArchivoTipo;
                new Documento_BSS().update(documento);
                ClientScript.RegisterStartupScript(this.GetType(), "", JavaScript.alert("Documento Actualizado Exitósamente"));
                Response.Redirect("~/modulo/conjuntoHabitacional/Tabs/DocumentoListado.aspx");
            }

        }
    }
}
