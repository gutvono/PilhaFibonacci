namespace PilhaFibonacci
{
    internal class PilhaNumero
    {
        Numero? topo;
        int contador;

        public PilhaNumero()
        {
            this.Topo = null;
        }

        internal Numero? Topo { get => topo; set => topo = value; }

        public void Push(Numero n)
        {
            Numero? aux = this.topo;
            this.topo = n;
            n.SetAnterior(aux!);
            this.contador++;
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine($"Pilha vazia! Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                Numero? aux = this.Topo;
                do
                {
                    Console.WriteLine($"Posição na pilha: {this.contador} - Numero: {aux!.GetN()}");
                    this.contador--;
                    aux = aux.GetAnterior();
                } while (aux != null);
            }
        }

        bool IsEmpty()
        {
            if (this.topo == null) return true;
            else return false;
        }
    }
}
