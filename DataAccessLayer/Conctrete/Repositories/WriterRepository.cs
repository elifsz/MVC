﻿using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Conctrete.Repositories
{
    public class WriterRepository : IWriterDal
    {
        Context c = new Context();
        DbSet<Writer> _object;
        public void Delete(Writer p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Delete(Writer p)
        {
            throw new NotImplementedException();
        }

        public void Insert(Writer p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public void Insert(Writer p)
        {
            throw new NotImplementedException();
        }

        public List<Writer> List()
        {
            return _object.ToList();
        }

        public List<Writer> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Writer> List(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Writer p)
        {
            c.SaveChanges();
        }

        public void Update(Writer p)
        {
            throw new NotImplementedException();
        }

        List<Writer> IRepository<Writer>.List()
        {
            throw new NotImplementedException();
        }
    }
}
