using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PH_ENT
{
    public class LogUsuario_ENT
    {
        private int idLogUsuario;
        private int idUsuarioSistema;
        private int idAccionLog;
        private string glosa;
        private string datoNuevo;
        private string datoAntiguo;
        private bool estado;
        private DateTime fecha;
        private string rut;
        private string apPaterno;

        public int IdLogUsuario
        {
            get { return idLogUsuario; }
            set { idLogUsuario = value; }
        }
        
        public int IdUsuarioSistema
        {
            get { return idUsuarioSistema; }
            set { idUsuarioSistema = value; }
        }
        
        public int IdAccionLog
        {
            get { return idAccionLog; }
            set { idAccionLog = value; }
        }
        
        public string Glosa
        {
            get { return glosa; }
            set { glosa = value; }
        }
        
        public string DatoNuevo
        {
            get { return datoNuevo; }
            set { datoNuevo = value; }
        }
        
        public string DatoAntiguo
        {
            get { return datoAntiguo; }
            set { datoAntiguo = value; }
        }
        
        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        
        public string Rut
        {
            get { return rut; }
            set { rut = value; }
        }
        
        public string ApPaterno
        {
            get { return apPaterno; }
            set { apPaterno = value; }
        }
    }
}
