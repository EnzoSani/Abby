﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Abby.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //GET ALL, GET By ID FIRST OR DEFAULT, ADD, REMOVE, REMOVERANGE
        //

        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities); 
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null,
            Func<IQueryable<T>,IOrderedQueryable<T>>?  orderBy = null,
            string? includeProperties=null);
        T GetFirstOrDefault(Expression<Func<T, bool>>? filter = null, string? includeProperties=null); 
    }
}
