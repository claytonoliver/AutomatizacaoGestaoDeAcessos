using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatiza.Controle.VariaveisPublicas
{
    public class PublicVar
    {

            public static string CaminhoArquivo { get; set; }
            //valida Status dos dois checkbox que tratam conceção e revogação
            public static string Status { get; set; }

            // Está amarrado com o switch
            public static string Escolha { get; set; }

            // Está amarrado com o caminho para buscar cada arquivo na pasta 01
            public static string Caminho { get; set; }

            public static string BasePA { get; set; }
            public static string UsrSisbr { get; set; }
            public static string texto { get; set; }
            public static string identificador { get; set; }


    }
}
