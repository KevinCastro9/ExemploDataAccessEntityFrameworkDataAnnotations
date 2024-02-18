





/* É NECESSARIO INSTALAR OS PACOTES "Microsoft.EntityFrameworkCore" E "Microsoft.EntityFrameworkCore.SqlServer" */



using ExemploDataAccessEntityFrameworkDataAnnotations.Data;
using ExemploDataAccessEntityFrameworkDataAnnotations.Models;
using Microsoft.EntityFrameworkCore;
using ExemploDataAccessEntityFrameworkDataAnnotations.Repositories;

CategoryRepository categoryRepository = new CategoryRepository();
UserRepository userRepository = new UserRepository();
PostRepository postRepository = new PostRepository();
RoleRepository roleRepository = new RoleRepository();
TagRepository tagRepository = new TagRepository();

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
    Author = userRepository.SelectUserId(14),
    Category = categoryRepository.SelectCategoryId(11),
    Body = "<p>Hello world</p>",
    Slug = "comecando-com-ef-core",
    Summary = "Neste artigo vamos aprender EF core",
    Title = "Começando com EF Core",
    CreateDate = DateTime.Now,
    LastUpdateDate = DateTime.Now,
};

// -------------------------------------------------------------  CATEGORY   -----------------------------------------------------------

//var insertCategoryReturn = categoryRepository.InsertCategory(category);
//if (insertCategoryReturn == true)
//    Console.WriteLine("Insert de Category Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o insert de Category");

//var selectUpdateCategoryReturn = categoryRepository.SelectCategoryId(10);
//selectUpdateCategoryReturn.Name = "BackEnd Update";
//var updateCategoryReturn = categoryRepository.UpdateCategory(selectUpdateCategoryReturn);
//if (updateCategoryReturn == true)
//    Console.WriteLine("Update de Category Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o update de Category");

//var selectDeleteCategoryReturn = categoryRepository.SelectCategoryId(10);
//var removeCategoryReturn = categoryRepository.RemoveCategory(selectDeleteCategoryReturn);
//if (removeCategoryReturn == true)
//    Console.WriteLine("Remove de Category Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o remove de Category");

var selectListCategoryReturn = categoryRepository.SelectListCategory();
foreach (var selectCategory in selectListCategoryReturn)
    Console.WriteLine($"{selectCategory.Id} - {selectCategory.Name}");

var selectCategoryReturn = categoryRepository.SelectCategoryId(11);
Console.WriteLine($"{selectCategoryReturn.Id} - {selectCategoryReturn.Name}");

// -------------------------------------------------------------  USER   -----------------------------------------------------------

//var insertUserReturn = userRepository.InsertUser(user);
//if (insertUserReturn == true)
//    Console.WriteLine("Insert do User Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o insert do User");

//var selectUpdateUserReturn = userRepository.SelectUserId(13);
//selectUpdateUserReturn.Name = "André Baltieri Update";
//var updateUserReturn = userRepository.UpdateUser(selectUpdateUserReturn);
//if (updateUserReturn == true)
//    Console.WriteLine("Update do User Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o update do User");

//var selectDeleteUserReturn = userRepository.SelectUserId(13);
//var removeUserReturn = userRepository.RemoveUser(selectDeleteUserReturn);
//if (removeUserReturn == true)
//    Console.WriteLine("Remove do User Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o remove do User");

var selectListUserReturn = userRepository.SelectListUser();
foreach (var selectUser in selectListUserReturn)
    Console.WriteLine($"{selectUser.Id} - {selectUser.Name}");

var selectUserReturn = userRepository.SelectUserId(14);
Console.WriteLine($"{selectUserReturn.Id} - {selectUserReturn.Name}");

// -------------------------------------------------------------  POST   -----------------------------------------------------------

//var insertPostReturn = postRepository.InsertPost(post);
//if (insertPostReturn == true)
//    Console.WriteLine("Insert do Post Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o insert do Post");

//var selectUpdatePostReturn = postRepository.SelectPostId(4);
//selectUpdatePostReturn.Title = "Começando com EF Core Update";
//selectUpdatePostReturn.Author.Name = "Update Author";
//selectUpdatePostReturn.Category.Name = "Update Category";
//var updatePostReturn = postRepository.UpdatePost(selectUpdatePostReturn);
//if (updatePostReturn == true)
//    Console.WriteLine("Update do Post Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o update do Post");

//var selectDeletePostReturn = postRepository.SelectPostId(4);
//var removePostReturn = postRepository.RemovePost(selectDeletePostReturn);
//if (removePostReturn == true)
//    Console.WriteLine("Remove do Post Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o remove do Post");

var selectListPostReturn = postRepository.SelectListPost();
foreach (var selectPost in selectListPostReturn)
    Console.WriteLine($"{selectPost.Id} - {selectPost.Title}");

var selectPostReturn = postRepository.SelectPostId(5);
Console.WriteLine($"{selectPostReturn.Id} - {selectPostReturn.Title}");

// -------------------------------------------------------------  ROLE   -----------------------------------------------------------

//var insertRoleReturn = roleRepository.InsertRole(role);
//if (insertRoleReturn == true)
//    Console.WriteLine("Insert do Role Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o insert do Role");

//var selectUpdateRoleReturn = roleRepository.SelectRoleId(6);
//selectUpdateRoleReturn.Name = "Autor new Update";
//var updateRoleReturn = roleRepository.UpdateRole(selectUpdateRoleReturn);
//if (updateRoleReturn == true)
//    Console.WriteLine("Update do Role Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o update do Role");

//var selectDeleteRoleReturn = roleRepository.SelectRoleId(6);
//var removeRoleReturn = roleRepository.RemoveRole(selectDeleteRoleReturn);
//if (removeRoleReturn == true)
//    Console.WriteLine("Remove do Role Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o remove do Role");

var selectListRoleReturn = roleRepository.SelectListRole();
foreach (var selectRole in selectListRoleReturn)
    Console.WriteLine($"{selectRole.Id} - {selectRole.Name}");

var selectRoleReturn = roleRepository.SelectRoleId(7);
Console.WriteLine($"{selectRoleReturn.Id} - {selectRoleReturn.Name}");

// -------------------------------------------------------------  TAG   -----------------------------------------------------------

//var insertTagReturn = tagRepository.InsertTag(tag);
//if (insertTagReturn == true)
//    Console.WriteLine("Insert do Tag Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o insert do Tag");

//var selectUpdateTagReturn = tagRepository.SelectTagId(1004);
//selectUpdateTagReturn.Name = "VB.NET Update";
//var updateTagReturn = tagRepository.UpdateTag(selectUpdateTagReturn);
//if (updateTagReturn == true)
//    Console.WriteLine("Update do Tag Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o update do Role");

//var selectDeleteTagReturn = tagRepository.SelectTagId(1004);
//var removeTagReturn = tagRepository.RemoveTag(selectDeleteTagReturn);
//if (removeTagReturn == true)
//    Console.WriteLine("Remove do Tag Realizado com sucesso");
//else
//    Console.WriteLine("Não foi possivel realizar o remove do Tag");

var selectListTagReturn = tagRepository.SelectListTag();
foreach (var selectTag in selectListTagReturn)
    Console.WriteLine($"{selectTag.Id} - {selectTag.Name}");

var selectTagReturn = tagRepository.SelectTagId(1005);
Console.WriteLine($"{selectTagReturn.Id} - {selectTagReturn.Name}");