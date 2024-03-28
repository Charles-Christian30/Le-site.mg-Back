using Domaine.Data;
using Domaine.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Constantes;
using Service;

namespace Le_site.mg.Controllers
{
    [Route("/")]
    [ApiController]
    public class LeSiteController : ControllerBase
    {
        private readonly ILeSiteService _service;
        public LeSiteController(ILeSiteService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("Accueil")]
        public async Task<ActionResult<List<AccueilModelDto>>> GetAccueilInformations()
        {
            var responses = await _service.GetAccueilInformations();
            return Ok(responses);
        }

        [HttpGet]
        [Route("Category")]
        public async Task<ActionResult<List<CategoryModelDto>>> GetCategory(string categoryName)
        {
            var responses = new List<CategoryModelDto>();
            var result = new List<CategoryModelDto>();
            if (string.IsNullOrEmpty(categoryName))
                return NotFound();

            if (categoryName.ToUpper().Trim() == CategorieConstante.FORMATIONS.ToUpper().Trim())
            {
                responses = await _service.GetAllFormations();
                if (responses != null)
                {
                    result = responses.OrderByDescending(x => x.isGold).ThenByDescending(y => y.isPremium).ThenByDescending(z => z.Note).ToList();
                    return Ok(result);
                }
            }
            else if (categoryName.ToUpper().Trim() == CategorieConstante.SHOPPING.ToUpper().Trim())
            {
                responses = await _service.GetAllShopping();
                if (responses != null)
                {
                    result = responses.OrderByDescending(x => x.isGold).ThenByDescending(y => y.isPremium).ThenByDescending(z => z.Note).ToList();
                    return Ok(result);
                }
            }
            else if (categoryName.ToUpper().Trim() == CategorieConstante.HOTELRESTAURANTESPACE.ToUpper().Trim())
            {
                responses = await _service.GetAllHotelRestaurantEspace();
                if (responses != null)
                {
                    result = responses.OrderByDescending(x => x.isGold).ThenByDescending(y => y.isPremium).ThenByDescending(z => z.Note).ToList();
                    return Ok(result);
                }
            }
            else if (categoryName.ToUpper().Trim() == CategorieConstante.BIENETRE.ToUpper().Trim())
            {
                responses = await _service.GetAllBienEtre();
                if (responses != null)
                {
                    result = responses.OrderByDescending(x => x.isGold).ThenByDescending(y => y.isPremium).ThenByDescending(z => z.Note).ToList();
                    return Ok(result);
                }
            }
            return BadRequest();

        }
    }
}
