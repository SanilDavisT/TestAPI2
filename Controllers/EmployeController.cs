using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeController : ControllerBase
    {
        [HttpPost]
        [Route ("AddEmploye")] 
        public Employe AddEmployee(Employe employe)
        {
            return employe;
            
        }

        [HttpGet]
        [Route ("GetEmploye")]

        public List<Employe> GetEmploye()
        {
            var Employeelist = new List<Employe>();

           Employe e1 = new Employe();
            e1.name = "Sanil";
            e1.place = "Thrissur";

            Employe e2 = new Employe();
            e2.name = "Ashiq";
            e2.place = "Palakad";

            return Employeelist;
             




        }


    }
}
