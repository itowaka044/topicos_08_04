using System;

namespace Exercises;

public class Aluno
{
    private static int MatriculaIncremento;
    private int Matricula {set;get;}
    private string? Nome {set;get;}
    private Endereco? Endereco {get;set;}

    public Aluno(string nome, Endereco endereco){
        MatriculaIncremento++;
        Matricula = MatriculaIncremento;
        Nome = nome;
        Endereco = endereco;
    }

    public void ExibirDados(){
        System.Console.WriteLine($"nome: {Nome}\nmatricula: {Matricula}\n");
        Endereco.ExibirDados();
    }

}
