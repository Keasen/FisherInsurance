using Microsoft.AspNetCore.Mvc; 
public class AutoController : Controller 
  {
public IActionResult index() 
    { 
        return Ok("This is the index of the AutoController"); 
    }
  public IActionResult quote() 
    { 
        return Ok("This is the quote of the AutoController"); 
    }
   }
