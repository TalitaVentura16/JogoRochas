/**
* A Classe apresenta as informacoes sobre o jogado
* Nela constam o Nome, Genero e a Escolha do Dominio Elemental
**/

public class Jogador 
{
    /// <summary>
    /// Obtem e define o nome do jogador 
    /// </summary>
    public string Nome { get; set;}

    /// <summary>
    /// Obtem e define o genero do jogador, por enquanto serao 
    /// definidos 2 generos, masculino e feminino. Futuramente 
    /// pretendo inserir um genero neutro, mas por enquanto nao sei muito bem 
    /// como fazer isso.
    /// </summary>
    public string Genero { get; set;}

    /// <summary>
    /// Obtem o Dominio Elemental que o jogador vai escolher, 
    /// conforme a escolha do dominio elemental o jogo sofre alteracoes
    /// como forma de deixar o jogo mais divertido
    /// </summary>
    public string DominioElemental { get; set; }

    /// <summary>
    /// Construtor da Classe Jogador.
    /// <summary/>
    /// <param name="nome">Nome do jogador. </param>
    /// <param name="genero">Genero do jogador. </param>
    /// <param name="dominio">Dominio elemental escolhido pelo jogador. </param>
    
    public Jogador(string nome, string genero, string dominio)
    {
        Nome = nome;
        Genero = genero;
        DominioElemental = dominio;
    }

}