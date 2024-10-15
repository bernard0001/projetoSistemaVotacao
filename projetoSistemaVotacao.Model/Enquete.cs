using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class EnqueteModelo
    {
        int EnqueteID { get; set; }

        //necessário adicionar atributo de id de usuário para atribuir a criação de uma enquete a alguém
    }

    public EnqueteModelo(int enqueteID)
    {
        EnqueteID = enqueteID;
    }
}