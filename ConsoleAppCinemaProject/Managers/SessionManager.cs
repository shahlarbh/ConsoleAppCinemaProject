using ConsoleAppCinemaProject.Enum;
using ConsoleAppCinemaProject.Models;
using Core.Models;
using Core.Services.Contracts;
namespace ConsoleAppCinemaProject.Managers
{
    internal class SessionManager : ICrudService, IPrintService
    {
        private Session[] _session = new Session[9];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
            if (_currentIndex > 8)
            {
                Console.WriteLine("Sistemde yalniz 9 Session movcuddur");
                return;
            }

            _session[_currentIndex++] = (Session)entity;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Entity Get(int id)
        {
            for (int i = 0; i < _session.Length; i++)
            {
                if (_session[i] == null)
                    continue;

                if (_session[i].Id == id)
                    return _session[i];
            }

            Console.WriteLine("Session not found");
            return null;
        }

        public Entity[] GetAll()
        {
            return _session;
        }

        public void Print()
        {
            foreach (var item in _session)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }

        public void PrintSessionByCinema(int cinemaId) 
        {
            foreach (var item in _session)
            {
                if(item.CinemaId == cinemaId)
                    Console.WriteLine(item);
            }
        }

        public void PrintSessionSeats(Session session) 
        {
            int rowCount = 0;
            int[,] seats = new int[10, 10];

            Console.Write("    ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1} ");
            }

            Console.WriteLine();

            for (int row = 0; row < 10; row++)
            {
                Console.Write($"{row + 1,-3} ");

                for (int column = 0; column < 10; column++)
                {
                    Console.Write($"{seats[row, column] = (int)State.Empty} ");
                }

                Console.WriteLine();
            }
        }

        public void ShowEmptySeats(Session session)
        {
            Console.Write("   ");

            for (int i = 0; i < session.Seats.GetLength(1); i++)
                Console.Write($"{i + 1,-3}");

            Console.WriteLine();

            for (int i = 0; i < session.Seats.GetLength(0); i++)
            {
                Console.Write($"{i + 1,-3}");

                for (int j = 0; j < session.Seats.GetLength(1); j++)
                {
                    Console.Write($"{(int)session.Seats[i, j],-3}");
                }

                Console.WriteLine();
            }
        }

        public void Update(int id, Entity entity)
        {
            throw new NotImplementedException();
        }

    }
}
