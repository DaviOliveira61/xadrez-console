using TabuleiroXadrez;
using TabuleiroXadrez.TBExceptions;
using XadrezConsole;
using Xadrez;

Console.Clear();
try
{
  Tabuleiro tb = new Tabuleiro(8, 8);
  tb.ColocarPeca(new Torre(tb, Cor.Magenta), new Posicao(0, 0));
  tb.ColocarPeca(new Torre(tb, Cor.Magenta), new Posicao(1, 3));
  tb.ColocarPeca(new Rei(tb, Cor.Magenta), new Posicao(0, 2));

  tb.ColocarPeca(new Torre(tb, Cor.Branco), new Posicao(5, 5));
  tb.ColocarPeca(new Torre(tb, Cor.Branco), new Posicao(3, 5));
  tb.ColocarPeca(new Rei(tb, Cor.Branco), new Posicao(7, 4));

  Tela.MostrarTela(tb);
}
catch (TabuleiroException te)
{
  Console.WriteLine(te.Message);
}