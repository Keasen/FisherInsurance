using System;
using FisherInsurance.Models;
using Microsoft.AspNetCore.Mvc;
public class AutoController : Controller 
  {
public IActionResult index() 
    { 
        //return Ok("This is the index of the AutoController"); 
        return View();
    }
  public IActionResult quote() 
    { 
        Quote quote = new Quote
        {
            Id = 345,
            Product = "Auto Insurance",
            ExpireDate = DateTime.Now.AddDays(45), 
            Price = 45.00M
        };
        
        return View(quote);
        //return Ok("This is the quote of the AutoController"); 
    }
   }
