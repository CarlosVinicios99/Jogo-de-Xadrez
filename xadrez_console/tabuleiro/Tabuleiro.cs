namespace tabuleiro
{
    class Tabuleiro
    {
        private Peca[,] _pecas;
        public int linhas {get; set;}
        public int colunas {get; set;}

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            this._pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return _pecas[linha, coluna];
        }

        public Peca peca(Posicao pos)
        {
            validarPosicao(pos);
            return _pecas[pos.linha, pos.coluna];
        }

        public bool existePeca(Posicao pos)
        {
           validarPosicao(pos);
           return peca(pos) != null;
        }

        public void ColocarPeca(Peca peca, Posicao pos)
        {
            if(existePeca(pos))
            {
                throw new TabuleiroException("Ja Existe uma Peca Nesta Posicao!");
            }

            else
            {
                _pecas[pos.linha, pos.coluna] = peca;
                peca.posicao = pos;
            }         
        }

        public bool posicaoValida(Posicao pos)
        {
            if(pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos)
        {
            if(!posicaoValida(pos))
            {
                throw new TabuleiroException("Posicao Invalida!");
            }
        }
    }
}