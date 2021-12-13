using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MuzikStoreRazor.UI.Models;

namespace MuzikStoreRazor.UI.Pages.MusicList
{
    public class CreateModel : PageModel
    {
        private readonly MusicStorelistContext _db;

        public CreateModel(MusicStorelistContext db)
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
