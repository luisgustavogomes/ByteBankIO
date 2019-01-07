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
        static void EscritaBinaria()
        {
            var caminho = "contaCorrenteBinaria.csv";

            using (var fs = new FileStream(caminho, FileMode.Create))
            using (var escritor = new BinaryWriter(fs))
            {
                escritor.Write(456);
                escritor.Write(456.98);
                escritor.Write(true);
                escritor.Write("Pedro da Silva");
            }
        }

        static void LeituraBinaria()
        {
            var caminho = "contaCorrenteBinaria.csv";

            using (var fs = new FileStream(caminho, FileMode.Open))
            using (var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var sucesso = leitor.ReadBoolean();
                var nome = leitor.ReadString();

                Console.WriteLine($"Agencia: {agencia}, Saldo: {saldo}, Sucesso: {sucesso}, Nome: {nome}" );
            }

        }
    }

}
