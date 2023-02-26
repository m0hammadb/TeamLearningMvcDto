using Microsoft.AspNetCore.Mvc;
using TeamLearningMvcDto.Models;
using TeamLearningMvcDto.Models.DTOs;

namespace TeamLearningMvcDto.Controllers
{

    //mishe /Accounts
    [Route("/[controller]")]
    public class AccountsController : Controller
    {

        //chon database nadarim ye liste static dar nazar gereftam

        // ke dg dargire pichidegi haye database nashim

        // ta zamani ke barname dar hale ejras azaye list vojood daran

        // barname ke baste beshe ina ham pak mishan
        private static List<Account> _accountList = new List<Account>();

        [HttpGet]
        [Route("")]

        //ba tarkibe balayi mishe GET /Accounts
        public IActionResult Index()
        {
            return View(_accountList);
        }

        [HttpGet]
        [Route("Create")]

        //ba tarkibe balayi mishe GET /Accounts/Create
        public IActionResult CreateAccount()
        {
            return View("Create");
        }

        [HttpPost]
        [Route("Create")]

        //ba tarkibe balayi mishe POST /Accounts/Create

        public IActionResult CreateAccount(CreateAccountDto dto)
        {
            if(ModelState.IsValid == false)
            {
                return View("Create");
            }

            var account = new Account()
            {
                Email = dto.Email,
                Name = dto.Name,
                Password = dto.Password,
            };

            _accountList.Add(account);

            return RedirectToAction("Index");
        }
    }
}
