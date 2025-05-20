using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorTest.Pages
{
    public class HomePageModel : PageModel
    {
        private readonly ILogger<HomePageModel> _logger;

        public HomePageModel(ILogger<HomePageModel> logger)
        {
            
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public int Count { get; set; }

        public void Add()
        {
            Count++;
        }
    }

}