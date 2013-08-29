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

public partial class modulo_conjuntoHabitacional_Tabs_Seguimiento : System.Web.UI.Page
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
        for (int i = 1; i <= 4;i++)
        {
            HtmlTableRow row = new HtmlTableRow();
            row.Cells.Add(new HtmlTableCell() { InnerHtml = "<h4>maviles - 22/05/2013 14:"+(i*8).ToString()+"</h4>"+
                    "<p class='text-warning'>Comentario '"+i.ToString()+"'</p>" });
            tablaSeguimiento.Rows.Add(row);
        }
    }
    protected void btnComentario_Click(object sender, EventArgs e)
    {
        ConjuntoHabitacional_ENT conjunto = (ConjuntoHabitacional_ENT)Session["conjuntoHabitacionalSeleccionado"];
        txtCodigoConjunto.Text = conjunto.CodigoConjunto;
        txtNombreConjunto.Text = conjunto.NombreConjunto;
        txtEtapa.Text = conjunto.Etapa;
        
        HtmlTableRow row = new HtmlTableRow();
        row.Cells.Add(new HtmlTableCell()
        {
            InnerHtml = "<h4>ibalmaceda - " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "</h4>" +
                "<p class='text-warning'>"+txtComentario.InnerText+"</p>"
        });
        tablaSeguimiento.Rows.Add(row);
        for (int i = 1; i <= 4; i++)
        {
            HtmlTableRow row2 = new HtmlTableRow();
            row2.Cells.Add(new HtmlTableCell()
            {
                InnerHtml = "<h4>maviles - 22/05/2013 14:" + (i * 8).ToString() + "</h4>" +
                    "<p class='text-warning'>Comentario '" + i.ToString() + "'</p>"
            });
            tablaSeguimiento.Rows.Add(row2);
        }
        txtComentario.InnerText = "";
    }
}
