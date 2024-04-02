using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace week8.Pages;

public class FeedbackModel : PageModel
{

    public string welcomeMessage = "This is New DotNet WebApp";
    public string todatTime = DateTime.Now.ToLongTimeString();
    public string todayDate = DateTime.Now.ToLongDateString();

    public User? user;
    // public Student student;

    private readonly FeedBackDBContext _feedBackDBContext;
    private readonly ILogger<FeedbackModel> _logger;

    public FeedbackModel(ILogger<FeedbackModel> logger, FeedBackDBContext feedBackDBContext)
    {
        _logger = logger;
        _feedBackDBContext = feedBackDBContext;
    }

    public void OnGet()
    {

    }

    public IActionResult OnPost(User user)
    {
        // Console.WriteLine("On Post Feedback");
        // Console.WriteLine("Name: {0}", user.UserName);
        // Console.WriteLine("Email: {0}", user.UserEmail);
        // Console.WriteLine("FeedBack Message   sds: {0}", user.UserFeedbackMessage);

        if (!ModelState.IsValid)
        {
            return Page();

        }
        // UserRepositoryJSON.AddUser(user);
        _feedBackDBContext.User.Add(user);
        _feedBackDBContext.SaveChanges();
        return RedirectToPage("success", user);
    }
}
