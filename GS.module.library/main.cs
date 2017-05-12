namespace GS.module.library
{
    using entities.Base;
    using System;
    class main
    {
        public static void Main()
        {
            string key = "@@module@@";
            string variable = Console.ReadLine();
            Console.WriteLine("*************Ini*************");
            Console.WriteLine(Helper.Encriptar(key, variable));
            Console.WriteLine("*************Fin*************");
            Console.Read();
        }
    }

}
