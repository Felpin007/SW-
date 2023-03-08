namespace contabancaria;
class Contabancaria
{
    public string titular = "";
    public int saldo = 5000;

    public int Sacar(int quanto){
        return saldo -= quanto;
    }
    public int Depositar(int quanto){
        return saldo += quanto;
    }
    public void Exibir(){
        // Console.Write("O que você quer ver? 1 - titular, 2 - saldo " );
        Console.Write("O titular da conta é: " + titular + "\n");
        Console.Write("O saldo atual da conta é:" + saldo + " reais \n");
    }
}
