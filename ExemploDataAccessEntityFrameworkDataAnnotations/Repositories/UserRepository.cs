using ExemploDataAccessEntityFrameworkDataAnnotations.Data;
using ExemploDataAccessEntityFrameworkDataAnnotations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDataAccessEntityFrameworkDataAnnotations.Repositories
{
    public class UserRepository
    {
        // ---------------------------------------------------------- CRUD USER --------------------------------------------------------------------------
        public bool InsertUser(User user)
        {
            try
            {
                using var context = new BlogEntityDataContext();
                //Adicionando o User ao DbSet que condiz com a tabela da mesma dentro do DataContext
                context.Users.Add(user);

                //Enviando as execuções ao banco de dados real
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateUser(User user)
        {
            try
            {
                using var context = new BlogEntityDataContext();
                //Alterando o User ao DbSet que condiz com a tabela da mesma dentro do DataContext
                context.Users.Update(user);

                //Enviando as execuções ao banco de dados real
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool RemoveUser(User user)
        {
            try
            {
                using var context = new BlogEntityDataContext();
                //Removendo o User ao DbSet que condiz com a tabela da mesma dentro do DataContext
                context.Users.Remove(user);

                //Enviando as execuções ao banco de dados real
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<User> SelectListUser()
        {
            try
            {
                using var context = new BlogEntityDataContext();
                //Buscando o User no banco de dados
                var users = context
                   .Users
                    .OrderBy(x => x.Id);

                return users.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public User SelectUserId(int id)
        {
            try
            {
                using var context = new BlogEntityDataContext();
                //Buscando o User no banco de dados
                var user = context
                   .Users
                    .FirstOrDefault(x => x.Id == id);

                return user;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
