namespace GS.module.entities
{
    using Base;
    using System;
    class main
    {
        public static void Main()
        {
            string key = "@@module@@";
            Console.WriteLine(Helper.Encriptar(key, "123456789"));
            //kIgh2+HJpss=

            Console.Read();
        }
    }

}
