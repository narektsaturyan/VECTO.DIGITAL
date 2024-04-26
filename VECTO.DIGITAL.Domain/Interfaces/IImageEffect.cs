using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VECTO.DIGITAL.Domain.Interfaces
{
    public interface IImageEffect
    {
        Guid Id { get; set; }
        string Name { get; set; }
        object EffectParameter { get; set; }
        bool ApplyEffect(IImage image);
    }
}
