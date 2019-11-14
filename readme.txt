Denne webaplikasjonen er bygd med ASP.NET Core 3.0 i backend, med Entity Framework Core som database.
På frontend er det brukt nyeste versjonen av React med react-bootstrap til styling.
Axios og Fetch er brukt til å hente og sende data til og fra frontend.


For å kunne kjøre løsningen så må man gjøre dette:
0. Være sikker på at det ikke er en FAQDb.mdf fil i C:\Users\{username}
1. Rebuilde Solution i visual studio for å få installert alle node packages.
2. Kjøre løsningen.
	2.2 Hvis ingen data blir vist på nettsiden, må man kjøre løsningen en gang til. Dette er fordi databasen ikke alltid blir opprettet første gang man kjører løsningen.