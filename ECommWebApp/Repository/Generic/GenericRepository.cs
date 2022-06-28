using ECommWebApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommWebApp.Repository.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected AppDbContext _context;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public T Get(object id)
        {
            try
            {
                return _context.Set<T>().Find(id) ?? throw new NullReferenceException($"{id} doesn't exist.");
                //var entity = _context.Set<T>().Find(id);
                //if (entity != null)
                //    return entity;
                //return ;
            } catch(Exception e)
            {
                Console.WriteLine(e);
            }
            throw new NullReferenceException($"{_context.Set<T>().GetType()} {id} doesn't exist.");
        }
        public bool Add(T entity)
        {
            try
            {
               _context.Set<T>().Add(entity);
               return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }
        public bool AddRange(List<T> entities)
        {
            try
            {
                _context.Set<T>().AddRange(entities);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }
        public T Update(object id, T entity)
        {
            try 
            {
                //T exists = Get(id);
                //if (exists.Equals(entity))
                //{
                return _context.Set<T>().Update(entity).Entity;
                //}
                //throw new NullReferenceException($"{entity.GetType()} {id} doesn't exist.");
            }
            catch(Exception e) { Console.WriteLine(e); }
            throw new DbUpdateException($"Cannot update the Database.");
        }
        public bool Remove(object id)
        {
            try
            {
                T entity = Get(id);
                return Remove(entity);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }
        public bool Remove(T entity)
        {
            try
            {
                _context.Set<T>().Remove(entity);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }
        public bool RemoveRange(List<T> entities)
        {
            try
            {
                _context.Set<T>().RemoveRange(entities);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }
        public bool Save()
        {
            int result= _context.SaveChanges();
            return result > 0;
        }

        

        //public int Update(T entity)
        //{
        //    try
        //    {
        //        int index = list.IndexOf(entity);
        //        if (index>=0)
        //        {
        //            if (list[index].Equals(entity))
        //                return 0; //already exists
        //            list[index] = entity;
        //            return 1; //successfuly updated
        //        }
        //        return -1; //doesn't exist
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }
        //    return -2; //Exception
        //}
    }
}
