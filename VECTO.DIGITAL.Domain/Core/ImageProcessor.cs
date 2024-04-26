using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using VECTO.DIGITAL.Domain.Interfaces;

namespace VECTO.DIGITAL.Domain.Core
{
    public class ImageProcessor : IImageProcessor
    {
        public List<IImageEffect> Effects { get; set; }
        public bool RegisterEffect(IImageEffect effect)
        {
            //TODO: Validate effect before adding
            Effects.Add(effect);

            return true;
        }

        public bool RemoveEffect(Guid effectId)
        {
            var effect = Effects.Find(x => x.Id == effectId);

            Effects.Remove(effect);

            return true;
        }

        public IEnumerable<IImageEffect> GetEffects()
        {
            return Effects;
        }

        public List<IImage> ProcessImages(List<IImage> images)
        {
            foreach (var image in images)
            {
                var effects = Effects.Where(x => image.RelevantEffectIds.Contains(x.Id));
                foreach (var effect in effects)
                {
                    effect.ApplyEffect(image);
                } 
            }

            return images;
        }

        public ImageProcessor()
        {
            Effects = new List<IImageEffect>();
        }
    }
}
