using System;

namespace Exercises;

public class Endereco
{

    private string? Rua {get;set;}
    private int Numero {get;set;}
    private string? Cidade {get;set;}

    public Endereco(string rua, int numero, string cidade){
        Rua = rua;
        Numero = numero;
        Cidade = cidade;
    }

    public void ExibirDados(){
        System.Console.WriteLine($"rua: {Rua}, {Numero}\ncidade: {Cidade}\n");
    }

}