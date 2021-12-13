using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MuzikStoreRazor.UI.Models;

namespace MuzikStoreRazor.UI.Pages.MusicList
{
    public class IndexModel : PageModel
    {
        private readonly MusicStorelistContext _db;

        public IndexModel(MusicStorelistContext db)
        {
            _db = db;
        }

        public IEnumerable<Music> Musics { get; set; }

        public async Task OnGet()
        {
            Musics = await _db.Musics.ToListAsync();
        }
    }
}
