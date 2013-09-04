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

public partial class modulo_conjuntoHabitacional_Tabs_Seguimiento : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ConjuntoHabitacional_ENT conjunto = (ConjuntoHabitacional_ENT)Session["conjuntoHabitacionalSeleccionado"];
            this.cargarSeguimientoPaginado(conjunto,1);
        }
        else
        {
            
        }
    }

    private void cargarSeguimientoPaginado(ConjuntoHabitacional_ENT conjunto, int pagina)
    {
        txtCodigoConjunto.Text = conjunto.CodigoConjunto;
        txtNombreConjunto.Text = conjunto.NombreConjunto;
        txtEtapa.Text = conjunto.Etapa;
        Seguimiento_BSS seguimiento = new Seguimiento_BSS();
        seguimiento.Pagina = pagina;
        seguimiento.IdConjuntoHabitacional = conjunto.IdConjuntoHabitacional;
        seguimiento.CantidadRegistros = Convert.ToInt32(new Utilidad().traerParametro("cantRegistros"));
        seguimiento.generarResultado();
        this.cargarSeguimiento(seguimiento.Elementos);        
    }

    private void cargarSeguimiento(List<Seguimiento_ENT> seguimientos)
    {
        HtmlTableRow cabecera = new HtmlTableRow();
        tablaSeguimiento.Rows.Clear();
        cabecera.Cells.Clear();
        cabecera.Cells.Add(new HtmlTableCell() { 
            InnerHtml="<button type='button' class='btn'"+
            " onclick=\"JAVASCRIPT:window.open('"+Page.ResolveClientUrl("~/modulo/conjuntoHabitacional/Tabs/Seguimiento.aspx")+"','_self');\">Actualizar</button>"
        });
        tablaSeguimiento.Rows.Add(cabecera);
        foreach(Seguimiento_ENT seguimiento in seguimientos)
        {
            HtmlTableRow row = new HtmlTableRow();
            row.Cells.Add(new HtmlTableCell()
            {
                InnerHtml = "<h4>"+seguimiento.Usuario.Usuario+" - "+seguimiento.Fecha.ToShortDateString()+" "+
                seguimiento.Fecha.ToShortTimeString() + "</h4>" +
                    "<p class='text-warning'>"+ seguimiento.Mensaje +"</p>"
            });
            tablaSeguimiento.Rows.Add(row);
        }
    }
    protected void btnComentario_Click(object sender, EventArgs e)
    {
        ConjuntoHabitacional_ENT conjunto = (ConjuntoHabitacional_ENT)Session["conjuntoHabitacionalSeleccionado"];
        Seguimiento_ENT seguimiento = new Seguimiento_ENT();
        seguimiento.IdConjuntoHabitacional = conjunto.IdConjuntoHabitacional;
        seguimiento.Mensaje = txtComentario.InnerText;
        seguimiento.IdUsuario = 1;
        seguimiento.Fecha = DateTime.Now;
        seguimiento = new Seguimiento_BSS().save(seguimiento);
        this.cargarSeguimientoPaginado(conjunto, 1);
    }
}
