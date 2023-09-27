using TabuleiroXadrez;

namespace XadrezConsole
{
    public class Tela
    {
      public static void MostrarTela(Tabuleiro tabuleiro)
      {
        for (int x = 0; x < tabuleiro.Linhas; x++)
        {
          Console.Write(8 - x + " ");
          for(int y = 0; y < tabuleiro.Colunas; y++)
          {
            if(tabuleiro.Peca(x, y) == null)
            {
              Console.Write("- ");
            }
            else
            {
              MostrarPeca(tabuleiro.Peca(x, y));
              Console.Write(" ");
            }
          }
          Console.WriteLine();
        }
        Console.WriteLine("  a b c d e f g h");
      }

      public static void MostrarPeca(Peca peca)
      {
        if(peca.Cor == Cor.Branco)
        {
          Console.Write(peca);
        }
        else
        {
          ConsoleColor aux = Console.ForegroundColor;
          Console.ForegroundColor = ConsoleColor.Magenta;
          Console.Write(peca);
          Console.ForegroundColor = aux;
        }
      }
    }
}
