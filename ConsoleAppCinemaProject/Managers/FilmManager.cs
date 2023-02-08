using ConsoleAppCinemaProject.Models;
using Core.Models;
using Core.Services.Contracts;
namespace ConsoleAppCinemaProject.Managers
{
    internal class FilmManager : ICrudService, IPrintService
    {
        private Film[] _film = new Film[9];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
            if (_currentIndex > 8)
            {
                Console.WriteLine("Sistemde yalniz 9 Film movcuddur");
                return;
            }

            _film[_currentIndex++] = (Film)entity;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Entity Get(int id)
        {
            for (int i = 0; i < _film.Length; i++)
            {
                if (_film[i] == null)
                    continue;

                if (_film[i].Id == id)
                    return _film[i];
            }

            Console.WriteLine("Film not found");
            return null;
        }

        public Entity[] GetAll()
        {
            return _film;
        }

        public void Print()
        {
            foreach (var item in _film)
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
