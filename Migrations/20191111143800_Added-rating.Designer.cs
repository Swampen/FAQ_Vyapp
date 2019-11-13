﻿// <auto-generated />
using FAQ_Vyapp.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FAQ_Vyapp.Migrations
{
    [DbContext(typeof(FAQDbContext))]
    [Migration("20191111143800_Added-rating")]
    partial class Addedrating
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QandA_Vyapp.Db.Entity.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnswerText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnswerText = "You can buy your ticket from: Vy.no, Our app, Our ticket vending machines, A staffed station or a Narvesen convenience store, Onboard conductor or Customer Service",
                            QuestionText = "How do I purchase a ticket?",
                            Rating = 20
                        },
                        new
                        {
                            Id = 2,
                            AnswerText = "In general, all Vy regional trains provide free WiFi on board. We also provide WiFi on most of our local trains. Exceptions are some trains on the Ski local train, Bratsberg Line, Arendal Line, Jær Line, Spikkestad–Asker–Lillestrøm, and Stabekk–Moss routes. On the Gjøvik Line, only passengers in carriages with seat reservation have WiFi access.",
                            QuestionText = "Is there WiFi service on board?",
                            Rating = 2
                        },
                        new
                        {
                            Id = 3,
                            AnswerText = @"There are no power outlets on old local trains, but on new local trains (called Flirt trains) you will find outlets at every seat.
Trains on the lines Lillehammer–Oslo–Drammen, Eidsvoll–Oslo–Skien and Oslo–Halden–Gothenburg have power outlets by all seats.However, old train types that are used as extra trains during rush hour have outlets only in the Komfort compartment.
Trains on the lines Oslo–Stavanger, Oslo–Bergen, Oslo–Trondheim and Trondheim–Bodø have power outlets at every seat.
Trains on Trønderbanen, Meråkerbanen, Rørosbanen and Raumabanen have power outlets at a few seats.
There are power outlets in all sleeper compartments. The outlets are 230V.",
                            QuestionText = "Are there power outlets on board?",
                            Rating = 5
                        },
                        new
                        {
                            Id = 4,
                            AnswerText = "The senior citizens (Honnør) ticket is for riders 67 years or older, or on disability, blind, or visually impaired. They get a 50 percent discount",
                            QuestionText = "Who qualifies for senior tickets?",
                            Rating = 5
                        },
                        new
                        {
                            Id = 5,
                            AnswerText = @"With a travel payment card you can travel within the Oslo and Akershus region on Vy and Ruter transportation using “refillable” electronic tickets. Vy and Ruter cooperate on the electronic travel payment card system.
You can buy travel payment cards from Customer Service or at a staffed station.",
                            QuestionText = "What is a travel payment card?",
                            Rating = 10
                        },
                        new
                        {
                            Id = 6,
                            AnswerText = @"On long-distance regional trains, Raumabanen and Rørosbanen, seat reservation is included in the price. When you book your ticket online or in the app, there is a step where you can choose where in the train you would like to sit. In these trains, you can reserve a free space next to you for the price of an ordinary adult ticket or Minipris low-cost ticket.
On short - distance regional trains in Eastern Norway, you can buy a seat reservation as a supplement to your single ticket or season ticket.For seat reservation, you can use a seat map to reserve any seat in a separate seat reservation carriage – at a reasonable price.You can do this several weeks in advance of departure.Seats that are not reserved may be used by other passengers.This enables us to use the entire train.",
                            QuestionText = "Can I reserve a seat on board?",
                            Rating = 11
                        },
                        new
                        {
                            Id = 7,
                            AnswerText = "To change the seat selection for a paid single ticket you must first cancel the ticket. You can then buy a new ticket with the required seat selection. You can also contact the on-board staff on your train – if they have seats available that better match your requirements, you can use these vacant seats.",
                            QuestionText = "How do I change my seat reservation?",
                            Rating = 19
                        },
                        new
                        {
                            Id = 8,
                            AnswerText = "You can quickly and easily search train schedules in our journey planner or app. You will also find departure and arrival times in our timetables.",
                            QuestionText = "Where do I find route timetables?",
                            Rating = -2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
