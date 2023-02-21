using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Compute the total calories for the meal
        /// </summary>
        /// <param name="Bu">Compute {burger} - integer representing the index burger choice</param>
        /// <param name="Sd">Compute {side} - Integer representing the index side choice</param>
        /// <param name="Dr">Compute {drink} - integer representing the index drink choice</param>
        /// <param name="De">Compute {dessert) - Integer representing the index dessert choice</param>
        /// <returns>
        /// HTTP request of 4/4/4/4 -> Your total calories count is 0
        /// HTTP request of 1/2/3/4 -> Your total calories count is 691
        /// </returns>

        [HttpGet]
        [Route("api/Assignment2/Menu/{Bu}/{Dr}/{Sd}/{De}")]


        public string Menu(int Bu, int Dr, int Sd, int De)
        {
            var Burger = Bu;
            var Drink = Dr;
            var SideOrder = Sd;
            var Dessert = De;

            int BurgerCalories = 0;
            if (Burger == 1)
            {
                BurgerCalories = 461;
            }
            else if (Burger == 2)
            {
                BurgerCalories = 431;
            }
            else if (Burger == 3)
            {
                BurgerCalories = 420;
            }
            else if (Burger == 4) 
            {
                BurgerCalories = 0;
            }

            int DrinkCalories = 0;
            if (Drink == 1)
            {
                DrinkCalories = 130;
            }
            else if (Drink == 2)
            {
                DrinkCalories = 160;
            }
            else if (Drink == 3)
            {
                DrinkCalories = 118;
            }
            else if (Drink == 4)
            {
                DrinkCalories = 0;
            }

            int SideOrderCalories = 0;
            if (SideOrder == 1)
            {
                SideOrderCalories = 100;
            }
            else if (SideOrder == 2)
            {
                SideOrderCalories = 57;
            }
            else if (SideOrder == 3)
            {
                SideOrderCalories = 70;
            }
            else if (SideOrder == 4)
            {
                SideOrderCalories = 0;
            }

            int DessertCalories = 0;
            if (Dessert == 1)
            {
                DessertCalories = 167;
            } 
            else if (Dessert == 2)
            {
                DessertCalories = 266;
            } 
            else if (Dessert == 3)
            {
                DessertCalories = 75;
            } 
            else if (Dessert == 4)
            {
                DessertCalories = 0;
            }

            int TotalCalories = BurgerCalories + SideOrderCalories + DrinkCalories + DessertCalories;
            string message = "Your total calodries count is " + TotalCalories;
            return message;
        }           
            
    }
}
