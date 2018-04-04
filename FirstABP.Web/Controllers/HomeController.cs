using FirstABP.People;
using FirstABP.People.DTO;
using System.Collections.Generic;
using System.Web.Mvc;

namespace FirstABP.Web.Controllers
{
    public class HomeController : FirstABPControllerBase
    {
        private readonly IPersonService _personService;

        public HomeController(IPersonService personService)
        {
            _personService = personService;
        }

        public ActionResult Index()
        {
            List<PersonDto> People = new List<PersonDto>() { new PersonDto() { Age =18,Name= "杨幂幂"} };
            //获取列表
            try
            {
                People = _personService.GetPersons().People;
            }
            catch
            {
             
            }
            return View(People);
        }
    }
}