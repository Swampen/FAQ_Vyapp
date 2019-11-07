using Microsoft.EntityFrameworkCore.Migrations;

namespace FAQ_Vyapp.Migrations
{
    public partial class _8SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionText = table.Column<string>(nullable: true),
                    AnswerText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "AnswerText", "QuestionText" },
                values: new object[,]
                {
                    { 1, "You can buy your ticket from: Vy.no, Our app, Our ticket vending machines, A staffed station or a Narvesen convenience store, Onboard conductor or Customer Service", "How do I purchase a ticket?" },
                    { 2, "In general, all Vy regional trains provide free WiFi on board. We also provide WiFi on most of our local trains. Exceptions are some trains on the Ski local train, Bratsberg Line, Arendal Line, Jær Line, Spikkestad–Asker–Lillestrøm, and Stabekk–Moss routes. On the Gjøvik Line, only passengers in carriages with seat reservation have WiFi access.", "Is there WiFi service on board?" },
                    { 3, @"There are no power outlets on old local trains, but on new local trains (called Flirt trains) you will find outlets at every seat.
                Trains on the lines Lillehammer–Oslo–Drammen, Eidsvoll–Oslo–Skien and Oslo–Halden–Gothenburg have power outlets by all seats.However, old train types that are used as extra trains during rush hour have outlets only in the Komfort compartment.
                Trains on the lines Oslo–Stavanger, Oslo–Bergen, Oslo–Trondheim and Trondheim–Bodø have power outlets at every seat.
                Trains on Trønderbanen, Meråkerbanen, Rørosbanen and Raumabanen have power outlets at a few seats.
                There are power outlets in all sleeper compartments. The outlets are 230V.", "Are there power outlets on board?" },
                    { 4, "The senior citizens (Honnør) ticket is for riders 67 years or older, or on disability, blind, or visually impaired. They get a 50 percent discount", "Who qualifies for senior tickets?" },
                    { 5, @"With a travel payment card you can travel within the Oslo and Akershus region on Vy and Ruter transportation using “refillable” electronic tickets. Vy and Ruter cooperate on the electronic travel payment card system.
                You can buy travel payment cards from Customer Service or at a staffed station.", "What is a travel payment card?" },
                    { 6, @"On long-distance regional trains, Raumabanen and Rørosbanen, seat reservation is included in the price. When you book your ticket online or in the app, there is a step where you can choose where in the train you would like to sit. In these trains, you can reserve a free space next to you for the price of an ordinary adult ticket or Minipris low-cost ticket.
                On short - distance regional trains in Eastern Norway, you can buy a seat reservation as a supplement to your single ticket or season ticket.For seat reservation, you can use a seat map to reserve any seat in a separate seat reservation carriage – at a reasonable price.You can do this several weeks in advance of departure.Seats that are not reserved may be used by other passengers.This enables us to use the entire train.", "Can I reserve a seat on board?" },
                    { 7, "To change the seat selection for a paid single ticket you must first cancel the ticket. You can then buy a new ticket with the required seat selection. You can also contact the on-board staff on your train – if they have seats available that better match your requirements, you can use these vacant seats.", "How do I change my seat reservation?" },
                    { 8, "You can quickly and easily search train schedules in our journey planner or app. You will also find departure and arrival times in our timetables.", "Where do I find route timetables?" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
