using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Web.Http;

namespace Assignment2.Controllers
{
    /// <summary>
    /// Decipher secret code to find the direction to the hidden Biofuel formula
    /// </summary>
    /// <param name="code">input 5 digits code to find the direction of the hidden formula</param>
    /// <return>
    /// input integers of 57234 -> Right 234
    /// input integers of 00907 -> Right 907
    /// input integers of 34100 -> Left 100
    /// input integers of 99999 -> break
    /// </return>
    public class J3Controller : ApiController
    {
        [HttpGet]
        [Route("api/Assignment2/SecretCode/{code}")]

        public string SecretCode(int code)
        {

            {
                string direction = " ";
                string previousD = "direction";
                int steps = code % 1000;

                {
                    int pv1 = 0;
                    int n = 1;
                    {
                        for (var i = 1; i < n; i++) ;
                        code /= 10;
                        {
                            pv1 = (code /= 10);
                        }
                    }
                    
                    int pv2 = 0;
                    int m = 2;
                    {
                    for (var i = 1; i < m; i++) ;
                    code /= 10;
                        {
                            pv2 = (code /= 10);
                        }
                        
                    }
                    int EvensOdds = pv1 + pv2;
                    
                    if (EvensOdds %2 == 0)
                    {
                        direction = " Right ";
                    }
                    else if (EvensOdds %2 == 1)
                    {
                        direction = " Left ";
                    }
                    else if (EvensOdds == 0)
                    {
                        previousD = direction;
                    }
                }
                    while (code == 99999)
                    {
                    break;
                    }
                
                return direction + steps;


                }
                    
                
            }

        }
    }

