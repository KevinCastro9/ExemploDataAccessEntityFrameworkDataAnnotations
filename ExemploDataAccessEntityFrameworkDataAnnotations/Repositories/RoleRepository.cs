using ExemploDataAccessEntityFrameworkDataAnnotations.Data;
using ExemploDataAccessEntityFrameworkDataAnnotations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDataAccessEntityFrameworkDataAnnotations.Repositories
{
    public class RoleRepository
    {
        // ---------------------------------------------------------- CRUD ROLE --------------------------------------------------------------------------
        public bool InsertRole(Role role)
        {
            try
            {
                using var context = new BlogEntityDataContext();
                //Adicionando o Role ao DbSet que condiz com a tabela da mesma dentro do DataContext
                context.Roles.Add(role);

                //Enviando as execuções ao banco de dados real
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateRole(Role role)
        {
            try
            {
                using var context = new BlogEntityDataContext();
                //Alterando o Role ao DbSet que condiz com a tabela da mesma dentro do DataContext
                context.Roles.Update(role);

                //Enviando as execuções ao banco de dados real
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool RemoveRole(Role role)
        {
            try
            {
                using var context = new BlogEntityDataContext();
                //Removendo o Role ao DbSet que condiz com a tabela da mesma dentro do DataContext
                context.Roles.Remove(role);

                //Enviando as execuções ao banco de dados real
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Role> SelectListRole()
        {
            try
            {
                using var context = new BlogEntityDataContext();
                //Buscando o Role no banco de dados
                var roles = context
                   .Roles
                    .OrderBy(x => x.Id);

                return roles.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Role SelectRoleId(int id)
        {
            try
            {
                using var context = new BlogEntityDataContext();
                // Buscando o Role no banco de dados
                var role = context
                   .Roles
                    .FirstOrDefault(x => x.Id == id);

                return role;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
