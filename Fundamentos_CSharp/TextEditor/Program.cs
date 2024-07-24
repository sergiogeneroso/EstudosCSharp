using System.IO;

namespace TextEditor
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("Escolha uma opção:");
      Console.WriteLine("1. Abrir arquivo");
      Console.WriteLine("2. Criar novo arquivo");
      Console.WriteLine("0. Sair");

      short option = short.Parse(Console.ReadLine());

      switch (option)
      {
        case 0: Environment.Exit(0); break;
        case 1: OpenFile(); break;
        case 2: CreateFile(); break;
        default: Menu(); break;
      }
    }

    static void OpenFile()
    {
      Console.Clear();
      Console.WriteLine("Qual caminho do arquivo?");
      string path = Console.ReadLine();

      using (var file = new StreamReader(path))
      {
        string text = file.ReadToEnd();
        Console.WriteLine(text);
      }

      Console.ReadLine();
      Menu();
    }

    static void CreateFile()
    {
      Console.Clear();
      Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
      Console.WriteLine("-----------------------------");
      string text = "";

      do
      {
        text += Console.ReadLine();
        text += Environment.NewLine;
      }
      while (Console.ReadKey().Key != ConsoleKey.Escape);

      SaveFile(text);
    }

    static void SaveFile(string text)
    {
      Console.Clear();
      Console.WriteLine("Qual caminho completo para salvar o arquivo? ");
      var path = Console.ReadLine();

      using (var file = new StreamWriter(path))
      {
        file.Write(text);
      }

      Console.WriteLine($"Arquivo {path} salvo com sucesso!");

      Console.ReadLine();

      Menu();
    }
  }
}