using Microsoft.AspNetCore.Mvc;
using Practiceapi.Models;
namespace Practiceapi.Controllers;

[ApiController]
[Route("api/[controller]")]  
public class EmployeeController : ControllerBase
{
       private readonly ACE42023Context db=new ACE42023Context();  
       public EmployeeController(ACE42023Context _db)
       {
              db=_db;
       }
       [HttpGet]
       [Route("GetEmp")]
       public IActionResult GetEmployee()
       {
              return Ok(db.Emps.ToList());
       }
       [Route("Id")]
       [HttpGet]
       public IActionResult GetEmployee(int id)
       {
              Emp emp=null;
              foreach(var Employee in db.Emps)    
              {
                      if(Employee.Eid==id)
                      {
                         emp=Employee;
                      }
              }
              if(emp==null)
              {
                 return NotFound();
              }
              return Ok(emp);  
       }
       [HttpGet]
       [Route("name")]
       public IActionResult GetEmployee(string ptrn)
       {
              return Ok(db.Emps.Where(x=>x.Ename.Contains(ptrn)).ToList());  
       }
       [HttpPost]
       [Route("Add")]
       public IActionResult AddEmployee(Emp obj)  
       {
              if(obj.Awards=="")
              {
                 obj.Awards="None";  
              }
              foreach(var Employee in db.Emps)
              {
                     if(Employee.Eid==obj.Eid)
                     {
                        return BadRequest();   
                     }
              }
              db.Emps.Add(obj);  
              db.SaveChanges();  
              return Ok(obj);  
       }
       [HttpPut]
       [Route("Update")]
       public IActionResult Update(int id,Emp obj)  
       {
              db.Emps.Update(obj);   
              db.SaveChanges();  
              return Ok(obj);  
       }
       [HttpDelete]
       [Route("Delete")]
       public IActionResult Delete(int id)
       {
              db.Emps.Remove(db.Emps.Find(id));  
              db.SaveChanges();
              return Ok(); 
       }
}

