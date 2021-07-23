using System;

namespace AppGoodFood
{
    public enum Opcao
    {
        Chickpeas = 1,
        Quinoa = 2,
        Lentilha = 3,
        BatataQv = 4,
        BatataP = 5,
        Combo1 = 6,
        Combo2 = 7,
        Combo3 = 8,
        Combo4 = 9,
        Combo5 = 10,
        Combo6 = 11,
        Mussarela = 12,
        Margherita = 13
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Opcao opcao;

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
                Console.ReadLine();
                
                for (Opcao i = Opcao.Chickpeas; i < Opcao.Margherita; i++)
                {
                    switch (i)
                    {
                        case Opcao.Chickpeas:
                            Console.WriteLine(" Você escolheu burger de grão de bico!");

                            break;

                        case Opcao.Quinoa:
                            Console.WriteLine(" Você escolheu burger de quinoa!");
                            break;

                        case Opcao.Lentilha:
                            Console.WriteLine(" Você escolheu burger de lentilha!");
                            break;

                        case Opcao.BatataQv:
                            Console.WriteLine(" Você escolheu batata frita rústica com queijo vegetal!");
                            break;

                        case Opcao.BatataP:
                            Console.WriteLine(" Você escolheu batata frita rústica com páprica!");
                            break;

                        case Opcao.Combo1:
                            Console.WriteLine(" Você escolheu burger de grão de bico + batata rústica com queijo vegetal!");
                            break;

                        case Opcao.Combo2:
                            Console.WriteLine(" Você escolheu burger de grão de bico + batata rústica com páprica!");
                            break;

                        case Opcao.Combo3:
                            Console.WriteLine(" Você escolheu burger de quinoa + batata rústica com queijo vegetal!");
                            break;
                        case Opcao.Combo4:
                            Console.WriteLine(" Você escolheu burger de quinoa + batata rústica com páprica!");
                            break;
                        case Opcao.Combo5:
                            Console.WriteLine(" Você escolheu burger de lentilha + batata rústica com queijo vegetal!");
                            break;
                        case Opcao.Combo6:
                            Console.WriteLine(" Você escolheu burger de lentilha + batata rústica com páprica!");
                            break;
                        case Opcao.Mussarela:
                            Console.WriteLine(" Você escolheu uma pizza de mussarela!");
                            break;
                        case Opcao.Margherita:
                            Console.WriteLine(" Você escolheu uma pizza de margherita!");
                            break;

                        default:
                            Console.WriteLine("Opção Inválida!");
                            break;
                    }

                    Console.WriteLine("\n Algo mais? ");
                    Console.WriteLine("Selecione mais um lanche ou digite 0 para sair");
                    Console.ReadLine();
                }

                Console.WriteLine("Sua refeição paga outra refeição. Obrigado!");

                Console.ReadKey();
            }
        }
    }
}
