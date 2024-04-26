using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VECTO.DIGITAL.Domain.Core;
using VECTO.DIGITAL.Domain.Interfaces;

namespace VECTO.DIGITAL.Domain.Services
{
    public interface IImageProcessorService
    {
        List<Image> ProcessImages(List<Image> images);
    }
}
