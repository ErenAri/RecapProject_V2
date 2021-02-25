using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Threading.Tasks;
using Business.Constants;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CarController : ControllerBase
    {
        ICarDAL _carDal;

        ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result); 

            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetByCarId(int id)
        {
            var result = _carService.GetCarById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbybrandid")]
        public IActionResult GetByBrandId(int brandId)
        {
            var result = _carService.GetCarsByBrandId(brandId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbycolorid")]
        public IActionResult GetByColorId(int colorId)
        {
            var result = _carService.GetCarsByColorId(colorId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
       
        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("imageadd")]
        public IActionResult AddImage(Car car)
        {
            var result = _carService.AddImage(car);
            //Bu kodları 'https://stackoverflow.com/questions/15696812/how-to-set-relative-path-to-images-directory-inside-c-sharp-project' dan aldım :)
            var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"C:\Users\Eren\source\repos\Images\togg.jpg";
            var logoImage = new LinkedResource(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"C:\Users\Eren\source\repos\Images\togg.jpg");
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("imagedelete")]
        public IActionResult DeleteImage(Car car)
        {
            var result = _carService.DeleteImage(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("imageupdate")]
        public IActionResult UpdateImage(Car car)
        {
            var result = _carService.UpdateImage(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        private IResult CheckImageLimit(int ImageCount)
        {
            var result = _carDal.GetAll(c => c.ImageCount == ImageCount).Count;
            if (result >= 10)
            {
                return new ErrorResult(Messages.ImageLimitExceded);
            }
            return new SuccessResult();
        }
    }
}
