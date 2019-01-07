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
        static void CriarArquivoComWriter()
        {
            var caminho = "contasExportadas.csv";

            using (var fluxo = new FileStream(caminho, FileMode.CreateNew))
            using (var escritor = new StreamWriter(fluxo, UTF8Encoding.UTF8))
            {
                escritor.Write("456,65365,456.0,Pedro da silva");
            }

        }

        static void TestaEscritaNoArquivoFlush()
        {
            var caminho = "TestaEscritaNoArquivo.csv";

            using (var fluxo = new FileStream(caminho, FileMode.CreateNew))
            using (var escritor = new StreamWriter(fluxo, UTF8Encoding.UTF8))
            {
                for (int i = 0; i < 100; i++)
                {
                    escritor.WriteLine($"Linha: {i}");
                    escritor.Flush();
                    Console.WriteLine($"Escrita a linha: {i}");
                    Console.ReadLine();
                }

            }


            }
    }
}