namespace Avião;
class Avião
{
    public string modelo = "";
    public string cor = "";
    public string nome = "";
    public int velocidade;
    public int altitude;
    public void subir(){
        altitude++;
    }
    public void descer(){
        altitude--;
    }
    public void acelerar(){
        velocidade++;
    }
    public void desacelerar(){
        velocidade--;
    }
    public void exibir(){
        Console.Write("--------------Dados do avião--------------");
        Console.Write("Nome do avião:"+nome);
        Console.Write("Cor do avião:"+cor);
        Console.Write("Modelo:"+modelo);
        Console.Write("velocidade atual:"+velocidade);
        Console.Write("Altitude atual:"+altitude);
    }
    public void explodir(){
        Console.Write("BBOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOMMMMMMMMMMMMMMMMMMMMMMMMM!!!!!!!!!!!!!!");
    }

}
