using Microsoft.EntityFrameworkCore;

namespace MuzikStoreRazor.UI.Models
{
    public class MusicStorelistContext:DbContext
    {
        public MusicStorelistContext(DbContextOptions<MusicStorelistContext> options)
            : base(options)
        {
           
        }
        
        public DbSet<Music> Musics { get; set; }

    }
}
