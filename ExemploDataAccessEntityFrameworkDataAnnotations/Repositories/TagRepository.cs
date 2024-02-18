using ExemploDataAccessEntityFrameworkDataAnnotations.Data;
using ExemploDataAccessEntityFrameworkDataAnnotations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDataAccessEntityFrameworkDataAnnotations.Repositories
{
    public class TagRepository
    {
        // ---------------------------------------------------------- CRUD TAG --------------------------------------------------------------------------
        public bool InsertTag(Tag tag)
        {
            try
            {
                using var context = new BlogEntityDataContext();
                //Adicionando a Tag ao DbSet que condiz com a tabela da mesma dentro do DataContext
                context.Tags.Add(tag);

                //Enviando as execuções ao banco de dados real
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateTag(Tag tag)
        {
            try
            {
                using var context = new BlogEntityDataContext();
                //Alterando o Tag ao DbSet que condiz com a tabela da mesma dentro do DataContext
                context.Tags.Update(tag);

                //Enviando as execuções ao banco de dados real
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool RemoveTag(Tag tag)
        {
            try
            {
                using var context = new BlogEntityDataContext();
                //Removendo o Tag ao DbSet que condiz com a tabela da mesma dentro do DataContext
                context.Tags.Remove(tag);

                //Enviando as execuções ao banco de dados real
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Tag> SelectListTag()
        {
            try
            {
                using var context = new BlogEntityDataContext();
                //Buscando o Tag no banco de dados
                var tags = context
                   .Tags
                    .OrderBy(x => x.Id);

                return tags.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Tag SelectTagId(int id)
        {
            try
            {
                using var context = new BlogEntityDataContext();
                // Buscando o Tag no banco de dados
                var tag = context
                   .Tags
                    .FirstOrDefault(x => x.Id == id);

                return tag;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
