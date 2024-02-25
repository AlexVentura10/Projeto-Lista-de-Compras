using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Lista_de_Compras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listCompras = new List<string>();
            List<double> listPreço = new List<double>();


            try
            {


                while (true)
                {
                    Console.WriteLine("______________Sua Lista______________");
                    Console.WriteLine("1 - Adicionar produto a sua lista");
                    Console.WriteLine("2 - Ver produtos na minha lista");
                    Console.WriteLine("3 - Remover produto da minha lista");
                    Console.WriteLine("4 - Excluir lista");
                    Console.WriteLine("5 - Sair");
                    Console.WriteLine("_____________________________________");

                    Console.WriteLine("Digite o número da sua opção ");
                    int opcao = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    if (opcao == 1)
                    {
                        Console.WriteLine("Informe o nome do produto:");
                        string produto = Console.ReadLine();

                        listCompras.Add(produto);

                        Console.WriteLine("Informe o preço do produto");
                        double preço = Convert.ToDouble(Console.ReadLine());

                        listPreço.Add(preço);

                        Console.Clear();

                        Console.WriteLine("Produto adicionado com sucesso.");
                    }


                    else if (opcao == 2)
                    {
                        if (listCompras.Count > 0)
                        {

                            Console.WriteLine("Sua lista de compras");
                            for (int i = 0; i < listCompras.Count && i < listPreço.Count; i++)
                            {
                                Console.WriteLine($"Produto {i + 1}: {listCompras[i]} - Preço: {listPreço[i].ToString("c")}");
                            }

                            int soma = 0;
                            foreach (int preço in listPreço) // loop foreach para iterar sobre todos os valores da lista.   Para cada preço (int preço) na listPreço, o programa faz a soma na linha "soma += preço".
                            {
                                soma += preço;
                            }
                            Console.WriteLine($"Preço total: {soma}");
                        }

                        else
                        {
                            Console.WriteLine("Você não possui nenhum produto na sua lista");
                        }


                    }


                    else if (opcao == 3)
                    {
                        if (listCompras.Count > 0)
                        {
                            Console.WriteLine("Sua lista de compras");
                            for (int i = 0; i < listCompras.Count && i < listPreço.Count; i++)

                                Console.WriteLine($"Produtos {i + 1}: {listCompras[i]} - Preço: {listPreço[i]}");

                            Console.WriteLine("Digite o número do protudo que deseja remover");

                            if (int.TryParse(Console.ReadLine(), out var remover)) //lê a entrada do usuário e tenta converter essa entrada para um número inteiro e armazena na var "remover"
                            {
                                listCompras.RemoveAt(remover - 1); //removendo o produto selecionado da "listCompras"
                                Console.Clear();
                                Console.WriteLine("Produto removido com sucesso.");
                            }
                        }


                        else
                        {
                            Console.WriteLine("Você não possui nenhum produto na sua lista.");
                        }


                    }


                    else if (opcao == 4)
                    {

                        if (listCompras.Count > 0)
                        {
                            while (true)
                            {
                                Console.WriteLine("Deseja realmente excluir sua lista?");
                                Console.WriteLine("Digite S/N:");
                                string opçao = Console.ReadLine().ToUpper();

                                Console.Clear();

                                if (opçao == "S")
                                {
                                    listCompras.Clear();
                                    Console.WriteLine("Lista excluida com sucesso.");
                                    break;
                                }

                                else if (opçao == "N")
                                {
                                    break;
                                }

                                else
                                {
                                    Console.WriteLine("Opção desconhecia! Digite \"S\" para SIM e \"N\" para NÃO.");
                                }

                            }
                        }

                        else
                        {
                            Console.WriteLine("Você não possui nenhum produto na sua lista.");
                        }

                    }


                    else if (opcao == 5)
                    {
                        break;
                    }


                    else
                    {
                        Console.WriteLine("Opção desconhecida.");
                    }

                }
            }


            catch (Exception e)
            {
                Console.WriteLine($"EXCESSÃO: {e.Message}");
            }


            finally
            {
                Console.WriteLine("Aperte qualquer tecla para continuar.");
            }

        }
    }
}
