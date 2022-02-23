using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // kendi llistemizi oluşturralım.MyList generic bir class olduğunda o şekilde tanımlarız. 
            MyList<string> isimler = new MyList<string>();
            isimler.Add("mehmet");
            isimler.Add("ahmet");
            Console.WriteLine(isimler.Length);
            isimler.Add("kamil");

            Console.WriteLine(isimler.Length);


            foreach (var item in isimler.Item)
            {
                Console.WriteLine(item);
            }

        }
    }
}