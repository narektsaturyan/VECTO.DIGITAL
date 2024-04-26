using Microsoft.AspNetCore.Mvc;
using VECTO.DIGITAL.Domain.Core;
using VECTO.DIGITAL.Domain.Interfaces;
using VECTO.DIGITAL.Domain.Services;
using VECTO.DIGITAL.WebAPI.DTO;

namespace VECTO.DIGITAL.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageProcessorController : ControllerBase
    {
        private readonly IImageProcessorService service;

        public ImageProcessorController(IImageProcessorService service)
        {
            this.service = service;
        }

        [HttpGet("GetImageEffects")]
        public IEnumerable<IImageEffect> GetEffects()
        {
            return null;
        }

        [HttpPost("AddImageEffect")]
        public IActionResult AddEffect()
        {
            return Ok();
        }

        [HttpPost("ProcessImages")]
        public List<ProcessedImageDTO> GetProcessedImages(List<ImageDTO> imageDtos)
        {
            List<Image> images = MapToImages(imageDtos);
            var result = service.ProcessImages(images);

            return MapToProcessedImageDtos(result);

        }

        private List<Image> MapToImages(List<ImageDTO> imageDtos)
        {
            return new List<Image>();
        }

        private List<ProcessedImageDTO> MapToProcessedImageDtos(List<Image> images)
        {
            return new List<ProcessedImageDTO>();
        }
    }
}
