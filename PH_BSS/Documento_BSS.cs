using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PH_ENT;
using PH_DAO;

namespace PH_BSS
{
    public class Documento_BSS
    {
        public Documento_ENT insertDocumento(Documento_ENT datosDocumento)
        {
            Documento_ENT oDocumento = new Documento_DAO().insert(datosDocumento);
            return oDocumento;
        }

        public int deleteDocumento(Documento_ENT datosDocumento)
        {
            int error = new Documento_DAO().delete(datosDocumento);
            return error;
        }

        public Documento_ENT getDocumentoID(Documento_ENT datosDocumento)
        {
            Documento_ENT oDocumento = new Documento_DAO().getForIdDocumento(datosDocumento);
            return oDocumento;
        }

        public List<Documento_ENT> listAllByIdConjunto(int idConjunto)
        {
            List<Documento_ENT> listConjunto = new Documento_DAO().listConjuntoHabitacional(idConjunto);
            return listConjunto;
        }
    }
}
