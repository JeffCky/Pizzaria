using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzaria.Models;

namespace Pizzaria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ 
                PizzaName = "Margerita", 
                ImageTitle = "Margerita", 
                BasePrice = 2, 
                TomatoSauce=true, 
                Cheese=true, 
                FinalPrice=4},
            new PizzasModel(){
                PizzaName = "Bolognese",
                ImageTitle = "Bolognese",
                BasePrice = 2,
                TomatoSauce=true,
                Cheese=true,
                CanadianBacon=true,
                Ham=true,
                Mushroom=true,
                FinalPrice=7},
            new PizzasModel(){
                PizzaName = "Carbonara",
                ImageTitle = "Carbonara",
                BasePrice = 2,
                TomatoSauce=true,
                Cheese=true,
                Ham=true,
                FinalPrice=5},
            new PizzasModel(){
                PizzaName = "Hawaiian",
                ImageTitle = "Hawaiian",
                BasePrice = 2,
                TomatoSauce=true,
                Cheese=true,
                CanadianBacon=true,
                Pineapple=true,
                Ham=true,
                FinalPrice=7},
            new PizzasModel(){
                PizzaName = "Meatfeast",
                ImageTitle = "Meatfeast",
                BasePrice = 2,
                TomatoSauce=true,
                Cheese=true,
                Ham=true,
                Beef=true,
                Pepperoni=true,
                CanadianBacon = true,
                FinalPrice=8},
            new PizzasModel(){
                PizzaName = "Mushroom",
                ImageTitle = "Mushroom",
                BasePrice = 2,
                TomatoSauce=true,
                Cheese=true,
                Mushroom=true,
                FinalPrice=5},
            new PizzasModel(){
                PizzaName = "Pepperoni",
                ImageTitle = "Pepperoni",
                BasePrice = 2,
                TomatoSauce=true,
                Cheese=true,
                Pepperoni=true,
                FinalPrice=5},
            new PizzasModel(){
                PizzaName = "Seafood",
                ImageTitle = "Seafood",
                BasePrice = 2,
                TomatoSauce=true,
                Cheese=true,
                Tuna=true,
                FinalPrice=5},
            new PizzasModel(){
                PizzaName = "Vegetarian",
                ImageTitle = "Vegetarian",
                BasePrice = 2,
                TomatoSauce=true,
                Cheese=true,
                Mushroom=true,
                Pineapple=true,
                FinalPrice=15}
        };
        public void OnGet()
        {
        }
    }
}
