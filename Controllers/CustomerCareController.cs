using Microsoft.AspNetCore.Mvc; 
[Route("Claim")] 
public class CustomerCareController : Controller 
 
  {
      [Route("index")] 
public IActionResult index() 
    { 
        return Ok("This is the index of the CustomerCareController"); 
    }

       [Route("fileclaim")]
         public IActionResult NewClaims() 
           { 
              return Ok("This is the File Claim page"); 
            }
    [Route("claimstatus")]
        public IActionResult ClaimHistory() 
            { 
        return Ok("This is the Claim History page"); 
            }
    [Route("claims")]
            public IActionResult quote() 
    { 
        return Ok("This is the quote of the Claims"); 
    }

   }
  
  

