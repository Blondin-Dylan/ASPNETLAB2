using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using rp_ef_maria.Models;

namespace rp_ef_maria.Pages.Games
{
	public class IndexModel : PageModel
	{
		private readonly StoreContext _context;

		public IndexModel(StoreContext dbcontext)
		{
			_context = dbcontext;
		}

		public IList<Game> Game { get; set; } = default!;

		[BindProperty(SupportsGet = true)]
		public string Query { get; set; } = default!;

		public async Task OnGetAsync()
		{
			IQueryable<Game> games; 
			if (Query != null)
			{
				
				games = _context.Game.Where(g => g.Title.Contains(Query));
			}
			else
			{
				
				games = _context.Game;
			}
			
			games = games.Where(g => g.ReleaseDate > DateTime.Now.AddYears(-5));
			
			Game = await games.ToListAsync();
			
			Page();

		}

	}
}
