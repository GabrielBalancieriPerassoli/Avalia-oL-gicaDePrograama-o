using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Transactions;
using static System.Console;

namespace Program
{
    class MainClass
    {
        public static void mostrarMenu(String[] opcoes)
        {
            foreach (String opcao in opcoes)
            {
                WriteLine(opcao);
            }
            WriteLine("================================");
            WriteLine("\nEscolha a opção: ");

        }

        public static void Main(String[] args)
        {
            WriteLine("====Cadastro de Fornecedores====");
            WriteLine();
            String[] opcoes = {"1 - Cadastrar Fornecedor",
                               "2 - Editar Fornecedor",
                               "3 - Excluir Fornecedor",
                               "4 - Listar Fornecedor",
                               "5 - Sair"};

            int opcao = 0;
            while(true)
            {
                mostrarMenu(opcoes);
                try
                {
                    opcao = Convert.ToInt32(ReadLine());
                }
                catch (System.FormatException)
                {
                    WriteLine("Digite um número de 1 a " + opcoes.Length + "\n");
                    continue;
                }
                catch
                {
                    WriteLine("Erro Encontrado. Tente Novamente!");
                    continue;
                }
                switch (opcao)
                {
                    case 1:
                        CadastrarFornecedor();
                        break;
                    case 2:
                        EditarFornecedor();
                        break;
                    case 3:
                        ExcluirFornecedor();
                        break;
                    case 4:
                        ListarFornecedor();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        WriteLine("Digite um número de 1 a " + opcoes.Length + "\n");
                        break;
                }
            }
             
        }

        static List<string> nomes = new List<string>();
        static List<string> celulares = new List<string>();
        static List<string> cidades = new List<string>();

        private static void CadastrarFornecedor()
        {
            Clear();
            WriteLine("====Cadastrar Fornecedor====");
            WriteLine();
            WriteLine("Digite o nome do Fornecedor: ");
            nomes.Add(ReadLine());
            WriteLine("Digite o Celular: ");
            celulares.Add(ReadLine());
            WriteLine("Digite a Cidade: ");
            cidades.Add(ReadLine());
            WriteLine("\n...");
            WriteLine("Cadastro Feito!\n");
            WriteLine("================================");

        }

        private static void EditarFornecedor()
        {
            Clear();
            WriteLine("====Edição de Fornecedor====");
            string nome = "";
            WriteLine("Digite o nome de Fornecedor que deseja editar: ");
            nome = ReadLine();
            int index = nomes.IndexOf(nome);
            if (index >= 0)
            {
                WriteLine("\nRegistro de Fornecedor que será editado:\n");
                WriteLine($"Nome: {nomes[index]}");
                WriteLine($"Celular: {celulares[index]}");
                WriteLine($"Cidade: {cidades[index]}");
                WriteLine("\n...");

                WriteLine("Digite um novo Nome: ");
                nomes[index] = ReadLine();
                WriteLine("Digite um novo Celular: ");
                celulares[index] = ReadLine();
                WriteLine("Digite uma nova Cidade: ");
                cidades[index] = ReadLine();
                WriteLine("\n...");
                WriteLine("Registro atualizado!\n");
                
            }
            else
            {
                WriteLine("Registro não encontrado. Tente Novamente!");
            }
            WriteLine("================================");

        }

        private static void ExcluirFornecedor()
        {
            Clear();
            WriteLine("====Exclusão do Fornecedor====");
            string nome = "";
            WriteLine("Digite o nome do Fornecedor que você deseja excluir: ");
            nome = ReadLine();
            int index = nomes.IndexOf(nome);

            if(index >= 0)
            {
                WriteLine("\n====Registro que será removido====\n");
                WriteLine($"Nome: {nomes[index]}");
                WriteLine($"Celular: {celulares[index]}");
                WriteLine($"Cidade: {cidades[index]}");
                WriteLine("\n...");

                nomes.RemoveAt(index);
                celulares.RemoveAt(index);
                cidades.RemoveAt(index);
                WriteLine("Registro removido com sucesso!");

            }
            else
            {
                WriteLine("Registro não encontrado!");
            }
            WriteLine();
            WriteLine("================================");
        }
        
        private static void ListarFornecedor()
        {
            Clear();
            WriteLine("====Listar Fornecedores====");
            int cont = 0;

            foreach (var item in nomes)
            {
                WriteLine($"\n Nome: {item}\n Celular: {celulares[cont]}\n Cidade: {cidades[cont]}");
                cont++;
            }
            WriteLine();
            WriteLine("================================");

        }

    }
}

