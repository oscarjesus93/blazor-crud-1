using CrudNet6.Server.Models;
using CrudNet6.Shared;
using Microsoft.EntityFrameworkCore;

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
            try
            {
                User? user = _Context.Users.Find(id);
                return user;

            } catch (ArgumentNullException) {

                throw new ArgumentNullException(nameof(id));

            } catch (Exception ex) {
                throw new Exception(ex.Message);
            }
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
            try
            {

                user.FechaAlta = DateTime.Now;
                _Context.Users.Add(user);
                _Context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public void PutUser(User user)
        {
            try
            {
                _Context.Entry(user).State = EntityState.Modified;
                _Context.SaveChanges();

            } catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public void DeleteUser(int id)
        {
            try
            {

                User user = _Context.Users.Find(id);

                if(user != null)
                {
                    _Context.Users.Remove(user);
                    _Context.SaveChanges();
                } else
                {
                    throw new ArgumentNullException(nameof(id));
                }
                

            }catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
