using System.Data.Common;

namespace Blog.Screens.TagScreens
{
    public class MenuTagsScreen
    {
        public static void Load()
        {
            Console.Clear(); // vai limpar o Console
            Console.WriteLine("Gestão de Tags");
            Console.WriteLine("-------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar tags");
            Console.WriteLine("2 - Cadastrar Tag");
            Console.WriteLine("3 - Atualizar Tag");
            Console.WriteLine("4 - Excluir Tag");
            Console.WriteLine("5 - Sair");
            Console.WriteLine();
            Console.WriteLine();

            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    ListTagScreen.Load();
                    break;
                case 2:
                    CreateTagsScreen.Load();
                    break;
                case 3:
                    UpdateTagsScreen.Load();
                    break;
                case 4:
                    DeleteTagsScreen.Load();
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
            }
        }
    }
}