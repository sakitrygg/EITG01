using Titanic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Titanic.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Do you love working from home or would you rather be in the office? Is there a balance of both that you like best?", Description="Virtual Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What’s the hardest part about working virtually for you? The easiest?", Description ="Virtual Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Do you have a dedicated office space at home?", Description ="Virtual Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Show us your office space!", Description="Virtual Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Where do you work most frequently from at home? Your office? Your kitchen table? The backyard? Your bed?", Description="Virtual Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Be honest, how often do you work from bed?", Description="Virtual Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What did you eat for breakfast?", Description="Virtual Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What does your morning routine look like when working from home?", Description="Virtual Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What’s your number one tip for combating distractions when working from home?", Description="Virtual Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "How do you stay productive and motivated working virtually?", Description="Virtual Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What does your typical work from home uniform look like?", Description="Spicy" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "How many cups of coffee, tea, or beverage-of-choice do you have each morning?", Description="Virtual Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Are you an early bird or night owl?", Description="Virtual Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What about showers? Do you prefer morning or night?", Description="Virtual Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What’s one thing we could do to improve our virtual meetings?", Description="Virtual Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What’s your favorite flower or plant?", Description="Virtual Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What’s your caffeinated beverage of choice? Coffee? Cola? Tea?", Description="Virtual Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What’s your favorite scent?", Description="Virtual Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What’s your favorite scent?", Description="Virtual Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What’s the last great TV show or movie you wanted?", Description="Virtual Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Best book you’ve ever read?", Description="Virtual Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Best professional development book you’ve ever read?", Description="Virtual Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "If you could learn one new professional skill, what would it be?", Description="Virtual Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "If you could learn one new personal skill, what would it be?", Description="Virtual Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What’s your favorite way to get in some exercise?", Description="Virtual Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "If you could write a book, what genre would you write it in? Mystery? Thriller? Romance? Historical fiction? Non-fiction?", Description="Virtual Icebreaker" },


                new Item { Id = Guid.NewGuid().ToString(), Text = "What is one article of clothing that someone could wear that would make you walk out on a date with them?", Description="Funny Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "The zombie apocalypse is coming, who are 3 people you want on your team?", Description="Funny Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What is your most used emoji?", Description="Funny Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What was the worst style choice you ever made?", Description="Funny Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What was the worst haircut you ever had?", Description="Funny Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Who was your childhood actor/actress crush?", Description="Funny Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "If you were a wrestler what would be your entrance theme song?", Description="Funny Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Have you ever been told you look like someone famous, who was it?", Description="Funny Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "If you could bring back any fashion trend what would it be?", Description="Funny Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What’s the most embarrassing fashion trend you used to rock?", Description="Funny Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What did you name your first car?", Description="Funny Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Does your current car have a name? What is it?", Description="Funny Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "You have your own late night talk show, who do you invite as your first guest?", Description="Funny Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "If a movie was made of your life what genre would it be, who would play you?", Description="Funny Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "If you were famous, what would you be famous for?", Description="Funny Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "You have to sing karaoke, what song do you pick?", Description="Funny Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What was your least favorite food as a child? Do you still hate it or do you love it now?", Description="Funny Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "If you had to eat one meal everyday for the rest of your life what would it be?", Description="Funny Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "If you were left on a deserted island with either your worst enemy or no one, which would you choose? Why?", Description="Funny Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "If aliens landed on earth tomorrow and offered to take you home with them, would you go?", Description="Funny Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "60s, 70s, 80s, 90s: Which decade do you love the most and why?", Description="Funny Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What’s your favorite sandwich and why?", Description="Funny Icebreaker" },


                new Item { Id = Guid.NewGuid().ToString(), Text = "What’s the best piece of advice you’ve ever been given?", Description="Great Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "When you die, what do you want to be remembered for?", Description="Great Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What is your favorite item you’ve bought this year?", Description="Great Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What would be the most surprising scientific discovery imaginable?", Description="Great Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What is your absolute dream job?", Description="Great Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What would your talent be if you were Miss or Mister World?", Description="Great Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What would the title of your autobiography be?", Description="Great Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Say you’re independently wealthy and don’t have to work, what would you do with your time?", Description="Great Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "If you had to delete all but 3 apps from your smartphone, which ones would you keep?", Description="Great Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What is your favorite magical or mythological animal?", Description="Great Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What does your favorite shirt look like?", Description="Great Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Who is your favorite Disney hero or heroine? Would you trade places with them?", Description="Great Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What would your dream house be like?", Description="Great Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "If you could add anyone to Mount Rushmore who would it be; why?", Description="Great Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "You’re going sail around the world, what’s the name of your boat?", Description="Great Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What fictional family would you be a member of?", Description="Great Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What is your favorite television network?", Description="Great Icebreaker" },

                new Item { Id = Guid.NewGuid().ToString(), Text = "What sport would you compete in if you were in the Olympics?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Who is the better businessman or business woman and why? (Example: Justin Timberlake or Justin Bieber?)", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What was the worst job you ever had?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "You can have anyone fictional as your imaginary friend, who do you choose and why?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What would your superpower be and why?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Which band / artist – dead or alive would play at your funeral?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "As a child, what did you want to be when you grew up?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What’s your favorite tradition or holiday?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What fictional world or place would you like to visit?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What is your favorite breakfast food?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What is your favorite time of the day and why?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Coffee or tea?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Teleportation or flying?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What is your favorite TV show?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What book, movie read/seen recently you would recommend and why?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What breed of dog would you be?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "If you had a time machine, would go back in time or into the future?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Do you think you could live without your smartphone (or other technology item) for 24 hours?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What is your favorite dessert?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What was your favorite game to play as a child?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Are you a traveler or a homebody?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What’s one career you wish you could have?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What fictional world or place would you like to visit?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What’s your favorite place of all the places you’ve travelled?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Have you ever met your idol or someone you revere greatly?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Have you ever completed anything on your “bucket list”?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Do you have a favorite plant?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What did you have for breakfast this morning?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What was the country you last visited outside of United States?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What’s is one thing we don’t know about you?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What is your favorite meal to cook and why?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Are you a morning person or a night person?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What is your favorite musical instrument and why?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Are you a cat person or a dog person?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What languages do you know how to speak?", Description="Icebreakers for Meetings" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Popcorn or M&Ms?", Description="Icebreakers for Meetings" },

                new Item { Id = Guid.NewGuid().ToString(), Text = "What’s the weirdest food you’ve ever eaten?", Description="Awkward, Weird Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What’s the most out-of-character thing you’ve ever done?", Description="Awkward, Weird Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What is your cellphone wallpaper?", Description="Awkward, Weird Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "You can have an unlimited supply of one thing for the rest of your life, what is it? Sushi? Scotch Tape?", Description="Awkward, Weird Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What’s your best scar story?", Description="Awkward, Weird Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Would you go with aliens if they beamed down to Earth?", Description="Awkward, Weird Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Are you sunrise, daylight, twilight, or nighttime? Why?", Description="Awkward, Weird Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What season would you be?", Description="Awkward, Weird Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Are you a good dancer?", Description="Awkward, Weird Icebreaker" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "What fruit or vegetable would you most want to be?", Description="Awkward, Weird Icebreaker" }
                

            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }
        public void ClearAllItems ()
        {
            items.Clear();
        }


        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}