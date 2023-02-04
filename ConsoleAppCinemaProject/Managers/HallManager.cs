using ConsoleAppCinemaProject.Models;
using Core.Models;
using Core.Services.Contracts;
namespace ConsoleAppCinemaProject.Managers
{
    internal class HallManager : ICrudService, IPrintService
    {
        private Hall[] _hall = new Hall[9];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
            if (_currentIndex > 8)
            {
                Console.WriteLine("Sistemde yalniz 9 Hall movcuddur");
                return;
            }

            _hall[_currentIndex++] = (Hall)entity;
            Console.WriteLine("Hall sisteme ugurla elave olundu");
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Entity Get(int id)
        {
            for (int i = 0; i < _hall.Length; i++)
            {
                if (_hall[i] == null)
                    continue;

                if (_hall[i].Id == id)
                    return _hall[i];
            }

            Console.WriteLine("Hall not found");
            return null;
        }

        public Entity[] GetAll()
        {
            return _hall;
        }

        public void Print()
        {
            foreach (var item in _hall)
            {
                if(item == null)
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
