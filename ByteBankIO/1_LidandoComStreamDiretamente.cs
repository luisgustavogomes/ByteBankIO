using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteBankIO
{
    partial class Program
    {
        static void Separador()
        {
            Console.WriteLine("--------------------------------");
        }

        static void TrabalhandoComFileStream()
        {
            var enderecoDoarquivo = "contas.txt";

            using (var fluxoDoAquivo = new FileStream(enderecoDoarquivo, FileMode.Open))
            {
                var buffer = new byte[1024];
                var numeroDeBytesLidos = -1;
                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoAquivo.Read(buffer, 0, 1024);
                    EscreverBuffer(buffer, numeroDeBytesLidos);
                }
            }
        }

        static void EscreverBuffer(byte[] buffer, int numeroDeBytesLidos)
        {
            Console.Write(Encoding.Default.GetString(buffer, 0, numeroDeBytesLidos));

            //var utf8 = new UTF8Encoding();
            //Console.Write(utf8.GetString(buffer));
            //
            //foreach (var item in buffer)
            //{
            //    Console.Write(item);
            //    Console.Write(" ");
            //}
        }
    }
}