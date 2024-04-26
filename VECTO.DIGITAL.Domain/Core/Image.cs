using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VECTO.DIGITAL.Domain.Interfaces;

namespace VECTO.DIGITAL.Domain.Core
{
    public class Image : IImage
    {
        public byte[] ImageData { get; set; }
        public byte[] ImageDate { get; }
        public IEnumerable<Guid> RelevantEffectIds { get; set; }

        public Image(byte[] imageDate, List<Guid> relevantEffectIds)
        {
            ImageDate = imageDate;
            RelevantEffectIds = relevantEffectIds;
        }
    }
}
