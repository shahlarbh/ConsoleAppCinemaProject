﻿using Core.Models;
namespace Core.Services.Contracts
{
    public interface ICrudService
    {
        void Add(Entity entity);
        void Update (int id, Entity entity);
        void Delete (int id);
        Entity Get(int id);
        Entity[] GetAll();
    }
}
