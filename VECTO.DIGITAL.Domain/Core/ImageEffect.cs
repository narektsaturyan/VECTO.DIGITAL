using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VECTO.DIGITAL.Domain.Interfaces;

namespace VECTO.DIGITAL.Domain.Core
{
    public class ImageEffect : IImageEffect
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public object EffectParameter { get; set; }
        public bool ApplyEffect(IImage image)
        {
            //Change image.ImageData
            throw new NotImplementedException();
        }

        public ImageEffect(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}
