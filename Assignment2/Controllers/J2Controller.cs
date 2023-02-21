using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Compute number of ways to roll the value of 10
        /// </summary>
        /// <param name="m">Dice M has 6 sides</param>
        /// <param name="n">Dice N has 8 sides</param>
        /// <returns>
        /// Positive integer of 6/8 - There are 5 totals ways to get the sum 10.
        /// Positive integer of 12/4 -> There are 4 ways to get the sum 10.
        /// Positive integer of 3/3 -> There are 0 ways to get the sum 10.
        /// Positive integer of 5/5 -> There is 1 way to get the sum 10.
        /// </returns>

        [HttpGet]
        [Route("api/Assignment2/RollDices/{m}/{n}")]

        public string RollDices(int m, int n)
        {
            int ways = 0;
            if (m > 10 || n > 10)
            {
                for (int i = 1; i < 11; i++)
                {
                    for (int j = 1; j < 11; j++)
                    {
                        if (i + j == 10)
                        {
                            ways++;
                        }
                    }
                }
            }

            else if (m <= 10 || n <= 10)
            {
                for (int i = 1; i <= m; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (i + j == 10)
                        {
                            ways++;
                        }
                    }
                }
            }

            else if (m <= 10 || n > 10)
            {
                for (int i = 1; i <= m; i++)
                {
                    for (int j = 1; j < 11; j++)
                    {
                        if (i + j == 10)
                        {
                            ways++;
                        }
                    }
                }
            }

            else if (m > 10 || n <= 10)
            {
                for (int i = 1; i > 11; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (i + j == 10)
                        {
                            ways++;
                        }
                    }
                }
            }

            if (ways == 1)
            {
                return "There is " + ways + " way to get the value of 10";
            } 
            else
            {
                return "There are  " + ways + " way to get the value of 10";
            }
            
        }
    }
}

