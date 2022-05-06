using AdminTemplate.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminTemplate.Controllers.Apis
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryApiController : ControllerBase
    {
        private readonly MyContext _context;

        public CategoryApiController(MyContext context)
        {
            _context = context;
        }
        // CRUD - Create Read Update Delete
        // [HttpGet] Read (SELECT)
        // [HttpPost] Create (INSERT)
        // [HttpPut] Update (UPDATE)
        // [HttpDelete] Delete (DELETE)
        // Get isteklerinde nasıl bir data çekeceğimizi query string ile belirleriz.
        // Get ile data gönderemez. header bilgisi gönderebilir.
        // Post, put ve delete işlemlerinde data gönderebiliriz. header-body bilgisi gönderilebilir.
        // Header = Query String

        [HttpGet]
        public IActionResult All()
        {
            try
            {
                return Ok(_context.Categories.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = $"Bir hata oluştu: {ex.Message}" });
            }
        }

    }
}