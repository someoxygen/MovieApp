﻿using MovieApp.Models;

namespace MovieApp.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Add(T actor);
        Task Update(int id, T newActor);
        Task Delete(int id);
    }
}
