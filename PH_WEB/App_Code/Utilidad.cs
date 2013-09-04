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
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;
using PH_ENT;
using PH_BSS;

/// <summary>
/// Descripción breve de Utilidad
/// </summary>
public class Utilidad
{
    public Utilidad()
    {
    }
        //
        // TODO: Agregar aquí la lógica del constructor
        //
        public String digitoVerificador(int rut)
        {
            int Digito;
            int Contador;
            int Multiplo;
            int Acumulador;
            String RutDigito;

            Contador = 2;
            Acumulador = 0;

            while (rut != 0)
            {
                Multiplo = (rut % 10) * Contador;
                Acumulador = Acumulador + Multiplo;
                rut = rut / 10;
                Contador = Contador + 1;
                if (Contador == 8)
                {
                    Contador = 2;
                }
            }

            Digito = 11 - (Acumulador % 11);
            RutDigito = Digito.ToString().Trim();
            if (Digito == 10)
            {
                RutDigito = "K";
            }
            if (Digito == 11)
            {
                RutDigito = "0";
            }
            return (RutDigito);
        }

        public bool validarRut(string rut)
        {
            try
            {
                if (rut != "" || rut.Length >= 7)
                {
                    if (digitoVerificador(Convert.ToInt32(rut.Split('-')[0].ToString())).Equals(rut.Split('-')[1].ToString()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Boolean validarEmail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool validarLargo(string cadena, int minimo, int maximo)
        {
            if (cadena.Length >= minimo)
            {
                if (cadena.Length <= maximo)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool validarFecha(string fecha)
        {
            DateTime dateTime;
            if (DateTime.TryParse(fecha, out dateTime))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string md5(string cadena)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(cadena));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
        public string getMD5(string cadena, string fechaHora)
        {
            string str = cadena + fechaHora + "MTD2013";
            return md5(str);
        }
        public bool compareMD5(string cadena, string cadena2)
        {
            if (cadena == md5(cadena2 + "MTD2013"))
                return true;
            else
                return false;
        }

        public void cargarRegion(DropDownList DDLregion, string selected)
        {
            DDLregion.Items.Clear();
            DDLregion.Items.Add(new ListItem()
            {
                Text = "Seleccione",
                Value = "0"
            });
            foreach (Region_ENT region in new Region_BSS().getAll())
            {
                DDLregion.Items.Add(new ListItem()
                {
                    Text = region.IdRegion.ToString() + ") " + region.Nombre,
                    Value = region.IdRegion.ToString()
                });
            }
            DDLregion.SelectedValue = selected;
        }

        public void cargarCiudad(DropDownList DDLCiudad, string idRegion, string selected)
        {
            DDLCiudad.Items.Clear();
            DDLCiudad.Items.Add(new ListItem()
            {
                Text = "Seleccione",
                Value = "0"
            });
            foreach (Ciudad_ENT ciudad in new Ciudad_BSS().getAllByIdRegion(idRegion))
            {
                DDLCiudad.Items.Add(new ListItem()
                {
                    Text = ciudad.Nombre,
                    Value = ciudad.IdCiudad.ToString()
                });
            }
            DDLCiudad.SelectedValue = selected;
        }

        public void cargarComuna(DropDownList DDLComuna, string idCiudad, string selected)
        {
            DDLComuna.Items.Clear();
            DDLComuna.Items.Add(new ListItem()
            {
                Text = "Seleccione",
                Value = "0"
            });
            foreach (Comuna_ENT ciudad in new Comuna_BSS().getAllByIdCiudad(idCiudad))
            {
                DDLComuna.Items.Add(new ListItem()
                {
                    Text = ciudad.Nombre,
                    Value = ciudad.IdComuna.ToString()
                });
            }
            DDLComuna.SelectedValue = selected;
        }

        public string traerParametro(string nombre)
        {
            return System.Configuration.ConfigurationSettings.AppSettings.Get(nombre);
        }

        public int uploadArchivo(FileUpload fileArchivo, string path, string[] extension, string nombre)
        {
            Boolean fileOK = false;
            String fileExtension = "";
            if (fileArchivo.HasFile)
            {
                fileExtension =
                    System.IO.Path.GetExtension(fileArchivo.FileName).ToLower();
                for (int i = 0; i < extension.Length; i++)
                {
                    if (fileExtension == extension[i])
                    {
                        fileOK = true;
                    }
                }
            }

            if (fileOK)
            {
                try
                {
                    fileArchivo.PostedFile.SaveAs(path
                        + nombre + fileExtension);
                    return 1;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
            else
            {
                return 2;
            }
        }

        public void eliminarArchivo(string path)
        {
            if (System.IO.File.Exists(path))
                System.IO.File.Delete(path);
        }
}
