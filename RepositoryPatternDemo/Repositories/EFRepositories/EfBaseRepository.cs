using RepositoryPatternDemo.DL;
using RepositoryPatternDemo.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using BaseModel = RepositoryPatternDemo.DL.BaseModel;

namespace RepositoryPatternDemo.Repositories.EFRepositories
{
    public abstract class EfBaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        private readonly HOSPITALDBContext _context;

        public EfBaseRepository(HOSPITALDBContext context)
        {
            _context = context;
        }

        public virtual List<T> GetAll()
        {
            var entities = _context.Set<T>().ToList();
            return entities;
        }

        public virtual T GetById(int id)
        {
            var entities = _context.Set<T>().Where(x => x.Id == id).FirstOrDefault();
            return entities;
        }

        public virtual string Add(T entity)
        {
            try
            {
                _context.Set<T>().AddAsync(entity);
                _context.SaveChangesAsync();

                return "sucess";
            }
            catch(Exception)
            {
                return "fail";
            }
        }

        public virtual string Delete(int id)
        {
            try
            {
                var entity =  GetById(id);
                _context.Set<T>().Remove(entity);
                _context.SaveChangesAsync();

                return "success";
            }
            catch (Exception)
            {
                return "fail";
            }
        }

        public virtual string Update(T entity)
        {
            try
            {
                _context.Set<T>().Update(entity);
                _context.SaveChangesAsync();

                return "sucess";
            }
            catch (Exception)
            {
                return "fail";
            }
        }
    }
}
