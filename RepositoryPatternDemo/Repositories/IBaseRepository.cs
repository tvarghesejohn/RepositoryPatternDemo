using System.Collections.Generic;

namespace RepositoryPatternDemo.IRepositories
{
    public interface IBaseRepository<T>
    {
        public List<T> GetAll();
        public T GetById(int id);
        public string Add(T entity);
        public string Update(T entity);
        public string Delete(int id);
    }
}
