﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PH_ENT;
using PH_DAO;

namespace PH_BSS
{
    public class Casa_BSS
    {
        public Casa_BSS(){
        }

        public Casa_ENT insertCasa(Casa_ENT datosCasa)
        {
            Casa_ENT oCasa = new Casa_DAO().insert(datosCasa);
            return oCasa;
        }

        public int deleteCasa(Casa_ENT datosCasa)
        {
             int error = new Casa_DAO().delete(datosCasa);
             return error;
        }

        public Casa_ENT getCasaID(Casa_ENT datosCasa) {
            Casa_ENT oCasa = new Casa_DAO().getForIdCasa(datosCasa);
            return oCasa;
        }

        public int updateCasa(Casa_ENT datosCasa) 
        {
            return new Casa_DAO().update(datosCasa);
        }

        public Casa_ENT generaCodigo(string codigo) 
        {
            string codigoProducto;
            Casa_ENT oCasa = new Casa_ENT();
            oCasa = new Casa_DAO().insertCasa(codigo);

            int cantidad = oCasa.Cantidad;

            if (cantidad.ToString().Length == 1)
            {
                codigoProducto = codigo + "00" + cantidad;
            }
            else if (cantidad.ToString().Length == 2)
            {
                codigoProducto = codigo + "0" + cantidad;
            }
            else 
            {
                codigoProducto = codigo + cantidad;
            }

            oCasa.CodigoProducto = codigoProducto;
            
            return oCasa;
        }

    }
}
