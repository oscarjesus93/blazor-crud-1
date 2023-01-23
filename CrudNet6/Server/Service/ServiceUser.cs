using CrudNet6.Server.Models;
using CrudNet6.Shared;

namespace CrudNet6.Server.Service
{
    public class ServiceUser : IServiceUser
    {

        protected readonly DemoBlazorContext _Context;

        public ServiceUser(DemoBlazorContext context)
        {
            _Context = context;
        }        

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            try
            {

                return _Context.Users.ToList();

            } catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public void PostUser(User user)
        {
            throw new NotImplementedException();
        }

        public void PutUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
