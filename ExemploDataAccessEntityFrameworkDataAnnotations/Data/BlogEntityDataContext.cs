using ExemploDataAccessEntityFrameworkDataAnnotations.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDataAccessEntityFrameworkDataAnnotations.Data
{
    //Especificando que o objeto é um data context através do ":DbContext"
    public class BlogEntityDataContext : DbContext
    {
        //Criando os DbSets "tabelas do bancos"
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }


        // Método de conexão ao banco     
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$");
    }
}
