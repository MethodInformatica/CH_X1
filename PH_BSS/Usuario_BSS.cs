using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PH_ENT;
using PH_DAO;

namespace PH_BSS
{
    public class Usuario_BSS
    {
        public UsuarioSistema_ENT getByIdUsuario(UsuarioSistema_ENT usuario)
        {
            return new Usuario_DAO().getForIdUsuario(usuario);
        }
    }
}
