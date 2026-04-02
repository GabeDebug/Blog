namespace Blog.Screens.TagScreens
{
    public class TagScreens
    {
        public static void Load()
        {
            Console.Clear(); // vai limpar o Console
            Console.WriteLine("Gestão de Tags");
            Console.WriteLine("-------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar tags");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);
            
            switch (option)
            {
                case 1: 
                    .Load();
                    break;
                case 2:
                    .Load();
                    break;
                default: Load(); break;
            }
        }
    }
}