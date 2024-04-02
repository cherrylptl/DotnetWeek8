using Microsoft.AspNetCore.Mvc.RazorPages;
using week8.Pages;


public class SuccessModel : PageModel
{
    private readonly ILogger<SuccessModel> _logger;

    public User user;

    public SuccessModel(ILogger<SuccessModel> logger)
    {
        _logger = logger;
    }

    public void OnGet(User _user)
    {
        user = _user;
    }

}