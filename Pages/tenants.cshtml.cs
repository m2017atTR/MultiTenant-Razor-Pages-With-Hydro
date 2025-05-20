using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorTest.Pages
{
    public class TenantsModel : PageModel
    {
        private readonly ILogger<TenantsModel> _logger;

        public TenantsModel(ILogger<TenantsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
