﻿class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao} segundos");

        if (disponivel)
        {
            Console.WriteLine("Disponível para streaming");
        }
        else
        {
            Console.Write("Indisponível para streamings");
        }
    }
}

