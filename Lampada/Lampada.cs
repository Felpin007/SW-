namespace Lampada;
class Classelampada
{   
    public bool ligada;
    public double potencia;

    public void ligar(){
        ligada = true;  
    }
    public void desligar(){
        ligada = false;
    }
    public bool estaligada(){
        return ligada;
    }
}
