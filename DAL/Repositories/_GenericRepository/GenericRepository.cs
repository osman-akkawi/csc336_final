using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories._GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class //not gonna do dependency injection bcz
                                                                              //im not gonna create object (new generic)
    {
        public readonly DbSet<T> _dbSet;
        public readonly AirplaneSystemContext _AirplaneSystemContext; //if i want to use major,i call by umscontext not
                                                //dbset bcz dbset i wrote only for faculties
        public GenericRepository(AirplaneSystemContext AirplaneSystemContext)
        {
            _AirplaneSystemContext = AirplaneSystemContext;
            _dbSet = AirplaneSystemContext.Set<T>();
        }
        public T Add(T entity)
        {
            var result = _dbSet.Add(entity);//posso tirar o var result =
            _AirplaneSystemContext.SaveChanges(); //save i always do for the original context
            return entity; // i can write result.Entity
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }


        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public T Update(T faculty)
        {
            _dbSet.Update(faculty);
            try
            {
                _AirplaneSystemContext.SaveChanges();
                ;
            }
            catch (Exception ex) { }
            return faculty;
        }

        public bool Delete(T faculty)
        {
            _dbSet.Remove(faculty);
            try
            {
                _AirplaneSystemContext.SaveChanges();
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
