using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalhando_Com_Arquivos
{
    internal class Aula01_File_FileInfo_IOException
    {
        /*

        // Armazena na variavel o caminho do documento file1.txt -> O @ no inicio da string faz com o complilador
        // interprete o caracter \ como separador de caminhos, caso não seja adicionado o @ no inicio da string, 
        // será necessário incluir duas vezes o caracter.
        // <  @"D:\WorkSpace\File1.txt" >
        // <  "D:\\WorkSpace\\File1.txt" >

        string sourcePath = @"D:\WorkSpace\File1.txt";

        // Armazena na variavel o caminho e nome do arquivo de destino, o que será salvo pelo compliador do computador
        string targetPath = @"D:\WorkSpace\File2.txt";


            try
            {   
                // Criada uma variavel do tipo FileInfo onde será criado um novo arquivo FileInfo com o valor contido na
                // variavel sourcePath
                FileInfo fileInfo = new FileInfo(sourcePath);

        // Função abaixo do fileinfo irá copiar o arquivo contido nesta variavel, para o caminho de destino passado
        // no argumento da variável targetPath
        fileInfo.CopyTo(targetPath);

                // Criação de um vetor de strings em que guarda na variavel lines, a função ReadAllLines lê todas as linhas
                // do arquivo contidido no sourcePath
                string[] lines = File.ReadAllLines(sourcePath);

                // Foreach lê linha a linha do vetor de strings lines, e imprime linha a linha no console do usuário
                foreach (string line in lines)
                {
                    Console.WriteLine(line);

                }


}

            catch(IOException e)
            {
                Console.WriteLine("An error occured");
Console.WriteLine(e.Message);
            }


        */
    }
}
