using System;
using Blog.Model;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public class DeleteTagsScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Deletando uma Tag");
            Console.WriteLine("---------------------");

            Console.Write("Qual o Id da tag que deseja Excluir: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuTagsScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Tag Deletada com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel Deleta a Tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}