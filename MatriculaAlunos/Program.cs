using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization.Advanced;

namespace MatriculaAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {  
           string resposta = "SIM";
           int adm = 0;
           int ds = 0;
           int meca = 0;
           int edf = 0;
           int cont = 0;

           while (resposta == "SIM")
            {
                Console.WriteLine("Qual curso você deseja matricular o aluno? ");
                string curso = Console.ReadLine().ToUpper();

                switch (curso)
                {
                    case "DS":
                        if (ds <=5)
                        {
                            Console.WriteLine("Qual é nome do aluno: ");
                            string nome = Console.ReadLine();
                            Console.WriteLine("Qual é a data de nascimento do aluno? ");
                            string data = Console.ReadLine();
                            Console.WriteLine("Qual é o cpf do aluno? ");
                            long cpf = long.Parse(Console.ReadLine());
                            Console.WriteLine("Qual é o nome do responsável? ");
                            string responsavel = Console.ReadLine();
                            Console.WriteLine("Qual é o cpf do responsável? ");
                            long cpfresponsavel = long.Parse(Console.ReadLine());

                            ds += 1;
                            cont += 1;

                            Console.WriteLine("Parabéns! O aluno foi matriculado!");
                        }
                        else if (ds>5)
                        {
                            Console.WriteLine("O curso de desenvolvimento de sistemas não tem mais vagas disponíveis. Tente novamente no p´róximo semestre.");
                        }
                        break;

                    case "ADM":
                        if (adm <= 5)
                        {
                            Console.WriteLine("Qual é nome do aluno: ");
                            string nome = Console.ReadLine();
                            Console.WriteLine("Qual é a data de nascimento do aluno? ");
                            string data = Console.ReadLine();
                            Console.WriteLine("Qual é o cpf do aluno? ");
                            long cpf = long.Parse(Console.ReadLine());
                            Console.WriteLine("Qual é o nome do responsável? ");
                            string responsavel = Console.ReadLine();
                            Console.WriteLine("Qual é o cpf do responsável? ");
                            long cpfresponsavel = long.Parse(Console.ReadLine());

                            adm += 1;
                            cont += 1;


                            Console.WriteLine("Parabéns! O aluno foi matriculado!");

                        }
                        else if (adm > 5)
                        {
                            Console.WriteLine("O curso de administração não tem mais vagas disponíveis. Tente novamente no p´róximo semestre.");
                        }
                        break;

                    case "MECA":
                        if (meca <= 5)
                        {
                            Console.WriteLine("Qual é nome do aluno: ");
                            string nome = Console.ReadLine();
                            Console.WriteLine("Qual é a data de nascimento do aluno? ");
                            string data = Console.ReadLine();
                            Console.WriteLine("Qual é o cpf do aluno? ");
                            long cpf = long.Parse(Console.ReadLine());
                            Console.WriteLine("Qual é o nome do responsável? ");
                            string responsavel = Console.ReadLine();
                            Console.WriteLine("Qual é o cpf do responsável? ");
                            long cpfresponsavel = long.Parse(Console.ReadLine());

                            meca += 1;
                            cont += 1;


                            Console.WriteLine("Parabéns! O aluno foi matriculado!");

                        }
                        else if (meca > 5)
                        {
                            Console.WriteLine("O curso de mecatrônica não tem mais vagas disponíveis. Tente novamente no p´róximo semestre.");
                        }
                        break;

                    case "EDF":
                        if (edf <= 5)
                        {
                            Console.WriteLine("Qual é nome do aluno: ");
                            string nome = Console.ReadLine();
                            Console.WriteLine("Qual é a data de nascimento do aluno? ");
                            string data = Console.ReadLine();
                            Console.WriteLine("Qual é o cpf do aluno? ");
                           long cpf = long.Parse(Console.ReadLine());
                            Console.WriteLine("Qual é o nome do responsável? ");
                            string responsavel = Console.ReadLine();
                            Console.WriteLine("Qual é o cpf do responsável? ");
                            long cpfresponsavel = long.Parse(Console.ReadLine());

                            Console.WriteLine("Parabéns! O aluno foi matriculado!");

                            edf += 1;
                            cont += 1;


                        }
                        else if (edf > 5)
                        {
                            Console.WriteLine("O curso de edificações não tem mais vagas disponíveis. Tente novamente no p´róximo semestre.");
                        }
                        break;
                    
                }

                Console.WriteLine( +cont +" alunos foram matriculados.");
                Console.WriteLine(+ds + " foram matriculados no curso de desenvolvimento de sistemas ");
                Console.WriteLine(+adm + " foram matriculados no curso de administração ");
                Console.WriteLine(+meca + " foram matriculados no curso de mecatrônica ");
                Console.WriteLine(+edf + " foram matriculados no curso de edificações ");
                Console.WriteLine("Deseja matricular outro aluno? ");
                resposta = Console.ReadLine().ToUpper();

                Console.ReadKey();

            }
            

        }
    }
}
