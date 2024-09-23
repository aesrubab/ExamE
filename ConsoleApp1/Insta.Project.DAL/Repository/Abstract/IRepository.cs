using ConsoleApp1.Entities.Abstract;

namespace ConsoleApp1.Insta.Project.DAL.Repository.Abstract;

public interface IRepository<T> where T : BaseEntity, new()
{
    public void Add(T entity);
    public void Update(int Id);
    public void Delete(int Id);
    public T GetById(int Id);
    public ICollection<T> GetAll();
    public void SaveChanges();

}
