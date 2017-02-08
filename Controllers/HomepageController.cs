using Microsoft.AspNetCore.Mvc; 
public class HomepageController : Controller 
  {
public IActionResult index() 
    { 
        return Ok("This is the index of the HomepageController"); 
    }
  public IActionResult quote() 
    { 
        return Ok("This is the quote of the HomepageController"); 
    }
   }