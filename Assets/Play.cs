
/// <summary>
/// Arquivo: Play.cs
/// Descricao: Este script representa o ponto de entrada e a logica principal do jogo.
/// Aqui, sao definidos os metodos Start() e Update(), que sao executados durante a inicializacao 
/// do jogo e a cada quadro, respectivamente.
/// </summary>

using System;

namespace JogoRochas.Scripts
{
    public class Play
    {
        Texto texto;

        void Start()
        {
            // Inicializando a classe de texto
            texto = new Texto();

            // Exibe a MensagemBoasVindas()
            texto.MensagemBoasVindas();
        }

        void Update()
        {
        }
    }
}
