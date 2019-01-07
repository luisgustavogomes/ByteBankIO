using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ByteBankIO.Modelos;

namespace ByteBankIO
{
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";
            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaString = "456, 78908, 4580.50,Gustavo Santos";
                var encoding = Encoding.UTF8;
                var bytes = encoding.GetBytes(contaString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }


        }

    }
}
