using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public string Message { get; set; }
        //handle methods that respond to HTTP requests, e.x onGet, onPut, onPost
        public void OnGet()
        {
            Message = "Hello world";
        }
    }

}
