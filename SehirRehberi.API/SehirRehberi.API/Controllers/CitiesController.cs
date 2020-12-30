using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SehirRehberi.API.Data;
using SehirRehberi.API.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Cities")]
    
    public class CitiesController : Controller
    {
        // repository enjekte edılır.
        private IAppRepository _appRepository;
        private IMapper _mapper;
        public CitiesController(IAppRepository appRepository, IMapper mapper )
        {
            _appRepository = appRepository;
            _mapper = mapper;
        }

        public ActionResult GetCities()
        {
            var cities = _appRepository.GetCities();
            // ben sana cities veriyorum sen onu al cityforlistdto a ya map et automapper diye gecerr bundan sonra map olusturduk. nuget paketlerınden mapper ındırdık sonra conf. yaptık. (Helpers klasörü)
            var citiesToReturn = _mapper.Map<List<CityForListDto>>(cities);
            return Ok(citiesToReturn);
        }

    }
}
