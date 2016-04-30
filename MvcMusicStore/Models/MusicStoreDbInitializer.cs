using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class MusicStoreDbInitializer: System.Data.Entity.DropCreateDatabaseAlways<MusicStoreDB>
    {
        protected override void Seed(MusicStoreDB context)
        {
            context.Artists.Add(new Artist { Name = "Bonobo" });
            context.Genres.Add(new Genre { Name = "DownTempo" });
            context.Albums.Add(new Album {
                                            Artist = new Artist { Name = "Imogen heap" },
                                            Genre = new Genre { Name = "Indie" },
                                            Price = 9.99m,
                                            Title = "Speak for yourself"
                                        });
            base.Seed(context);
        }
    }
}