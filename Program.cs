using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_num6_pg55
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome = "";
            int sexo = 0;
            int idade = 0;
            int time = 0;
            string opcao = "1";
            int galo = 0;
            int cruza = 0;
            int flazin = 0;
            int c = 0;
            int outr = 0;
            int fem = 0;
            int mas = 0;
            int flu = 0;
            int tot = 0;
            int fegalo = 0;
            int fla30 = 0;
            do
            {
                tot++;
                Console.WriteLine("Digite o Seu Nome:");
                nome = Console.ReadLine();


                Console.WriteLine("Digite o Seu Sexo (1 = F / 2 = M / 3 = GF):");
                sexo = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o Sua Idade:");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Escolha seu time Favorito:");
                Console.WriteLine("1-atletico");
                Console.WriteLine("2-cruzeiro");
                Console.WriteLine("3-flamengo");
                Console.WriteLine("4-corinthians");
                Console.WriteLine("5-outro");
                time = int.Parse(Console.ReadLine());




                if ( time == 1   )
                {
                    galo++;
                }
                else if (time == 2)
                {
                    cruza++;
                }
                else if (time == 3)
                {
                    flazin++;
                }
                else if (time == 4)
                {
                    c++;
                }
                else
                {
                    outr++;
                }

                if (sexo == 1)
                {
                    fem++;
                }
                else if (time == 2)
                {
                    mas++;
                }
                else
                {
                    flu++;
                }

                if (sexo == 1)
                {
                    if (time == 1)
                    {
                        fegalo++;
                    }
                }
                if (idade < 31)
                {
                    if (time == 3)
                    {
                        fla30++;
                    }
                }









                Console.WriteLine("    -Continuar? ( -1 para finalizar )-    ");
                opcao = Console.ReadLine();
                Console.Clear();
            } while (opcao != "-1");
           

            Console.WriteLine("Pessoas que torcem pelo galo: " + (galo * 100 / tot + " % "  ));
            Console.WriteLine("Pessoas que torcem para outros times: " + (outr * 100 / tot + " % "));

            if (galo > c)
            {
                Console.WriteLine(" O galo é o preferido");
            }
            else
            {
                Console.WriteLine("O corintians é o preferido");
            }
            Console.WriteLine("Sexo F que torcem para o galo: " + fegalo);
            Console.WriteLine("Até 30 anos que torcem pro flazin: " + fla30);



            Console.ReadKey();

        }
    }
}
