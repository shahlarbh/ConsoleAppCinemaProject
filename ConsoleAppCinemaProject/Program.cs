﻿using ConsoleAppCinemaProject.Enum;
using ConsoleAppCinemaProject.Managers;
using ConsoleAppCinemaProject.Models;
namespace ConsoleAppCinemaProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cinemaPlusManager = new CinemaPlusManager();
            var cinemaManager = new CinemaManager();
            var hallManager = new HallManager();
            var sessionManager = new SessionManager();
            var filmManager = new FilmManager();
            var ticketManager = new TicketManager(sessionManager,cinemaManager);

            var mercury = new Hall
            {
                Id = 1,
                Name = "Mercury",
                RowCount = 10,
                ColumnCount = 10,
            };

            var venera = new Hall
            {
                Id = 2,
                Name = "Venera",
                RowCount = 10,
                ColumnCount = 10,
            };

            var earth = new Hall
            {
                Id = 3,
                Name = "Earth",
                RowCount = 10,
                ColumnCount = 10,
            };

            var mars = new Hall
            {
                Id = 4,
                Name = "Mars",
                RowCount = 10,
                ColumnCount = 10,
            };

            var jupiter = new Hall
            {
                Id = 5,
                Name = "Jupiter",
                RowCount = 10,
                ColumnCount = 10,
            };

            var saturn = new Hall
            {
                Id = 6,
                Name = "Saturn",
                RowCount = 10,
                ColumnCount = 10,
            };

            var uran = new Hall
            {
                Id = 7,
                Name = "Uran",
                RowCount = 10,
                ColumnCount = 10,
            };

            var neptun = new Hall
            {
                Id = 8,
                Name = "Neptun",
                RowCount = 10,
                ColumnCount = 10,
            };

            var pluton = new Hall
            {
                Id = 9,
                Name = "Pluton",
                RowCount = 10,
                ColumnCount = 10,
            };

            var parkBulvar = new Cinema
            {
                Id = 1,
                Name = "Park Bulvar",
                Halls = new Hall[] { mercury, venera, earth }
            };

            var genclikMall = new Cinema
            {
                Id = 2,
                Name = "Genclik Mall",
                Halls = new Hall[] { mars, jupiter, saturn }
            };

            var denizMall = new Cinema
            {
                Id = 3,
                Name = "Deniz Mall",
                Halls = new Hall[] { uran, neptun, pluton }
            };

            var cinemaPlus = new CinemaPlus
            {
                Id = 1,
                Name = "Cinema Plus",
                Cinemas = new Cinema[] { parkBulvar, genclikMall, denizMall }
            };

            var theDarkKnight = new Film
            {
                Id = 1,
                Name = "The Dark Knight",
                Minute = 152,
            };

            var warrior = new Film
            {
                Id = 2,
                Name = "Warrior",
                Minute = 140,
            };

            var vForVendetta = new Film
            {
                Id = 3,
                Name = "V For Vendetta",
                Minute = 132,
            };

            var theHiddenFace = new Film
            {
                Id = 4,
                Name = "The Hidden Face",
                Minute = 97,
            };

            var lucy = new Film
            {
                Id = 5,
                Name = "Lucy",
                Minute = 90,
            };

            var deadpool = new Film
            {
                Id = 6,
                Name = "Deadpool",
                Minute = 108,
            };

            var darkFate = new Film
            {
                Id = 7,
                Name = "Dark Fate",
                Minute = 128,
            };

            var interstellar = new Film
            {
                Id = 8,
                Name = "Interstellar",
                Minute = 169,
            };

            var requiemForADream = new Film
            {
                Id = 9,
                Name = "Requiem For A Dream",
                Minute = 102,
            };

            var sessionTheDarkKnight = new Session
            {
                Id = 1,
                Film = theDarkKnight,
                Hall = mercury,
                Seats = new State[mercury.RowCount, mercury.ColumnCount],
                Price = 10,
                CinemaId = 1,
                Cinema = parkBulvar,
            };

            var sessionWarrior = new Session
            {
                Id = 2,
                Film = warrior,
                Hall = venera,
                Seats = new State[venera.RowCount, venera.ColumnCount],
                Price = 10,
                CinemaId = 1,
                Cinema = parkBulvar,
            };

            var sessionVForVendetta = new Session
            {
                Id = 3,
                Film = vForVendetta,
                Hall = earth,
                Seats = new State[earth.RowCount, earth.ColumnCount],
                Price = 10,
                CinemaId = 1,
                Cinema = parkBulvar,
            };

            var sessionTheHiddenFace = new Session
            {
                Id = 4,
                Film = theHiddenFace,
                Hall = mars,
                Seats = new State[mars.RowCount, mars.ColumnCount],
                Price = 10,
                CinemaId = 2,
                Cinema = genclikMall,
            };

            var sessionLucy = new Session
            {
                Id = 5,
                Film = lucy,
                Hall = jupiter,
                Seats = new State[jupiter.RowCount, jupiter.ColumnCount],
                Price = 10,
                CinemaId = 2,
                Cinema = genclikMall,
            };

            var sessionDeadpool = new Session
            {
                Id = 6,
                Film = deadpool,
                Hall = saturn,
                Seats = new State[saturn.RowCount, saturn.ColumnCount],
                Price = 10,
                CinemaId = 2,
                Cinema = genclikMall,
            };

            var sessionDarkFate = new Session
            {
                Id = 7,
                Film = darkFate,
                Hall = uran,
                Seats = new State[uran.RowCount, uran.ColumnCount],
                Price = 10,
                CinemaId = 3,
                Cinema = denizMall,
            };

            var sessionInterstellar = new Session
            {
                Id = 8,
                Film = interstellar,
                Hall = neptun,
                Seats = new State[neptun.RowCount, neptun.ColumnCount],
                Price = 10,
                CinemaId = 3,
                Cinema = denizMall,
            };

            var sessionRequiemForADream = new Session
            {
                Id = 9,
                Film = requiemForADream,
                Hall = pluton,
                Seats = new State[pluton.RowCount, pluton.ColumnCount],
                Price = 10,
                CinemaId = 3,
                Cinema = denizMall,
            };

            cinemaManager.Add(parkBulvar);
            cinemaManager.Add(genclikMall);
            cinemaManager.Add(denizMall);

            sessionManager.Add(sessionTheDarkKnight);
            sessionManager.Add(sessionWarrior);
            sessionManager.Add(sessionVForVendetta);
            sessionManager.Add(sessionTheHiddenFace);
            sessionManager.Add(sessionLucy);
            sessionManager.Add(sessionDeadpool);
            sessionManager.Add(sessionDarkFate);
            sessionManager.Add(sessionInterstellar);
            sessionManager.Add(sessionRequiemForADream);

            string command = "";

            do
            {
                Console.Write("Enter the command:");
                command = Console.ReadLine();

                if (command.ToLower().Equals("buy ticket"))
                {
                    ticketManager.BuyTicket();
                }

                else if (command.ToLower().Equals("show ticket"))
                {
                    ticketManager.Print();
                }

                else if (command.ToLower().Equals("show seats"))
                {
                    Console.Write("Enter the Session ID:");
                    int id = int.Parse(Console.ReadLine());

                    Session existSession = (Session)sessionManager.Get(id);

                    if (existSession == null)
                        continue;

                    Console.WriteLine(existSession);

                    sessionManager.ShowEmptySeats(existSession);
                }

                else if (command.ToLower().Equals("show cinema"))
                {
                    cinemaManager.Print();
                }

                else if (command.ToLower().Equals("choose cinema"))
                {
                    Console.Write("Enter the ID:");
                    int id = int.Parse(Console.ReadLine());

                    var existCinema = cinemaManager.Get(id);

                    if (existCinema == null)
                        continue;

                    Console.WriteLine(existCinema);
                }

                else if (command.ToLower().Equals("show session"))
                {
                    Console.Write("Enter the choosen Cinema ID:");
                    int id = int.Parse(Console.ReadLine());

                    sessionManager.PrintSessionByCinema(id);
                }

                else if (command.ToLower().Equals("choose session"))
                {
                    Console.Write("Enter the ID:");
                    int id = int.Parse(Console.ReadLine());

                    Session existSession = (Session)sessionManager.Get(id);

                    if (existSession == null)
                        continue;

                    Console.WriteLine(existSession);

                    sessionManager.PrintSessionSeats(existSession);
                }

            } while (command.ToLower() != "quit");
        }
    }
}