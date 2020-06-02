﻿namespace Infrastructure.CRUD
{
    public interface IUpdateEntity<TEntity> where TEntity : class
    {
        void Update(TEntity entity);
    }
}