using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv07MaquinaDeCafe
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Bem-vindos a cafeteria da Camis");
            Console.WriteLine("Aqui você encontra diversos cafés");



            int opcao;
            Console.WriteLine("Para comprar o seu café");
            Console.WriteLine("Digite o número que você quer");
            
            Console.WriteLine("1- Café expresso – R$ 5,00");
            Console.WriteLine("2- Capuccino – R$ 4,00");
            Console.WriteLine("3- Mocaccino – R$ 6,00");
            Console.WriteLine("4- Água quente – R$ 3,00");
            opcao=int.Parse(Console.ReadLine());

            if (opcao != 1 &&  opcao != 2 && opcao != 3 && opcao != 4)
            {
                Console.WriteLine("Opção invalida");
                Main(null);
            }

            if(opcao == 1)
            {
                Console.WriteLine("Você escolheu Café Expresso");
            }
            if (opcao == 2)
            {
                Console.WriteLine("Você escolheu Capuccino");
            }
            if (opcao == 3)
            {
                Console.WriteLine("Você escolheu Mocaccino");
            }
            if (opcao == 4)
            {
                Console.WriteLine("Você escolheu Agua quente");
            }
           



            int opcaoPagar;
            Console.WriteLine("Qual a sua forma de pagamento");
            Console.WriteLine("1--Cartão de crédito");
            Console.WriteLine("2--Debito");
            Console.WriteLine("3--Pix");
            Console.WriteLine("4--Dinheiro");
            opcaoPagar = int.Parse(Console.ReadLine());

            //Console.WriteLine("Forma de pagamento foi a opção"+opcaoPagar);

            if(opcaoPagar == 1 || opcaoPagar ==2)
            {
                Console.WriteLine("Insira o cartão ou aproxime");
            }
            if (opcaoPagar == 3)
            {
                Console.WriteLine("Pague pelo QR Code");
            }
            if (opcaoPagar == 4)
            {
                Console.WriteLine("Deposite o valor");
            }
            while (true)
            {
                double valor;
                valor = double.Parse(Console.ReadLine());
                Console.WriteLine("O valor " + valor);
                if (valor < 5|| valor < 4|| valor < 6|| valor <3)
                {
                    Console.WriteLine("Saldo insuficiente");
                }
                

            }

            Console.ReadKey();


        }
    }
}
