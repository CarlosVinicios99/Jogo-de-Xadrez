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
    }
}