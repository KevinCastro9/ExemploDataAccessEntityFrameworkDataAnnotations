using ExemploDataAccessEntityFrameworkDataAnnotations.Data;
using ExemploDataAccessEntityFrameworkDataAnnotations.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDataAccessEntityFrameworkDataAnnotations.Repositories
{
    public class PostRepository
    {
        // ---------------------------------------------------------- CRUD POST --------------------------------------------------------------------------
        public bool InsertPost(Post post)
        {
            try
            {
                using var context = new BlogEntityDataContext();
                //Adicionando o Post ao DbSet que condiz com a tabela da mesma dentro do DataContext
                context.Posts.Add(post);

                //Enviando as execuções ao banco de dados real
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdatePost(Post post)
        {
            try
            {
                using var context = new BlogEntityDataContext();
                //Alterando o Post ao DbSet que condiz com a tabela da mesma dentro do DataContext
                context.Posts.Update(post);

                //Enviando as execuções ao banco de dados real
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool RemovePost(Post post)
        {
            try
            {
                using var context = new BlogEntityDataContext();
                //Removendo o Post ao DbSet que condiz com a tabela da mesma dentro do DataContext
                context.Posts.Remove(post);

                //Enviando as execuções ao banco de dados real
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Post> SelectListPost()
        {
            try
            {
                using var context = new BlogEntityDataContext();
                //Buscando o post no banco de dados
                var posts = context
                   .Posts
                    .Include(x => x.Author)
                    .Include(x => x.Category)
                    //.ThenInclude(x=>x.FilhoCategory)  //É utilizado para quando outra tabela que esteja dentro da tabela filha
                    .OrderBy(x => x.LastUpdateDate);

                return posts.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Post SelectPostId(int id)
        {
            try
            {
                using var context = new BlogEntityDataContext();
                // Buscando o post no banco de dados
                var post = context
                   .Posts
                    .Include(x => x.Author)
                    .Include(x => x.Category)
                    .OrderBy(x => x.LastUpdateDate)
                    .FirstOrDefault(x => x.Id == id);

                return post;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
