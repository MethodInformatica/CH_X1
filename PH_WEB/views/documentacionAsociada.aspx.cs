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

public partial class views_documentacionAsociada : System.Web.UI.Page
{
    ConjuntoHabitacional_ENT sessionConjunto = new ConjuntoHabitacional_ENT();
    protected void Page_Load(object sender, EventArgs e)
    {
        //this.sessionConjunto = (ConjuntoHabitacional_ENT)Session["sessionConjuntoHabitacional"];
        //this.cargarDatosConjunto(this.sessionConjunto); 
    }


    protected void upload()
    {
        String savePath = Server.MapPath("~/archivosUpload");

        //HttpPostedFile mifichero = archivoUpload.PostedFile;

        // Longitud en Kb
        //double Kb = mifichero.ContentLength / 1024;

        // Nombre del fichero
        //string nombreFichero = mifichero.FileName;

        // El tipo mime
        //string mimeType = mifichero.ContentType;

        // El FileStream correspondiente
        //FileStream stream = (FileStream)mifichero.InputStream;

        // Y finalmente guardar el resultado
        //mifichero.SaveAs(savePath);

        /*if (archivoUpload.HasFile)
        {
            String fileName = archivoUpload.FileName;
            savePath += fileName;
            archivoUpload.SaveAs(savePath);
        }*/
    }

    public void cargarDatosConjunto(ConjuntoHabitacional_ENT oConjunto) {
        text_codigo_conjunto.Text = oConjunto.CodigoConjunto;
        text_etapa.Text = oConjunto.Etapa;
        text_nombre_conjunto.Text = oConjunto.NombreConjunto;
    }

    protected void btn_grabar_docAsociada_Click(object sender, EventArgs e)
    {
        Documento_ENT oDocumentos = new Documento_ENT();
        
        if (this.validarIngreso() == true) {
            oDocumentos = this.datosDocumento();
            oDocumentos.IdConjuntoHabitacional = this.sessionConjunto.IdConjuntoHabitacional;
            oDocumentos = new Documento_BSS().insertDocumento(oDocumentos);
        }
    }

    public bool validarIngreso()
    {
        if (tetx_folio_documento.Text.Equals(""))
        {
            string msg = "Ingrese el folio del documento!!";
            ClientScript.RegisterStartupScript(this.GetType(), "", JavaScript.alert(msg));
            errorFolioDocumento.Visible = true;
            text_codigo_conjunto.Focus();
            return false;
        }
        else { errorFolioDocumento.Visible = false; }

        if (tetx_nombre_documento.Text.Equals(""))
        {
            string msg = "Ingrese el nombre del documento!!";
            ClientScript.RegisterStartupScript(this.GetType(), "", JavaScript.alert(msg));
            errorNombreDocumento.Visible = true;
            text_codigo_conjunto.Focus();
            return false;
        }
        else { errorNombreDocumento.Visible = false; }

        if (text_fecha_documento.Text.Equals(""))
        {
            string msg = "Ingrese la fecha del documento!!";
            ClientScript.RegisterStartupScript(this.GetType(), "", JavaScript.alert(msg));
            errorFechaDocumento.Visible = true;
            text_codigo_conjunto.Focus();
            return false;
        }
        else { errorFechaDocumento.Visible = false; }

        if (text_fecha_vencimiento.Text.Equals(""))
        {
            string msg = "Ingrese la fecha de vencimiento del documento!!";
            ClientScript.RegisterStartupScript(this.GetType(), "", JavaScript.alert(msg));
            errorVencimientoDocumento.Visible = true;
            text_codigo_conjunto.Focus();
            return false;
        }
        else { errorVencimientoDocumento.Visible = false; }

        if (text_descripcion.Text.Equals(""))
        {
            string msg = "Ingrese la descripcion del documento!!";
            ClientScript.RegisterStartupScript(this.GetType(), "", JavaScript.alert(msg));
            errorDescripcionDocumento.Visible = true;
            text_codigo_conjunto.Focus();
            return false;
        }
        else { errorDescripcionDocumento.Visible = false; }

        if (file_archivoUpload.Equals(""))
        {
            string msg = "Seleccione el archivo para cargar!!";
            ClientScript.RegisterStartupScript(this.GetType(), "", JavaScript.alert(msg));
            errorArchvio.Visible = true;
            text_codigo_conjunto.Focus();
            return false;
        }
        else { errorArchvio.Visible = false; }

        return true;
    }

    public Documento_ENT datosDocumento() {
        Documento_ENT oDocumento = new Documento_ENT();
        oDocumento.Folio = Convert.ToInt32(tetx_folio_documento.Text);
        oDocumento.Nombre = tetx_nombre_documento.Text;
        oDocumento.FechaDocumento = Convert.ToDateTime(text_fecha_documento.Text);
        oDocumento.FechaVencimiento = Convert.ToDateTime(text_fecha_vencimiento.Text);
        oDocumento.Descripcion = text_descripcion.Text;
        return oDocumento;
    } 
}
