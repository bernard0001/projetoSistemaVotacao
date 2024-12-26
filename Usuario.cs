using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class UsuarioModelo
    {
        int UsuarioID { get; set; }

        string Email { get; set; }

        string Senha { get; set; }

        string UsuarioAcesso { get; set; }
    }

    public UsuarioModelo(int usuarioID, string email, string senha, string usuarioAcesso)
    {
        UsuarioID = usuarioID;
        Email = email;
        Senha = senha;
        UsuarioAcesso = usuarioAcesso;
    }
}