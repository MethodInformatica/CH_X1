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
            try
            {
                string idConjunto = Request.QueryString["ic"].ToString();
                string key = Request.QueryString["key"].ToString();
                if (!string.IsNullOrEmpty(idConjunto) && !string.IsNullOrEmpty(key))
                {
                    this.eliminarConjunto(idConjunto);
                }
            }
            catch (Exception ex) { }
            new Utilidad().cargarRegion(ddlRegion, "0");
            this.cargarConjuntosPaginados("", "", "0", 1);            
        }
        else
        {

        }
    }

    private void eliminarConjunto(string codigo)
    {
        new ConjuntoHabitacional_BSS().deleteByCodigo(codigo);
    }

    private void cargarConjuntosPaginados(string codigo, string nombre, string idRegion,int pagina)
    {
        int all = 0;
        if (codigo.Equals("") && nombre.Equals("") && idRegion.Equals("0"))
            all = 1;
        ConjuntoHabitacional_BSS conjunto = new ConjuntoHabitacional_BSS();
        conjunto.Pagina = pagina;
        conjunto.Codigo = codigo;
        conjunto.Nombre = nombre;
        conjunto.Region = idRegion;        
        conjunto.CantidadRegistros = Convert.ToInt32(new Utilidad().traerParametro("cantRegistros"));
        conjunto.generarResultado(all);
        this.cargarConjuntos(conjunto.Elementos);
    }

    private void cargarConjuntos(List<ConjuntoHabitacional_ENT> conjuntos) {
        int i = 1;
        HtmlTableRow cabecera = tableConjuntos.Rows[0]; 
        tableConjuntos.Rows.Clear();
        tableConjuntos.Rows.Add(cabecera);       
        foreach (ConjuntoHabitacional_ENT conjunto in conjuntos)
        {
            HtmlTableRow row = new HtmlTableRow();
            row.Cells.Add(new HtmlTableCell() { InnerHtml = i.ToString() });
            row.Cells.Add(new HtmlTableCell() { InnerHtml = "<a href='#' onclick=\"JAVASCRIPT:ingresarCJ(" + conjunto.IdConjuntoHabitacional + ",'" + new Utilidad().getMD5(conjunto.IdConjuntoHabitacional.ToString(), DateTime.Now.ToShortDateString()) + "');\" style='text-decoration:underline'>" + conjunto.CodigoConjunto + "</a>" });
            row.Cells.Add(new HtmlTableCell() { InnerHtml = conjunto.NombreConjunto });
            row.Cells.Add(new HtmlTableCell() { InnerHtml = conjunto.ComunaConjunto.Ciudad.Region.Nombre });
            row.Cells.Add(new HtmlTableCell()
            {
                InnerHtml = "<button class='btn btn-mini btn-primary' type='button' onclick=\"JAVASCRIPT:ingresarCJ(" + conjunto.IdConjuntoHabitacional + ",'" + new Utilidad().getMD5(conjunto.IdConjuntoHabitacional.ToString(), DateTime.Now.ToShortDateString()) + "');\">Ingresar</button> " +
                    "<button class='btn btn-mini btn-danger' type='button' onclick=\"JAVASCRIPT:confirmarEliminarCJ('" + conjunto.CodigoConjunto + "','" + new Utilidad().getMD5(conjunto.CodigoConjunto.ToString(), DateTime.Now.ToShortDateString()) + "');\">Eliminar</button>"
            });
            i++;
            tableConjuntos.Rows.Add(row);
        }
    }

    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/modulo/conjuntoHabitacional/Agregar.aspx");
    }
    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        this.cargarConjuntosPaginados(txtCodigo.Text, txtNombre.Text, ddlRegion.SelectedValue, 1);
    }
}
