using ECommerce.Model.Base;

namespace ECommerce.BLL.Repositories.Abstracts.BaseAbstract
{
    public interface IRepository<T> where T : BaseEntity
    {    

        //List
        IEnumerable<T> GetAll();
       

        //Get
        T GetById(int id);

        //Active
        IEnumerable<T> GetActives();


        //Passive
        IEnumerable<T> GetPassives();

        //Destroy
        Task<string> DestroyData(T entity);

        //Create
        Task<string> Create(T entity);  
        

        //Update
        Task<string> Update(T entity);

        //Delete
        Task<string> Delete(T entity);

    }
}
