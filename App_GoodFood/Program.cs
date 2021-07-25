using System;
using System.Collections.Generic;

namespace AppGoodFood
{
    public enum Opcao
    {
        Burger_de_Grao_de_Bico = 1,
        Burger_de_Quinoa = 2,
        Burger_de_Lentilha = 3,
        Batata_com_Queijo = 4,
        Batata_com_paprica = 5,
        Burger_de_Grao_de_Bico_e_Batata_Rustica = 6,
        Burger_de_Grao_de_Bico_e_Batata_com_Paprica = 7,
        QuinoaBurger_e_Batata_Rustica = 8,
        QuinoaBurger_e_Batata_com_Paprica= 9,
        LentilhaBurger_e_Batata_Rustica = 10,
        LentilhaBurger_e_Batata_com_Paprica = 11,
        Pizza_Mussarela = 12,
        Pizza_Margherita = 13
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Bem-vindos ao restaurante comunitário: The Good Food! \n");
            Console.WriteLine(" Menu \n");

            List<string> Lanches = new List<string>();
            Lanches.Add(" 1-Hamburger de grão de bico");
            Lanches.Add(" 2-Hamburger de quinoa ");
            Lanches.Add(" 3-Hamburger de lentilha");
            Lanches.Add(" 4-Batata frita rústica com queijo vegetal");
            Lanches.Add(" 5-Batata frita rústica com páprica\n");
            Lanches.Add(" Combos:");
            Lanches.Add(" 6-Hamburger de grão de bico + batata frita rústica com queijo vegetal");
            Lanches.Add(" 7-Hamburger de grão de bico + batata frita rústica com páprica");
            Lanches.Add(" 8-Hamburger de quinoa + batata frita rústica com queijo vegetal");
            Lanches.Add(" 9-Hamburger de quinoa + batata frita rústica com páprica");
            Lanches.Add(" 10-Hamburger de lentilha + batata frita rústica com queijo vegetal");
            Lanches.Add(" 11-Hamburger de lentilha + batata frita rústica com páprica");
            Lanches.Add("\n Todos acompanham batata frita simples ou molho de tomate picante. \n");
            Lanches.Add(" Pizzas:");
            Lanches.Add(" 12-Mussarela");
            Lanches.Add(" 13-Margherita\n");
            
            foreach(var snack in Lanches)
            {
                Console.WriteLine(snack);
            }

           Console.WriteLine(" Digite o número de seu pedido");
            
           int OpcaoInput = int.Parse(Console.ReadLine());
           Console.WriteLine("Você escolheu " + ((Opcao)OpcaoInput).ToString() + "!");

             if (OpcaoInput > 13)
             {
                Console.WriteLine("Opção inválida! Por gentileza, reiniciar o aplicativo.");
                Environment.Exit(0);
                
             }

            Console.WriteLine("\nSua refeição paga outra refeição. Obrigado!\n");
            Console.WriteLine("Por sermos um restaurante comunitário servimos apenas um pedido por cliente");
            Console.ReadKey();


           
        }
    }
}
