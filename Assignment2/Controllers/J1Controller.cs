using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        // Write a program that will compute the totla calories fo the meal
        // GET : http://localhost/api/J1
        // Compute {burger} - integer representing the index burger choice
        // Compute {drink} - integer representing the index drink choice
        // Compute {side} - Integer representing the index side choice
        // Compute {dessert) - Integer representing the index dessert choice

        [HttpGet]
        [Route("api/Assignment2/J1/")]
        public string menu (int B, int S, int D, int D)
        {
           if (B = 1)
            {

            }
        }
    }
}
