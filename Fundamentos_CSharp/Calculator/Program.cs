namespace Caculator
{

  enum EPosicaoValor
  {
    Primeiro,
    Segundo
  }
  class Program
  {
    static float PrimeiroValor = 0;
    static float SegundoValor = 0;
    static float Resultado = 0;
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("Escolha a operação desejada: ");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Multiplicação");
      Console.WriteLine("4 - Divisão");

      short opcao = short.Parse(Console.ReadLine());

      switch (opcao)
      {
        case 1:
          Soma();
          break;
        case 2:
          Subtracao();
          break;
        case 3:
          Multiplicacao();
          break;
        case 4:
          Divisao();
          break;
        default:
          Console.WriteLine("ERRO: Opção inválida.");
          Console.ReadLine();
          Menu();
          break;
      }

      Console.WriteLine("Deseja realizar outra operação? (S/N)");
      string continuar = Console.ReadLine().ToUpper();

      if (continuar == "S")
        Menu();
      else
        System.Environment.Exit(0);
    }

    static void Soma()
    {
      PrimeiroValor = AtribuirValor(EPosicaoValor.Primeiro);
      SegundoValor = AtribuirValor(EPosicaoValor.Segundo);

      Resultado = PrimeiroValor + SegundoValor;

      ExibirResultado();
    }

    static void Subtracao()
    {
      PrimeiroValor = AtribuirValor(EPosicaoValor.Primeiro);
      SegundoValor = AtribuirValor(EPosicaoValor.Segundo);

      Resultado = PrimeiroValor - SegundoValor;

      ExibirResultado();
    }

    static void Multiplicacao()
    {
      PrimeiroValor = AtribuirValor(EPosicaoValor.Primeiro);
      SegundoValor = AtribuirValor(EPosicaoValor.Segundo);

      Resultado = PrimeiroValor * SegundoValor;

      ExibirResultado();
    }

    public static void Divisao()
    {

      PrimeiroValor = AtribuirValor(EPosicaoValor.Primeiro);
      SegundoValor = AtribuirValor(EPosicaoValor.Segundo);

      ValidarDivisor();

      Resultado = PrimeiroValor / SegundoValor;

      ExibirResultado();
    }
    static float AtribuirValor(EPosicaoValor posicaoValor)
    {
      Console.WriteLine("Favor informar o " + posicaoValor + " número para a operação: ");

      try
      {
        return float.Parse(Console.ReadLine());
      }
      catch (Exception)
      {
        Console.WriteLine("ERRO: Valor informado inválido.");
        return AtribuirValor(posicaoValor);
      }
    }

    static void ValidarDivisor()
    {
      do
      {
        Console.WriteLine("ERRO: Não é possível dividir por zero.");
        SegundoValor = AtribuirValor(EPosicaoValor.Segundo);
      } while (SegundoValor == 0);
    }

    static void ExibirResultado()
    {
      Console.WriteLine($"Resultado: {Resultado}");
    }


  }
}