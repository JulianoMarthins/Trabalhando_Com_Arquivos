using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalhando_Com_Arquivos
{
    internal class Aula05_Directory_DirectoryInfo
    {

        /*
         * string path = @"D:\WorkSpace";

            try
            {
                // O primeiro argumento é o caminho do diretório, o segundo, é em forma de string e ele pode ser analisado
                // como "*.*", ou seja, qualquer nome de pasta ponto qualquer nome de extenção, e em terceiro argumento
                // será a opção de busca, no caso chamamos todos os diretórios ou apenas o diretório onde estamos, logo, 
                // a opção AllDirectories retorta todas as pastas e sub pastas contidas neste diretório. 
                 
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS\n");

                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("FILES\n");

                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                Directory.CreateDirectory(path + @"/NewFolderCreateByVSCode");

            }

            catch (IOException e)
            {
                Console.WriteLine($"An error occurred!\n{e.Message}");
            }

        */

    }
}
