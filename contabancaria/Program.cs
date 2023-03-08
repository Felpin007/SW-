namespace contabancaria;
class Program
{
    static void Main(string[] args)
    {
        Contabancaria Felipe = new Contabancaria();
        Felipe.titular = "Felipe";
        Felipe.saldo = 32;
        Felipe.Exibir();
        Felipe.Sacar(10);
        Felipe.Exibir();
        Felipe.Depositar(10);
        Felipe.Exibir();
    }
}
