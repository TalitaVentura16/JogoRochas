using System;
namespace JogoRochas.Assets{
    public class Texto
    {
        static void Main()
        {
            Texto texto = new Texto();
            texto.MensagemBoasVindas();
        }
        public void MensagemBoasVindas()
        {
            Console.WriteLine(@"
    █▄▄ █▀▀ █▀▄▀█ ▄▄ █░█ █ █▄░█ █▀▄ █▀█   ▄▀█ █▀█   █▀▄▀█ █░█ █▄░█ █▀▄ █▀█   █▀▄ ▄▀█ █▀   █▀█ █▀█ █▀▀ █░█ ▄▀█ █▀ █
    █▄█ ██▄ █░▀░█ ░░ ▀▄▀ █ █░▀█ █▄▀ █▄█   █▀█ █▄█   █░▀░█ █▄█ █░▀█ █▄▀ █▄█   █▄▀ █▀█ ▄█   █▀▄ █▄█ █▄▄ █▀█ █▀█ ▄█ ▄");
        }

        void ExibirSinopse()
        {
            Console.WriteLine("**\"As Crônicas da Geologia Fantástica\"**");
            Console.WriteLine("Em um mundo mágico onde as rochas escondem segredos ancestrais e a terra pulsa com energia desconhecida, você é um destemido aventureiro em busca de conhecimento e aventura. Neste reino encantado, a Geologia é uma ciência poderosa e os minerais possuem propriedades místicas.");
            Console.WriteLine("A jornada começa quando você descobre um antigo livro que narra a lenda das rochas mágicas, capazes de conceder habilidades inimagináveis aos seus portadores. Inspirado pela ideia de desvendar os segredos ocultos sob a superfície da Terra, você parte em busca dessas pedras preciosas, enfrentando perigos e desafios pelo caminho.");
            Console.WriteLine("Ao longo da sua jornada, você encontrará criaturas místicas da geologia, como o Gigante de Granito, o Dragão do Diamante e o Elemental da Rocha, que protegem os tesouros geológicos com fúria e astúcia. Para obter o poder das rochas mágicas, você precisará compreender as características geológicas únicas de cada região e enfrentar testes de habilidade e conhecimento.");
            Console.WriteLine("No seu percurso, você encontrará sábios geólogos que compartilharão seu vasto conhecimento sobre a terra e suas formações. Aprenderá sobre os processos da geomorfologia, a história geológica do mundo e a influência dos minerais na magia dessa terra encantada.");
            Console.WriteLine("Aventuras emocionantes, amizades inesperadas e descobertas surpreendentes aguardam você nas Crônicas da Geologia Fantástica. Aprenda a interpretar pistas geológicas para desvendar enigmas antigos e enfrentar desafios épicos. Prove-se como um verdadeiro aventureiro da geologia e desvende o destino místico que aguarda aqueles que entendem os segredos da Terra.");
            Console.WriteLine("Neste mundo de magia e conhecimento, apenas os mais corajosos e sábios geólogos serão capazes de alcançar o poder supremo das rochas mágicas e desvendar a verdadeira essência da Geologia Fantástica!");
        }
    }
}