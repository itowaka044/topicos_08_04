using System;

namespace Exercises;

public class Livro
{
    private string? Titulo {get; set;}
    private string? Autor {get; set;}
    private int NumeroPaginas {get; set;}


    public Livro(string titulo, string autor, int numeroPaginas){
        Titulo = titulo;
        Autor = autor;
        NumeroPaginas = numeroPaginas;
    }

    public void ExibirDestalhes(){
        System.Console.WriteLine($"titulo: {Titulo}\nautor: {Autor}\nnumero de paginas: {NumeroPaginas}\n");
    }
}
