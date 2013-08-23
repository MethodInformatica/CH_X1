using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PH_ENT
{
    public class UsuarioSistema_ENT
    {
        private int idUsuarioSistema;
        private string rut;
        private string nombres;
        private string apPaterno;
        private string apMaterno;
        private string usuario;
        private string clave;
        private int idPerfil;
        private bool estado;

        public int IdUsuarioSistema
        {
            get { return idUsuarioSistema; }
            set { idUsuarioSistema = value; }
        }
        
        public string Rut
        {
            get { return rut; }
            set { rut = value; }
        }
        
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        
        public string ApPaterno
        {
            get { return apPaterno; }
            set { apPaterno = value; }
        }
        
        public string ApMaterno
        {
            get { return apMaterno; }
            set { apMaterno = value; }
        }
        
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        
        public int IdPerfil
        {
            get { return idPerfil; }
            set { idPerfil = value; }
        }
        
        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
