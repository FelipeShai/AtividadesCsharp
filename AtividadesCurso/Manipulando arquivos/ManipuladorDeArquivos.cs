using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso.Manipulando_arquivos
{
    public static class ManipuladorDeArquivos
    {
      public static void TransferirArquivo(string sourcePath, string targetPath)
        {

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                Console.WriteLine(fileInfo.Length);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines) { Console.WriteLine(line); }
                Console.WriteLine("_________________");


            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
