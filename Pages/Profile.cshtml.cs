using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using rp_ef_maria.Models;

namespace rp_ef_maria.Pages;

public class ProfileModel : PageModel
{
    private readonly ILogger<ProfileModel> _logger;
    private readonly StoreContext _context;


    [BindProperty]
    public SiteUser SiteUser { get; set; } = default!;

    public ProfileModel(StoreContext context, ILogger<ProfileModel> logger)
    {
        _logger = logger;
        _context = context;
    }

    public void OnGet()
    {
        return;
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (ModelState.IsValid)
        {

            _context.Attach(SiteUser).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        return Page();
    }
}

