using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SehirRehberi.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.API.Controllers
{ 
    [ApiController]
    [Route("api/[controller]")]   //Route=> hangi adresten gelecek onu belirtiyor. URL gidilir api/values yazılır.
    public class ValuesController : Controller
    {
        private DataContext _context;
        
        public ValuesController(DataContext context)  // injection yapılır. // valuescontrollerın construct.
        {
            _context = context;
        }

        //GET api/Values
        [HttpGet]
        public async Task< ActionResult> GetValues()
        {
            var values =  await _context.Values.ToListAsync(); // veritbanıma erişim yapıyorum.
            return Ok(values);   // 200 OK mesajı döndürür. hemde values içindeki değerleri döndürür.
        }

        
        //GET api/ values/5
        [HttpGet("{id}")]  // eğer id 5 yada 10 20 ne koyarsan olursa bu çalışır yani api/values/10 koy mesela bu çalışır
        public async Task<ActionResult> GetValues(int id)
        {
            var values = await _context.Values.FirstOrDefaultAsync(v=>v.Id==id);
            return Ok(values);
        }

        // POST api/values
        [HttpPost]    // POST insert için kullanır.Mesela ben bir datayı post edıyorum  al onu database ekle.
        //POSTMAN kullanılır. string bir değer alıyor. postmande bir json değer verdik sonra debug koyup baktık geldımı diye
        public void Post([FromBody] string value)
        {

        }
        // PUT api /values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api /values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}


