using CrudNet6.Shared;

namespace CrudNet6.Server.Service
{
    public interface IServiceUser
    {

        public List<User> GetUsers();

        public User GetById(int id);

        public void PostUser(User user);

        public void PutUser(User user);

        public void DeleteUser(int id);

    }
}
