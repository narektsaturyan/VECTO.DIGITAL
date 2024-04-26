using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VECTO.DIGITAL.Domain.Interfaces
{
    public interface IImage
    {
        byte[] ImageData { get; set; }
        IEnumerable<Guid> RelevantEffectIds { get; set; }
    }
}
