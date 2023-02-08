using ConsoleAppCinemaProject.Models;
using Core.Models;
using Core.Services.Contracts;
namespace ConsoleAppCinemaProject.Managers
{
    internal class CinemaPlusManager : ICrudService, IPrintService
    {
        private CinemaPlus[] _cinemaPlus = new CinemaPlus[1];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
            if (_currentIndex > 1)
            {
                Console.WriteLine("Sistemde yalniz 1 Cinema Plus movcuddur");
                return;
            }

            _cinemaPlus[_currentIndex++] = (CinemaPlus)entity;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Entity Get(int id)
        {
            for (int i = 0; i < _cinemaPlus.Length; i++)
            {
                if (_cinemaPlus[i] == null)
                    continue;

                if (_cinemaPlus[i].Id == id)
                    return _cinemaPlus[i];
            }

            Console.WriteLine("Cinema Plus not found");
            return null;
        }

        public Entity[] GetAll()
        {
            return _cinemaPlus;
        }

        public void Print()
        {
            foreach (var item in _cinemaPlus)
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
