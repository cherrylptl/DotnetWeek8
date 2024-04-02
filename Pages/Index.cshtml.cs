using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace week8.Pages;

public class IndexModel : PageModel
{
    public string welcomeMessage = "This is New DotNet WebApp";
    public string header = "Welcome to User Feedback";
    public List<User> users;
    public string todatTime = DateTime.Now.ToLongTimeString();
    public string todayDate = DateTime.Now.ToLongDateString();

    public User? user;

    private readonly ILogger<IndexModel> _logger;

    private readonly FeedBackDBContext _feedBackDBContext;
    public IndexModel(ILogger<IndexModel> logger, FeedBackDBContext feedBackDBContext)
    {
        _logger = logger;
        _feedBackDBContext = feedBackDBContext;
    }

    public void OnGet()
    {
        // users = UserRepositoryJSON.GetUsers();
        users = _feedBackDBContext.User.ToList();
    }

    public void OnPost(User user)
    {
        Console.WriteLine("On Post");
    }
}

public class User
{
    public int ID { get; set; }

    [Required(ErrorMessage = "Student UserName is required")]
    public required string UserName { get; set; }

    [Required(ErrorMessage = "Student UserEmail is required"), RegularExpression("[A-Za-z0-9]+@conestogac\\.on\\.ca", ErrorMessage = "Please provide your college email address")]
    public required string UserEmail { get; set; }

    [Required(ErrorMessage = "Student UserFeedbackMessage is required")]
    public required string UserFeedbackMessage { get; set; }

    [Required(ErrorMessage = "Student Phone Number is required"), RegularExpression("^\\d{3}-\\d{3}-\\d{4}", ErrorMessage = "Please provide valid phone number")]

    public required string UserPhoneNumber { get; set; }

}