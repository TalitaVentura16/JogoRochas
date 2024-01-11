/**
*  Esta classe representa os personagens que compoem o jogo. 
* Cotem informacoes como nome, habilidade e alianca. 
*/

public class Personagem 
{
    /// <summary>
    /// obtem ou define nome do personagem
    /// </summary>
    public string Nome { get; set; }
    
    /// <summary>
    /// obtem  ou define as habilidades do personagem
    /// </summary>
    public string Habilidades { get; set; }

    /// <summary>
    /// Obtem uma breve biografia do personagem
    /// </summary>
    public string Biografia { get; set; }

    /// <summary>
    /// obtem o campo de estudo do personagem, este campo tambem ira
    /// definir a rota que ele ira tracar na jogo, por enquanto defini
    /// geomorfologia, mineralogia, climatologia e pedologia. O jogo todo 
    /// vai ser focado em geografia, e o jogador podera defini o seu 
    /// Dominio Elemental que se trata do campo de conhecimento que ele 
    /// pertencera. 
    /// </summary>
    public string DominioElemental { get; set; }

    /// <summary>
    /// Construtor da classe personagem.
    /// </summary>
    /// <param name="nome">Nome do personagem. </param>
    /// <param name="habilidade">Habilidades que o personagem possui. </param>
    /// <param name="biografia">A breve biografia do personagem. </param>
    /// <param name="dominio">Campo conhecimento, sendo geomorfologia, mineralogia, climatologia e pedologia. </param>


    public Personagem(string nome, string habilidades, string biografia, string dominio) 
    {
        Nome = nome;
        Habilidades = habilidade;
        Biografia = biografia;
        DominioElemental = dominio;
    }

}