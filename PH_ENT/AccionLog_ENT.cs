using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PH_ENT
{
    public class AccionLog_ENT
    {
        private int idAccionLog;
        private string nombre;
        private bool estado;

        public int IdAccionLog
        {
            get { return idAccionLog; }
            set { idAccionLog = value; }
        }
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
