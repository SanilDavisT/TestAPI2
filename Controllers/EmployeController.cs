using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestAPI2.Model;

namespace TestAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeController : ControllerBase
    {

        EmployeDbContext _context;

        public EmployeController(EmployeDbContext context)
        {
           
            _context = context;


        }


        [HttpPost]
        [Route ("AddEmploye")] 
        public Employe AddEmployee(Employe employe)
        {


            _context.emps.Add(employe);
            _context.SaveChanges();
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

            Employeelist.Add(e1);
            Employeelist.Add(e2);



            _context.Add(e1);
            _context.Add(e2);
           _context.SaveChanges();

            

            return Employeelist;

        }

        [HttpGet]
        [Route("GetAllEmploye")]

        public List<Employe> GetAllEmploye()
        {
            var Employeelist2 = _context.emps.ToList();

            return Employeelist2;
        }


        [HttpDelete]
        [Route("DeleteEmploye")]

        public void DeleteEmploye( int id)
        {
            var example = _context.emps.Find(id);

           
            _context.emps.Remove(example);

           
            _context.SaveChanges();
                       

        }


        [HttpPut]
        [Route("PutEmploye")]

        public void PutEmploye(Employe employe, int id)
        {

            

            if(id == employe.ID)
            {
                _context.Entry(employe).State = EntityState.Modified;


            }

            _context.SaveChanges();



        }



    }
}
