using DominandoOB.ContentContext;
using DominandoOB.SubscriptionContext;
using System.Linq;

namespace DominandoOB {
    internal class Program {
        static void Main(string[] args) {


            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OPP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre .NET", "dotnet"));

            //foreach (var article in articles) {
            //    Console.WriteLine(article.Id);
            //    Console.WriteLine(article.Title);
            //    Console.WriteLine(article.Url);
            //}

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseAspnet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");
            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspnet);

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
            var careerCsharp = new Career("Desenvolvedor C#", "dev-csharp");
            var careerItem1 = new CareerItem(1, "Comece por aqui", "", null);
            var careerItem3 = new CareerItem(3, "Fundamentos OOP", "", courseOOP);
            var careerItem2 = new CareerItem(2, "Fundamentos DotNet", "", courseAspnet);

            careerDotnet.Items.Add(careerItem1);
            careerDotnet.Items.Add(careerItem3);
            careerDotnet.Items.Add(careerItem2);

            careers.Add(careerDotnet);
            careers.Add(careerCsharp);

            foreach (var career in careers) {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x=> x.Order)) {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications) {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }

            var payPalSubscription = new PayPalSubscription();
            var student = new Student();

            student.CreateSubscription(payPalSubscription);

            Console.ReadLine();

        }
    }
}