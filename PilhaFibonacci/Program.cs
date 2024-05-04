namespace PilhaFibonacci;

internal class Program
{
    private static void Main(string[] args)
    {
        int restart = 0, numero = 1, ultimo = 1, penultimo = -1, atual = 0;
        PilhaNumero pilha = new();

        do
        {
            ultimo = 1;
            penultimo = -1;
            atual = 0;

            do
            {
                Console.Clear();

                if (numero <= 0) Console.WriteLine("ERRO: Informe um número maior que 0");

                Console.Write("Informe quantos números da sequência fibonacci você deseja adicionar na pilha:");
                numero = int.Parse(Console.ReadLine());
            } while (numero <= 0);

            for (int i = 0; i < numero; i++)
            {
                atual = ultimo + penultimo;
                pilha.Push(new Numero(atual));
                penultimo = ultimo;
                ultimo = atual;
            }

            pilha.Print();

            Console.WriteLine("\nDeseja reiniciar o programa?");
            Console.WriteLine("1 - SIM");
            Console.WriteLine("0 - NAO");
            restart = int.Parse(Console.ReadLine());
            if (restart != 0) pilha = new();
        } while (restart != 0);
    }
}