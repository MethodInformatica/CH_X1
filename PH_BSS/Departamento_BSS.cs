using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PH_ENT;
using PH_DAO;

namespace PH_BSS
{
    public class Departamento_BSS
    {
        public Departamento_BSS() { 
        }

        public Departamento_ENT insertDepartamento(Departamento_ENT datosDepartamento)
        {
            Departamento_ENT oDepartamento = new Departamento_DAO().insert(datosDepartamento);
            return oDepartamento;
        }

        public void deleteDepartamento(Departamento_ENT datosDepartamento)
        {
            new Departamento_DAO().delete(datosDepartamento);
        }

        public Departamento_ENT getDepartamentoID(Departamento_ENT datosDepartamento)
        {
            Departamento_ENT oDepartamento = new Departamento_DAO().getForIdDepartamento(datosDepartamento);
            return oDepartamento;
        }

        public int updateDepartamento(Departamento_ENT datosDepartamento)
        {
            return new Departamento_DAO().update(datosDepartamento);
        }

    }
}
