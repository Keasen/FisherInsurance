using Microsoft.AspNetCore.Mvc; 
public class LifeController : Controller 
  {
public IActionResult index() 
    { 
        //return Ok("This is the index of the LifeController"); 
        return View();
    }
  public IActionResult quote() 
    { 
        return Ok("This is the quote of the LifeController"); 
    }
   }