using Microsoft.EntityFrameworkCore;
using QandA_Vyapp.Db.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QandA_Vyapp.Db.DTO;

namespace QandA_Vyapp.Db
{
    public class FAQDbContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }

        public FAQDbContext(DbContextOptions<FAQDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    Id = 1,
                    QuestionText = "How do I purchase a ticket?",
                    AnswerText = "You can buy your ticket from: Vy.no, Our app, Our ticket vending machines, A staffed station or a Narvesen convenience store, Onboard conductor or Customer Service"
                },
                new Question
                {
                    Id = 2,
                    QuestionText = "Is there WiFi service on board?",
                    AnswerText = "In general, all Vy regional trains provide free WiFi on board. We also provide WiFi on most of our local trains. Exceptions are some trains on the Ski local train, Bratsberg Line, Arendal Line, Jær Line, Spikkestad–Asker–Lillestrøm, and Stabekk–Moss routes. On the Gjøvik Line, only passengers in carriages with seat reservation have WiFi access."
                },
                new Question
                {
                    Id = 3,
                    QuestionText = "Are there power outlets on board?",
                    AnswerText = "There are no power outlets on old local trains, but on new local trains (called Flirt trains) you will find outlets at every seat.\nTrains on the lines Lillehammer–Oslo–Drammen, Eidsvoll–Oslo–Skien and Oslo–Halden–Gothenburg have power outlets by all seats.However, old train types that are used as extra trains during rush hour have outlets only in the Komfort compartment.\nTrains on the lines Oslo–Stavanger, Oslo–Bergen, Oslo–Trondheim and Trondheim–Bodø have power outlets at every seat.\nTrains on Trønderbanen, Meråkerbanen, Rørosbanen and Raumabanen have power outlets at a few seats.\nThere are power outlets in all sleeper compartments. The outlets are 230V."
                },
                new Question
                {
                    Id = 4,
                    QuestionText = "Who qualifies for senior tickets?",
                    AnswerText = "The senior citizens (Honnør) ticket is for riders 67 years or older, or on disability, blind, or visually impaired. They get a 50 percent discount"
                },
                new Question
                {
                    Id = 5,
                    QuestionText = "What is a travel payment card?",
                    AnswerText = "With a travel payment card you can travel within the Oslo and Akershus region on Vy and Ruter transportation using “refillable” electronic tickets. Vy and Ruter cooperate on the electronic travel payment card system.\nYou can buy travel payment cards from Customer Service or at a staffed station."
                },
                new Question
                {
                    Id = 6,
                    QuestionText = "Can I reserve a seat on board?",
                    AnswerText = "On long-distance regional trains, Raumabanen and Rørosbanen, seat reservation is included in the price. When you book your ticket online or in the app, there is a step where you can choose where in the train you would like to sit. In these trains, you can reserve a free space next to you for the price of an ordinary adult ticket or Minipris low-cost ticket.\nOn short - distance regional trains in Eastern Norway, you can buy a seat reservation as a supplement to your single ticket or season ticket.For seat reservation, you can use a seat map to reserve any seat in a separate seat reservation carriage – at a reasonable price.You can do this several weeks in advance of departure.Seats that are not reserved may be used by other passengers.This enables us to use the entire train."
                },
                new Question
                {
                    Id = 7,
                    QuestionText = "How do I change my seat reservation?",
                    AnswerText = "To change the seat selection for a paid single ticket you must first cancel the ticket. You can then buy a new ticket with the required seat selection. You can also contact the on-board staff on your train – if they have seats available that better match your requirements, you can use these vacant seats."
                },
                new Question
                {
                    Id = 8,
                    QuestionText = "Where do I find route timetables?",
                    AnswerText = "You can quickly and easily search train schedules in our journey planner or app. You will also find departure and arrival times in our timetables."
                }
            );
        }
    }
}
