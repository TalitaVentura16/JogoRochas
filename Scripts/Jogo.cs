using System;
using UnityEngine;

namespace JogoRochas.Scripts
{
    public class Jogo
    {
        public void MensagemBoasVindas()
        {
            Console.WriteLine("Bem-vindo ao mundo das rochas, meu destemido aventureiro!");
        }

        void ExibirSinopse()
        {
        }

        public static void Main(string[] args)
        {
            Jogo jogo = new Jogo();
            jogo.MensagemBoasVindas();

            Console.WriteLine("Bem-vindo ao mundo das rochas, meu destemido aventureiro!");
            Console.Write("Qual o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Agora, informe o seu gênero: 1 - aventureiro, 2 - aventureira.");
            string genero = Console.ReadLine().ToLower();

            switch (genero)
            {
                case "1":
                    Console.WriteLine($"Bem-vindo {nome}!");
                    break;
                case "2":
                    Console.WriteLine($"Bem-vinda {nome}!");
                    break;
                default:
                    Console.WriteLine($"Gênero não reconhecido para {nome}.");
                    break;
            }
            Console.WriteLine("\nAgora, vamos conhecer a história do jogo:");
            jogo.ExibirSinopse();
        }
    }
}