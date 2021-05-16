﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //asıl gerekli olan bu
    public interface IRepository<T>
    {
        //CRUD
        //Type Name();
        List<T> List();
        void Insert(T p);

        T Get(Expression<Func<T, bool>> filter);

        void Update(T p);
        void Delete(T p);

        List<T> List(Expression<Func<T, bool>> filter);
    }
}
