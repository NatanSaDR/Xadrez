using EstudosOOProjetoXadrez.tabuleiro;

namespace EstudosOOProjetoXadrez.xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor){
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
