namespace EditorHtml
{
  public static class Menu
  {
    public static void Show()
    {
      Console.Clear();
      var systemBackgroundColor = Console.BackgroundColor;
      var systemForegroundColor = Console.ForegroundColor;

      Console.BackgroundColor = ConsoleColor.Blue;
      Console.ForegroundColor = ConsoleColor.Black;

      DrawScreen();
      WriteOptions();
      var option = short.Parse(Console.ReadLine());
      HandleMenuOption(option);

      Console.BackgroundColor = systemBackgroundColor;
      Console.ForegroundColor = systemForegroundColor;
    }

    public static void DrawScreen()
    {

      DrawColumns("+", "-", 30);

      for (int lines = 0; lines <= 10; lines++)
      {
        DrawColumns("|", " ", 30);
      }

      DrawColumns("+", "-", 30);

    }

    public static void DrawColumns(string borderColumn, string midColumn, int columns)
    {
      Console.Write(borderColumn);
      for (int i = 0; i <= columns; i++)
        Console.Write(midColumn);

      Console.Write(borderColumn);
      Console.Write("\n");
    }

    public static void WriteOptions()
    {
      Console.SetCursorPosition(3, 2);
      Console.WriteLine("Editor HTML");
      Console.SetCursorPosition(3, 3);
      Console.WriteLine("===========");
      Console.SetCursorPosition(3, 4);
      Console.WriteLine("Selecione uma opção abaixo");
      Console.SetCursorPosition(3, 6);
      Console.WriteLine("1 - Novo arquivo");
      Console.SetCursorPosition(3, 7);
      Console.WriteLine("2 - Abrir");
      Console.SetCursorPosition(3, 9);
      Console.WriteLine("X - Sair");
      Console.SetCursorPosition(3, 10);
      Console.Write("Opção: ");
    }

    public static void HandleMenuOption(short option)
    {
      switch (option)
      {
        case 1: Editor.Show(); break;
        case 2:
          Console.WriteLine("View");
          break;
        case 0: { Console.Clear(); Environment.Exit(0); break; }
        default: Show(); break;

      }
    }
  }
}