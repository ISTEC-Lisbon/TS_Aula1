using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS_Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region VAR INTRODUÇÃO

            //int idade;
            //float salario;
            //string nome;
            //char ch;
            //bool flag;
            //DateTime bday, hoje;

            #endregion



            try
            {
                #region INTRODUÇÃO

                //Console.Write("O seu nome: ");
                //nome = Console.ReadLine();
                //Console.WriteLine("Está tudo {0}?", nome);
                //Console.WriteLine("Idade: ");
                //idade = int.Parse(Console.ReadLine());
                //Console.WriteLine("A idade é: {0}", idade);
                //salario = 555.75f;
                //Console.WriteLine("O salário é: {0:C}", salario);
                //ch = 'a';
                //Console.WriteLine("Char: {0}", ch);
                //flag = true;
                //Console.WriteLine("Boolean: {0}", flag);
                //bday= DateTime.Parse("1997-12-16");
                //hoje=DateTime.Now;
                //Console.WriteLine("BDay: {0:D}, Dia de Hoje: {1:d}", bday, hoje);

                //Console.Write("a: ");
                //int alfa = Console.ReadLine();
                //Console.WriteLine("Introduziu {0}", alfa);

                //Console.ReadLine();

                #endregion

                #region CAR RACE

                Carro[] carros = new Carro[]
                {
                    new Carro("Seat", "Ibiza"),
                    new Carro("Toyota", "Land Cruiser"),
                    new Carro(marca:"Toyota", modelo:"Yaris")
                };

                //Carro myCar = new Carro("Seat", "Ibiza") { Velocidade = 188 }; //default constructor


                //Carro myCar2 = new Carro("Toyota", "Land Cruiser") { Velocidade = 210 }; //default constructor

                //Viatura myCar = new Viatura(); //constructor overload

                //myCar.Ver();
                //myCar2.Ver();

                for (int i = 0; i < carros.Length; i++)
                {
                    carros[i].Acelerar();
                    System.Threading.Thread.Sleep(2000); //pausa 2segundos
                }

                Carro vencedor = carros[0];
                foreach (Carro p in carros)
                {
                    vencedor = (p.Distancia > vencedor.Distancia) ? p : vencedor;
                }

                Console.WriteLine("\nVencedor:");
                vencedor.Ver();

                //Morte dos carros
                //myCar = null;
                //GC.Collect();
                //GC.WaitForPendingFinalizers();
                //Console.WriteLine("\nTudo Limpo!");

                #endregion


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\nOOOH! WHAT A RACE!");
                Console.ReadLine();
            }


        }
    }
}
