using System;
using System.Collections.Generic;
using System.Text;

namespace VinylCore.Abstraction.VinylDTO
{
    public interface IAlbum
    {
        IBand Band { get; set; }
        string Title { get; set; }
        DateTime ReleaseDate { get; set; }
        IEnumerable<string> SongsList { get; set; }
    }
}
