using System;

namespace AppGoodFood
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            Console.WriteLine(" Bem vindo ao restaurante comunitário: The Good Food! \n");
            Console.WriteLine(" Menu \n");
            Console.WriteLine(" Lanches:");
            Console.WriteLine(" 1-Hamburger de grão de bico");
            Console.WriteLine(" 2-Hamburger de quinoa ");
            Console.WriteLine(" 3-Hamburger de lentilha ");
            Console.WriteLine(" 4-Batata frita rústica com queijo vegetal ");
            Console.WriteLine(" 5-Batata frita rústica com paprica \n");
            Console.WriteLine(" Combos \n");
            Console.WriteLine(" 6-Hamburger 1 + batata 4");
            Console.WriteLine(" 7-Hamburger 1 + batata 5");
            Console.WriteLine(" 8-Hamburger 2 + batata 4");
            Console.WriteLine(" 9-Hamburger 2 + batata 5");
            Console.WriteLine(" 10-Hamburger 3 + batata 4");
            Console.WriteLine(" 11-Hamburger 3 + batata 5 ");
            Console.WriteLine(" Todos acompanham batata frita simples ou molho de tomate picante. \n");
            Console.WriteLine(" Pizzas:");
            Console.WriteLine(" 12-Mussarela");
            Console.WriteLine(" 13-Margherita\n");


            {
                Console.Write(" Digite o número do seu pedido: ");
                opcao = (Console.ReadLine());
                while (opcao != "0")
                {
                    switch (opcao)
                    {
                        case "1":
                            Console.WriteLine(" Você escolheu burger de grão de bico!");

                            break;

                        case "2":
                            Console.WriteLine(" Você escolheu burger de quinoa!");
                            break;

                        case "3":
                            Console.WriteLine(" Você escolheu burger de lentilha!");
                            break;

                        case "4":
                            Console.WriteLine(" Você escolheu batata frita rústica com queijo vegetal!");
                            break;

                        case "5":
                            Console.WriteLine(" Você escolheu batata frita rústica com páprica!");
                            break;

                        case "6":
                            Console.WriteLine(" Você escolheu burger de grão de bico + batata rústica com queijo vegetal!");
                            break;

                        case "7":
                            Console.WriteLine(" Você escolheu burger de grão de bico + batata rústica com páprica!");
                            break;

                        case "8":
                            Console.WriteLine(" Você escolheu burger de quinoa + batata rústica com queijo vegetal!");
                            break;
                        case "9":
                            Console.WriteLine(" Você escolheu burger de quinoa + batata rústica com páprica!");
                            break;
                        case "10":
                            Console.WriteLine(" Você escolheu burger de lentilha + batata rústica com queijo vegetal!");
                            break;
                        case "11":
                            Console.WriteLine(" Você escolheu burger de lentilha + batata rústica com páprica!");
                            break;
                        case "12":
                            Console.WriteLine(" Você escolheu uma pizza de mussarela!");
                            break;
                        case "13":
                            Console.WriteLine(" Você escolheu uma pizza de margherita!");
                            break;

                        default:
                            Console.WriteLine("Opção Inválida!");
                            break;
                    }

                    Console.WriteLine("\n Algo mais? ");
                    Console.WriteLine("Selecione mais um lanche ou digite 0 para sair");
                    opcao = (Console.ReadLine());
                }

                Console.WriteLine("Sua refeição paga outra refeição. Obrigado!");

                Console.ReadKey();
            }
        }
    }
}
