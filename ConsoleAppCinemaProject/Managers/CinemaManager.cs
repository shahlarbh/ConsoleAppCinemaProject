using ConsoleAppCinemaProject.Models;
using Core.Models;
using Core.Services.Contracts;
using System;

namespace ConsoleAppCinemaProject.Managers
{
    internal class CinemaManager : ICrudService, IPrintService
    {
        private Cinema[] _cinema = new Cinema[3];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
            if (_currentIndex > 2)
            {
                Console.WriteLine("Sistemde yalniz 3 Cinema movcuddur");
                return;
            }

            _cinema[_currentIndex++] = (Cinema)entity;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Entity Get(int id)
        {
            for (int i = 0; i < _cinema.Length; i++)
            {
                if (_cinema[i] == null)
                    continue;

                if (_cinema[i].Id == id)
                    return _cinema[i];
            }

            Console.WriteLine("Cinema not found");
            return null;
        }

        public Entity[] GetAll()
        {
            return _cinema;
        }

        public void Print()
        {
            foreach (var item in _cinema)
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
