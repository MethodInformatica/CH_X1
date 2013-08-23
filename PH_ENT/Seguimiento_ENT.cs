using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PH_ENT
{
    public class Seguimiento_ENT
    {
        private int idSeguimiento;
        private int idConjuntoHabitacional;
        private int idUsuario;
        private DateTime fecha;
        private string mensaje;

        public int IdSeguimiento
        {
            get { return idSeguimiento; }
            set { idSeguimiento = value; }
        }
        
        public int IdConjuntoHabitacional
        {
            get { return idConjuntoHabitacional; }
            set { idConjuntoHabitacional = value; }
        }
        
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        
        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }
    }
}
