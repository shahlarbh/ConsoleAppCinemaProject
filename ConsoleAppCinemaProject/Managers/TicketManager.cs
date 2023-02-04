using ConsoleAppCinemaProject.Enum;
using ConsoleAppCinemaProject.Models;
using Core.Models;
using Core.Services.Contracts;
using System.Data.Common;

namespace ConsoleAppCinemaProject.Managers
{
    internal class TicketManager : ICrudService, IPrintService
    {
        private Ticket[] _ticket = new Ticket[100];
        private int _currentIndex = 0;

        private SessionManager _sessionManager;
        private CinemaManager _cinemaManager;

        public TicketManager(SessionManager sessionManager, CinemaManager cinemaManager)
        {
            _sessionManager = sessionManager;
            _cinemaManager = cinemaManager;
        }

        public void Add(Entity entity)
        {
            if (_currentIndex > 99)
            {
                Console.WriteLine("Seansda yalniz 100 bilet movcuddur");
                return;
            }

            _ticket[_currentIndex++] = (Ticket)entity;
        }

        public void BuyTicket()
        {
            Console.WriteLine("Cinema:");
            _cinemaManager.Print();

            cinema:
            Console.Write(" Enter the Cinema ID:");
            var cinemaId = int.Parse(Console.ReadLine());

            var cinema = _cinemaManager.Get(cinemaId);

            if (cinema == null)
            {
                Console.WriteLine("Not found");

                goto cinema;
            }

            Console.WriteLine(cinema);

            Console.WriteLine("Session:");

            _sessionManager.PrintSessionByCinema(cinemaId);

            session:

            Console.Write("Session ID:");
            var sessionId = int.Parse(Console.ReadLine());

            var session = (Session)_sessionManager.Get(sessionId);

            if (session == null || session.Cinema.Id != cinema.Id) 
            {
                Console.WriteLine("Not found");

                goto session;
            }
            Console.WriteLine(session);

            _sessionManager.PrintSessionSeats(session);

        row:

            Console.Write("Choose the Row:");
            var row = int.Parse(Console.ReadLine());

            if(!(row >= 1 && row <= session.Seats.GetLength(0)))
            {
                Console.WriteLine("Row is not correct");

                goto row;
            }

        column:

            Console.Write("Choose the column");
            var column = int.Parse(Console.ReadLine());

            if (!(column >= 1 && column <= session.Seats.GetLength(1)))
            {
                Console.WriteLine("Column is not correct");

                goto column;
            }

            if (session.Seats[row - 1, column - 1] == State.Full) 
            {
                Console.WriteLine("This seat is not empty. Please, choose another one");

                goto row;
            }

            session.Seats[row - 1, column - 1] = State.Full;

            var ticket = new Ticket
            {
                Session = session,
                Row = row,
                Column = column,
            };

            Add(ticket);
            Console.WriteLine("Ticket bought");
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Entity Get(int id)
        {
            for (int i = 0; i < _ticket.Length; i++)
            {
                if (_ticket[i] == null)
                    continue;

                if (_ticket[i].Id == id)
                    return _ticket[i];
            }

            Console.WriteLine("Ticket not found");
            return null;
        }

        public Entity[] GetAll()
        {
            return _ticket;
        }

        public void Print()
        {
            foreach (var item in _ticket)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }

        public void Update(int id, Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
