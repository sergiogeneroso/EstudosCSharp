using CSharpFundamentosPOO.ContentContext;
using CSharpFundamentosPOO.SubscriptionContext;

class Program
{
  static void Main(string[] args)
  {

    var articles = new List<Article>();
    articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
    articles.Add(new Article("Artigo sobre C#", "csharp"));
    articles.Add(new Article("Artigo sobre .NET", "dotnet"));

    foreach (var article in articles)
    {
      Console.WriteLine(article.Id);
      Console.WriteLine(article.Title);
      Console.WriteLine(article.Url);
    }

    var courseOOP = new Course("Artigo sobre OOP", "orientacao-objetos");
    var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
    var courseDotNet = new Course("Artigo sobre .NET", "dotnet");

    var careers = new List<Career>();
    var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
    var CareerItem2 = new CareerItem(3, "Aprenda .NET", "", null);
    var CareerItem1 = new CareerItem(1, "Aprenda OOP", "", courseOOP);
    var CareerItem3 = new CareerItem(2, "Aprenda C#", "", courseCsharp);

    careerDotnet.Items.Add(CareerItem2);
    careerDotnet.Items.Add(CareerItem3);
    careerDotnet.Items.Add(CareerItem1);
    careers.Add(careerDotnet);

    foreach (var career in careers)
    {
      Console.WriteLine(career.Title);
      foreach (var item in career.Items.OrderBy(x => x.Order))
      {
        Console.WriteLine($"{item.Order} - {item.Title}");
        Console.WriteLine(item.Course?.Title);
        Console.WriteLine(item.Course?.Level);

        foreach (var notification in item.Notifications)
        {
          Console.WriteLine($"{notification.Property} - {notification.Message}");
        }
      }

      var payPalSubscription = new PayPalSubscription();
      var student = new Student();
      student.CreateSubscription(payPalSubscription);
    }


  }
}