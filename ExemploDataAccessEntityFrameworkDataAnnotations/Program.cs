





/* É NECESSARIO INSTALAR OS PACOTES "Microsoft.EntityFrameworkCore" E "Microsoft.EntityFrameworkCore.SqlServer" */



using ExemploDataAccessEntityFrameworkDataAnnotations.Data;
using ExemploDataAccessEntityFrameworkDataAnnotations.Models;
using ExemploDataAccessEntityFrameworkDataAnnotations.Data;
using Microsoft.EntityFrameworkCore;

using var context = new BlogEntityDataContext();

var role = new Role()
{
    Name = "Autor new",
    Slug = "authorNew"
};

var tag = new Tag()
{
    Name = "VB.NET",
    Slug = "VisualBasic"
};

var user = new User
{
    Name = "André Baltieri",
    Slug = "andrebaltieri",
    Email = "andre@balta.io",
    Bio = "9x Microsoft MVP",
    Image = "https://balta.io",
    PasswordHash = "123098457"
};

var category = new Category { Name = "Backend", Slug = "backend" };

var post = new Post
{
    Author = SelectUserId(14),
    Category = SelectCategoryId(11),
    Body = "<p>Hello world</p>",
    Slug = "comecando-com-ef-core",
    Summary = "Neste artigo vamos aprender EF core",
    Title = "Começando com EF Core",
    CreateDate = DateTime.Now,
    LastUpdateDate = DateTime.Now,
};

// -------------------------------------------------------------  CATEGORY   -----------------------------------------------------------

//var insertCategoryReturn = InsertCategory(category);
//if (insertCategoryReturn == true)
//    Console.WriteLine("Insert de Category Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o insert de Category");

//var selectUpdateCategoryReturn = SelectCategoryId(10);
//selectUpdateCategoryReturn.Name = "BackEnd Update";
//var updateCategoryReturn = UpdateCategory(selectUpdateCategoryReturn);
//if (updateCategoryReturn == true)
//    Console.WriteLine("Update de Category Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o update de Category");

//var selectDeleteCategoryReturn = SelectCategoryId(10);
//var removeCategoryReturn = RemoveCategory(selectDeleteCategoryReturn);
//if (removeCategoryReturn == true)
//    Console.WriteLine("Remove de Category Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o remove de Category");

//var selectListCategoryReturn = SelectListCategory();
//foreach (var selectCategory in selectListCategoryReturn)
//    Console.WriteLine($"{selectCategory.Id} - {selectCategory.Name}");

//var selectCategoryReturn = SelectCategoryId(11);
//Console.WriteLine($"{selectCategoryReturn.Id} - {selectCategoryReturn.Name}");

// -------------------------------------------------------------  USER   -----------------------------------------------------------

//var insertUserReturn = InsertUser(user);
//if (insertUserReturn == true)
//    Console.WriteLine("Insert do User Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o insert do User");

//var selectUpdateUserReturn = SelectUserId(13);
//selectUpdateUserReturn.Name = "André Baltieri Update";
//var updateUserReturn = UpdateUser(selectUpdateUserReturn);
//if (updateUserReturn == true)
//    Console.WriteLine("Update do User Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o update do User");

//var selectDeleteUserReturn = SelectUserId(13);
//var removeUserReturn = RemoveUser(selectDeleteUserReturn);
//if (removeUserReturn == true)
//    Console.WriteLine("Remove do User Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o remove do User");

//var selectListUserReturn = SelectListUser();
//foreach (var selectUser in selectListUserReturn)
//    Console.WriteLine($"{selectUser.Id} - {selectUser.Name}");

//var selectUserReturn = SelectUserId(14);
//Console.WriteLine($"{selectUserReturn.Id} - {selectUserReturn.Name}");

// -------------------------------------------------------------  POST   -----------------------------------------------------------

//var insertPostReturn = InsertPost(post);
//if (insertPostReturn == true)
//    Console.WriteLine("Insert do Post Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o insert do Post");

//var selectUpdatePostReturn = SelectPostId(4);
//selectUpdatePostReturn.Title = "Começando com EF Core Update";
//selectUpdatePostReturn.Author.Name = "Update Author";
//selectUpdatePostReturn.Category.Name = "Update Category";
//var updatePostReturn = UpdatePost(selectUpdatePostReturn);
//if (updatePostReturn == true)
//    Console.WriteLine("Update do Post Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o update do Post");

//var selectDeletePostReturn = SelectPostId(4);
//var removePostReturn = RemovePost(selectDeletePostReturn);
//if (removePostReturn == true)
//    Console.WriteLine("Remove do Post Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o remove do Post");

