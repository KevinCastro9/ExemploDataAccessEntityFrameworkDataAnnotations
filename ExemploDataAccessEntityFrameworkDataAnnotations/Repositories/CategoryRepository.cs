using ExemploDataAccessEntityFrameworkDataAnnotations.Data;
using ExemploDataAccessEntityFrameworkDataAnnotations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDataAccessEntityFrameworkDataAnnotations.Repositories
{
    public class CategoryRepository
    {
        // ---------------------------------------------------------- CRUD CATEGORY --------------------------------------------------------------------------
        public bool InsertCategory(Category category)
        {
            try
            {
                using var context = new BlogEntityDataContext();
                //Adicionando a Category ao DbSet que condiz com a tabela da mesma dentro do DataContext
                context.Categories.Add(category);

                //Enviando as execuções ao banco de dados real
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateCategory(Category category)
        {
            try
            {
                using var context = new BlogEntityDataContext();
                //Alterando a Category ao DbSet que condiz com a tabela da mesma dentro do DataContext
                context.Categories.Update(category);

                //Enviando as execuções ao banco de dados real
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool RemoveCategory(Category category)
        {
            try
            {
                using var context = new BlogEntityDataContext();
                //Removendo a Category ao DbSet que condiz com a tabela da mesma dentro do DataContext
                context.Categories.Remove(category);

                //Enviando as execuções ao banco de dados real
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Category> SelectListCategory()
        {
            try
            {
                using var context = new BlogEntityDataContext();
                //Buscando o post no banco de dados
                var categories = context
                   .Categories
                    .OrderBy(x => x.Id);

                return categories.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Category SelectCategoryId(int id)
        {
            try
            {
                using var context = new BlogEntityDataContext();
                //Buscando o post no banco de dados
                var category = context
                   .Categories
                    .FirstOrDefault(x => x.Id == id);

                return category;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
