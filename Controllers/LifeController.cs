using System;
using FisherInsurance.Models;
using Microsoft.AspNetCore.Mvc; 
public class LifeController : Controller 
  {
public IActionResult index() 
    { 
        //return Ok("This is the index of the LifeController"); 
        return View();
    }
  public IActionResult quote() 
    { Quote quote = new Quote
        {
            Id = 345,
            Product = "Life Insurance",
            ExpireDate = DateTime.Now.AddDays(45), 
            Price = 45.00M
        };
        return View(quote);
        //return Ok("This is the quote of the LifeController"); 
    }
   }