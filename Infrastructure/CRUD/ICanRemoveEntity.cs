﻿namespace Infrastructure.CRUD
{
    public interface ICanRemoveEntity<TEntity> where TEntity : class
    {
        void Remove(TEntity entity);
    }
}