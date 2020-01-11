using System;
using System.Collections.Generic;
using System.Text;

namespace VinylCore.Abstraction.VinylDTO
{
    public interface ICover
    {
        string Format { get; set; }
        string FrontURI { get; set; }
        string BackURI { get; set; }
        string AdditionalsURI { get; set; }
    }
}
