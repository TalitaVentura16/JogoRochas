
using UnityEngine;
using

/// <summary>
/// Arquivo: Play.cs
/// Descricao: Este script representa o ponto de entrada e a logica principal do jogo.
/// Aqui, sao definidos os metodos Start() e Update(), que sao executados durante a inicialização do jogo e a cada quadro, respectivamente.
/// </summary>
public class Play : MonoBehaviour
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
