using System;

namespace Exercises;

public class Tabuada
{

    private int Numero {get;set;}

    public Tabuada(int numero){
        Numero = numero;
    }

    public void ExibirTabuada(){
        for(int i = 1; i <= 10; i++){
            System.Console.WriteLine(Numero * i);
        }
    }

}
