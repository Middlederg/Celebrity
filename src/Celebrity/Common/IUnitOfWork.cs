using System.Threading.Tasks;

namespace Celebrity
{
    public interface IUnitOfWork
    {
        void Complete();
        Task CompleteAsync();
    }

  
}
