using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ServerApp.Models;

namespace ServerApp {

    public class SeedData {

        public static void SeedDatabase(DataContext context) {
            //what categories do we need: Concealment, Magic, transportation
            context.Database.Migrate();

            if (context.Products.Count() == 0) {
                var s1 = new Supplier { Name = "Hogwarts", 
                    City = "Wizard Land", State = "Unknown"};
                var s2 = new Supplier { Name = "Gringotts", 
                    City = "England", State = "Lond"};
                var s3 = new Supplier { Name = "Dark Magic", 
                    City = "Voldemort's Lair", State = "Abyss"};

                context.Products.AddRange(
                    new Product { Name = "Magic Bottle", 
                        Description = "Refills every hour", Image = "magic_bottle.jpg",
                        Category = "Magic", Price = 100, Supplier = s1, 
                        Ratings = new List<Rating> {
                        new Rating {Stars = 5}, new Rating {Stars = 2}}},
                    new Product { Name = "Cloaking Tent", 
                        Description = "A tent people cant see", Image = "cloaking_tent.jpg",
                        Category = "Concealment", Price = 175, Supplier = s1, 
                        Ratings = new List<Rating> { 
                            new Rating {Stars = 3}, new Rating {Stars = 2}}},
                    new Product { Name = "Non-Stick Frying Pan", 
                        Description = "Stuff actually doesn’t stick", Image = "non_stick_frying_pan.jpg",
                        Category = "Magic", Price = 60, Supplier = s1, 
                        Ratings = new List<Rating> {
                            new Rating {Stars = 5}, new Rating {Stars = 5}}},
                    new Product { 
                        Name = "Flying Car", 
                        Description = "A car capable of flight", Image = "flying_car.jpg",
                        Category = "Transportation", Price = 16000, Supplier = s1, 
                        Ratings = new List<Rating> {
                            new Rating {Stars = 4}}},
                    new Product { Name = "Broomstick",
                        Description = "The bicycle of the sky", Image = "broomstick.jpg",
                        Category = "Transportation", Price = 95, Supplier = s1, 
                        Ratings = new List<Rating> {
                            new Rating {Stars = 2}, new Rating {Stars = 4}}},
                    new Product { Name = "Magic Stopwatch", 
                        Description = "A stopwatch that stops time", Image = "magic_stopwatch.jpg",
                        Category = "Magic", Price = 500, Supplier = s1, 
                        Ratings = new List<Rating> {
                            new Rating {Stars = 1}, new Rating {Stars = 4}}},
                    new Product { Name = "Secret Pouch", 
                        Description = "A bottomless pouch to hide your belongings", Image = "secert_pouch.jpg",
                        Category = "Concealment",  Price = 45, Supplier = s1, 
                        Ratings = new List<Rating> {
                            new Rating {Stars = 3}, new Rating {Stars = 3}}},
                    
                    new Product { Name = "Cursed Ring", 
                        Description = "A ring that turns you invisible but also might be cursed", Image = "cursed_ring.jpg",
                        Category = "Concealment", Price = 10, Supplier = s1, 
                        Ratings = new List<Rating> {
                            new Rating {Stars = 5}}},
                    
                    new Product { Name = "Box Home", 
                        Description = "A home hidden inside a cardboard box", Image = "box_home.jpg",
                        Category = "Concealment", Price = 30000, Supplier = s1, 
                        Ratings = new List<Rating> {
                            new Rating {Stars = 3}}},
                    new Product { Name = "Magic Mirror", 
                        Description = "See your future", Image = "magic_mirror.jpg",
                        Category = "Magic", Price = 180, Supplier = s1, 
                        Ratings = new List<Rating> {
                            new Rating {Stars = 2}, new Rating {Stars = 4}}},
                    new Product { Name = "Used Wand", 
                        Description = "Still works fine", Image = "used_wand.jpg",
                        Category = "Magic", Price = 45, Supplier = s1, 
                        Ratings = new List<Rating> {
                            new Rating {Stars = 2}, new Rating {Stars = 4}}},
                    new Product { Name = "New Wand", 
                        Description = "Smells like new car", Image = "new_wand.jpg",
                        Category = "Magic", Price = 120, Supplier = s1, 
                        Ratings = new List<Rating> {
                            new Rating {Stars = 2}, new Rating {Stars = 4}}},
                    new Product { Name = "Teleportation Potion", 
                        Description = "Drink it and think of where you want to go", Image = "teleportation_potion.jpg",
                        Category = "Transportation", Price = 25, Supplier = s3, 
                        Ratings = new List<Rating> {
                            new Rating {Stars = 1}, new Rating {Stars = 3}}},
                    new Product { Name = "Hat of Satisfaction", 
                        Description = "Makes you content", Image = "hat_of_satisfaction.jpg",
                        Category = "Magic", Price = 35, Supplier = s1, 
                        Ratings = new List<Rating> {
                            new Rating {Stars = 5}, new Rating {Stars = 5}}},
                    new Product { Name = "Magic Ladder", 
                        Description = "As tall as you need it", Image = "magic_ladder.jpg",
                        Category = "Magic", Price = 39.99m, Supplier = s2, 
                        Ratings = new List<Rating> {
                            new Rating {Stars = 3}, new Rating {Stars = 4}}},
                    new Product { Name = "Flying Mop", 
                        Description = "A flying broom for tile floors", Image = "flying_mop.jpg",
                        Category = "Transportation", Price = 85, Supplier = s2, 
                        Ratings = new List<Rating> {
                            new Rating {Stars = 4}, new Rating {Stars = 4}}},
                    new Product { Name = "Magic Muffler", 
                        Description = "For when your flying car makes to much noise", Image = "magic_muffler.jpg",
                        Category = "Concealment", Price = 320, Supplier = s1, 
                        Ratings = new List<Rating> {
                            new Rating {Stars = 2}, new Rating {Stars = 5}}},
                    new Product { Name = "Magic Beans", 
                        Description = "Each one has a different effect", Image = "magic_beans.jpg",
                        Category = "Magic", Price = 15.99m, Supplier = s3, 
                        Ratings = new List<Rating> {
                            new Rating {Stars = 5}, new Rating {Stars = 1}}},
                    new Product { Name = "Bling-Bling Wand", 
                        Description = "A wand plated in gold and studded with diamonds", Image = "bling_bling_wand.jpg",
                        Category = "Magic", Price = 2000, Supplier = s2},
                    new Product { Name = "Speaking Cat", 
                        Description = "A cat that can speak", Image = "talking_cat.jpg",
                        Category = "Magic", Price = 300, Supplier = s3},
                    new Product { Name = "Magic Mattress", 
                        Description = "Fits everyone perfectly", Image = "magic_mattress.jpg",
                        Category = "Magic", Price = 800, Supplier = s2, 
                        Ratings = new List<Rating> {
                            new Rating {Stars = 5}}}
                    );
                context.SaveChanges();

            
            }
        }
    }
}
