using System;
using System.Collections.Generic;
using System.Text;

namespace VinylCore.Abstraction.VinylDTO
{
    public interface IVinyl
    {
        IAlbum Album { get; set; }
        double DiscSize { get; set; }
        ICover Cover { get; set; }
        bool LimitedEdition { get; set; }
        short DiscCount { get; set; }
    }
}
