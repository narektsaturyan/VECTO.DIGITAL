using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VECTO.DIGITAL.Domain.Interfaces
{
    public interface IImageProcessor
    {
        List<IImageEffect> Effects { get; set; }
        bool RegisterEffect(IImageEffect effect);
        bool RemoveEffect(Guid effectId);
        IEnumerable<IImageEffect> GetEffects();
        List<IImage> ProcessImages(List<IImage> images);
    }
}
