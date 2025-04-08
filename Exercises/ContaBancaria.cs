using System;

namespace Exercises;

public class ContaBancaria
{
    private static int NumeroIncremento;
    private int Numero {get;set;}
    private string? Titular {get;set;}
    private double Saldo {get;set;}

    public ContaBancaria(string titular){
        NumeroIncremento++;
        Numero = NumeroIncremento;
        Titular = titular;
        Saldo = 0;
    }

    public void Depositar(double valor){
        Saldo += valor;
    }

    public void Sacar(double valor){
        if(Saldo >= valor){
            Saldo -= valor;
        }
    }

    public void ExibirSaldo(){
        System.Console.WriteLine($"numero: {Numero}\ntitular: {Titular}\nsaldo: {Saldo}\n");
    }
}
