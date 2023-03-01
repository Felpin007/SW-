namespace Avião;
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        Avião josefo = new Avião();
        josefo.cor = "laranja";
        josefo.modelo = "AAAAAAA";
        josefo.nome = "josefo";
        josefo.acelerar();
        josefo.subir();
        josefo.exibir();
        josefo.explodir();
    }
}
