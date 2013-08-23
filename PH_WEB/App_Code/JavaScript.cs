using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Descripción breve de JavaScript
/// </summary>
public class JavaScript
{
    public JavaScript()
    {
    }

    public static string alert(string msg)
    {
        string script = "<script type='text/javascript'>alert('" + msg + "');</script>";
        return script;
    }

    public static string confirm(string msg, string controlAceptar, string controlCancelar)
    {
        string script = "<script type='text/javascript'>" + "if(confirm('" + msg + "')) { "
            + "__doPostBack('" + controlAceptar + "','true'); "
            + " } else{__doPostBack('" + controlCancelar + "','false');}"
            + "</script>";
        return script;

    }

    public static string alert(string msg, string controlAceptar)
    {
        string script = "<script type='text/javascript'>__doPostBack('" + controlAceptar + "','true');alert('" + msg + "');</script>";
        return script;
    }

    public static string captura(string controlName, string controlConf)
    {
        string isOK = "";
        switch (controlName)
        {
            case "Aceptar":
                if (Convert.ToBoolean(controlConf))
                {
                    isOK = "true";
                }
                break;
            case "Cancelar":
                if (!Convert.ToBoolean(controlConf))
                {
                    isOK = "false";
                }
                break;
        }
        return isOK;
    }
}
