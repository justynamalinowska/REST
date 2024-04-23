using ApplicationCore.Interfaces.UserService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages;

public class Summary : PageModel
{   
    private readonly IQuizUserService _userService;
    public Summary(IQuizUserService userService)
    {
        _userService = userService;
    }
    [BindProperty(SupportsGet = true)] public int CorrectAnswerCount { get; set; }

    [BindProperty(SupportsGet = true)] public int TotalQuestions { get; set; }
    public float Percentage { get; set; }
    public void OnGet(int quizId, int userId)
    {
        CorrectAnswerCount = _userService.CountCorrectAnswersForQuizFilledByUser(quizId, userId);
        TotalQuestions = _userService.FindQuizById(quizId).Items.Count();
        Percentage = ((float)CorrectAnswerCount / TotalQuestions) * 100;
    }
}