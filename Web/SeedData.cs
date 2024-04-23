using ApplicationCore.Commons.Repository;
using ApplicationCore.Models.QuizAggregate;

namespace Web;

public static class SeedData
{
    public static void Seed(this WebApplication app)
    {
        IGenericRepository<Quiz, int>? quizRepo;
        using (var scope = app.Services.CreateScope())
        {
            var provider = scope.ServiceProvider;
            quizRepo = provider.GetService<IGenericRepository<Quiz, int>>();
            var quizItemRepo = provider.GetService<IGenericRepository<QuizItem, int>>();
            List<QuizItem> quizItems = new List<QuizItem>();

            var item1 = quizItemRepo?.Add(new QuizItem()
            {
                Id = 1,
                Question =
                    "What is the output of the following code snippet in C#?\nint x = 5;\nint y = 3;\nConsole.WriteLine(x + y * 2);\n",
                IncorrectAnswers = new List<string> { "13", "15", "17" },
                CorrectAnswer = "11"
            });

            var item2 = quizItemRepo?.Add(new QuizItem()
            {
                Id = 2,
                Question = "What does the acronym 'HTML' stand for?",
                IncorrectAnswers = new List<string>
                {
                    "High Tech Machine Learning", "Home Tool Management Language", "Hotel Transfer Markup Logic"
                },
                CorrectAnswer = "Hyper Text Markup Language"
            });

            var item3 = quizItemRepo?.Add(new QuizItem()
            {
                Id = 3,
                Question = "Which of the following is NOT a programming language?",
                IncorrectAnswers = new List<string> { "Python", "Java", "C++" },
                CorrectAnswer = "HTML"
            });

            var item4 = quizItemRepo?.Add(new QuizItem()
            {
                Id = 4,
                Question = "What does the 'SQL' acronym stand for?",
                IncorrectAnswers = new List<string>
                    { "Sequential Query Language", "Simple Query Language", "Standardized Query Language" },
                CorrectAnswer = "Structured Query Language"
            });

            quizItems.AddRange(new QuizItem[] { item1, item2, item3, item4 });

            var item5 = quizItemRepo?.Add(new QuizItem()
            {
                Id = 5,
                Question = "Which city is the capital of Poland?",
                IncorrectAnswers = new List<string> { "Krakow", "Gdansk", "Wroclaw" },
                CorrectAnswer = "Warsaw"
            });

            var item6 = quizItemRepo?.Add(new QuizItem()
            {
                Id = 6,
                Question = "What is the name of the longest river in Poland?",
                IncorrectAnswers = new List<string> { "Odra", "Warta", "Bug" },
                CorrectAnswer = "Vistula"
            });

            var item7 = quizItemRepo?.Add(new QuizItem()
            {
                Id = 7,
                Question = "Which historical event marked the beginning of World War II and involved Poland?",
                IncorrectAnswers = new List<string> { "Battle of Warsaw", "Polish-Soviet War", "Warsaw Uprising" },
                CorrectAnswer = "Invasion of Poland"
            });

            var item8 = quizItemRepo?.Add(new QuizItem()
            {
                Id = 8,
                Question = "What is the name of the famous salt mine located near Krakow, Poland?",
                IncorrectAnswers = new List<string> { "Bochnia Salt Mine", "Kłodawa Salt Mine", "Kopalnia Soli" },
                CorrectAnswer = "Wieliczka Salt Mine"
            });




            quizRepo?.Add(new Quiz()
            {
                Id = 1,
                Title = "Programing quiz",
                Items = new List<QuizItem>()
                {
                    item1,
                    item2,
                    item3,
                    item4
                }
            });
            quizRepo?.Add(new Quiz()
            {
                Id = 2,
                Title = "Poland Trivia Quiz",
                Items = new List<QuizItem>()
                {
                    item5,
                    item6,
                    item7,
                    item8
                }
            });
        }
    }
    
}