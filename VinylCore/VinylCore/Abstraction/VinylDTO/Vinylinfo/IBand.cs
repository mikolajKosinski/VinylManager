using System;
using System.Collections.Generic;
using System.Text;

namespace VinylCore.Abstraction.VinylDTO
{
    public interface IBand
    {
        IEnumerable<IMember> MembersList { get; set; }
        DateTime Formed { get; set; }
    }
}
