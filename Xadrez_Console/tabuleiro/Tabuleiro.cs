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
    }
}