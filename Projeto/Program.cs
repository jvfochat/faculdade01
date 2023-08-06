namespace Projetc1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] notasDoAluno = new double[5, 3];
            for (int aluno = 0; aluno < 5; aluno++)
            {
                Console.WriteLine($"Digite o {aluno + 1}: ");
                for (int nota = 0; nota < 3; nota++)
                {
                    Console.WriteLine($"Digete a{nota + 1} Nota: ");
                    notasDoAluno[aluno, nota] = double.Parse(Console.ReadLine());
                }
            }
            double maiorNota = notasDoAluno[0, 0];
            double menorNota = notasDoAluno[0, 0];
            int qtdePares = 0;
            int qtdeImpares = 0;
           
            for (int aluno = 0; aluno < 5; aluno++)
            {
                double somaDasNotas = 0;
                for (int notas = 0; notas < 3; notas++)
                {
                    double notaAtual = notasDoAluno[aluno, notas];
                    if (notaAtual > maiorNota)
                    {
                        maiorNota = notaAtual;
                    }
                    if (notaAtual < menorNota)
                    {
                        menorNota = notaAtual;
                    }
                    if (notaAtual % 2 == 0)
                    {
                        qtdePares++;
                    }
                    else qtdeImpares++;
                    somaDasNotas += notaAtual;
                }
                double mediaDoAluno = somaDasNotas / 3;
                Console.WriteLine($"Media do Aluno {aluno + 1}: {mediaDoAluno}");
            }

            Console.WriteLine("MaiorNota: " + maiorNota);
            Console.WriteLine("MenorNota: " + menorNota);
            Console.WriteLine("qtdeImpares: " + qtdeImpares);
            Console.WriteLine("qtdePares: " + qtdePares);


        }
    }
}