//var selectListPostReturn = SelectListPost();
//foreach (var selectPost in selectListPostReturn)
//    Console.WriteLine($"{selectPost.Id} - {selectPost.Title}");

//var selectPostReturn = SelectPostId(5);
//Console.WriteLine($"{selectPostReturn.Id} - {selectPostReturn.Title}");

// -------------------------------------------------------------  ROLE   -----------------------------------------------------------

//var insertRoleReturn = InsertRole(role);
//if (insertRoleReturn == true)
//    Console.WriteLine("Insert do Role Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o insert do Role");

//var selectUpdateRoleReturn = SelectRoleId(6);
//selectUpdateRoleReturn.Name = "Autor new Update";
//var updateRoleReturn = UpdateRole(selectUpdateRoleReturn);
//if (updateRoleReturn == true)
//    Console.WriteLine("Update do Role Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o update do Role");

//var selectDeleteRoleReturn = SelectRoleId(6);
//var removeRoleReturn = RemoveRole(selectDeleteRoleReturn);
//if (removeRoleReturn == true)
//    Console.WriteLine("Remove do Role Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o remove do Role");

//var selectListRoleReturn = SelectListRole();
//foreach (var selectRole in selectListRoleReturn)
//    Console.WriteLine($"{selectRole.Id} - {selectRole.Name}");

//var selectRoleReturn = SelectRoleId(7);
//Console.WriteLine($"{selectRoleReturn.Id} - {selectRoleReturn.Name}");

// -------------------------------------------------------------  TAG   -----------------------------------------------------------

//var insertTagReturn = InsertTag(tag);
//if (insertTagReturn == true)
//    Console.WriteLine("Insert do Tag Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o insert do Tag");

//var selectUpdateTagReturn = SelectTagId(1004);
//selectUpdateTagReturn.Name = "VB.NET Update";
//var updateTagReturn = UpdateTag(selectUpdateTagReturn);
//if (updateTagReturn == true)
//    Console.WriteLine("Update do Tag Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o update do Role");

//var selectDeleteTagReturn = SelectTagId(1004);
//var removeTagReturn = RemoveTag(selectDeleteTagReturn);
//if (removeTagReturn == true)
//    Console.WriteLine("Remove do Tag Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o remove do Tag");

//var selectListTagReturn = SelectListTag();
//foreach (var selectTag in selectListTagReturn)
//    Console.WriteLine($"{selectTag.Id} - {selectTag.Name}");

//var selectTagReturn = SelectTagId(1005);
//Console.WriteLine($"{selectTagReturn.Id} - {selectTagReturn.Name}");


// ---------------------------------------------------------- CRUD CATEGORY --------------------------------------------------------------------------
bool InsertCategory(Category category)
{
    try
    {
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

bool UpdateCategory(Category category)
{
    try
    {
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

bool RemoveCategory(Category category)
{
    try
    {
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

List<Category> SelectListCategory()
{
    try
    {
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

Category SelectCategoryId(int id)
{
    try
    {
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

// ---------------------------------------------------------- CRUD USER --------------------------------------------------------------------------
bool InsertUser(User user)
{
    try
    {
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

bool UpdateUser(User user)
{
    try
    {
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

bool RemoveUser(User user)
{
    try
    {
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

List<User> SelectListUser()
{
    try
    {
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

User SelectUserId(int id)
{
    try
    {
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

// ---------------------------------------------------------- CRUD POST --------------------------------------------------------------------------
bool InsertPost(Post post)
{
    try
    {
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

bool UpdatePost(Post post)
{
    try
    {
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

bool RemovePost(Post post)
{
    try
    {
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

List<Post> SelectListPost()
{
    try
    {
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

Post SelectPostId(int id)
{
    try
    {
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

// ---------------------------------------------------------- CRUD ROLE --------------------------------------------------------------------------
bool InsertRole(Role role)
{
    try
    {
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

bool UpdateRole(Role role)
{
    try
    {
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

bool RemoveRole(Role role)
{
    try
    {
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

List<Role> SelectListRole()
{
    try
    {
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

Role SelectRoleId(int id)
{
    try
    {
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

// ---------------------------------------------------------- CRUD TAG --------------------------------------------------------------------------
bool InsertTag(Tag tag)
{
    try
    {
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

bool UpdateTag(Tag tag)
{
    try
    {
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

bool RemoveTag(Tag tag)
{
    try
    {
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

List<Tag> SelectListTag()
{
    try
    {
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

Tag SelectTagId(int id)
{
    try
    {
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