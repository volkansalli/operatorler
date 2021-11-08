using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
        //Atama ve İşlemli Atama Operatörleri (=, +=, -=, *=, /=)
        int i=0;
        i+=1;
        Console.WriteLine(i);

        //Mantıksal Operatörler (||, &&, !)
        //İlişkisel Operatörler (==,!=, <, >, >=,<=)
        int x=0;
        if(x!=1)
        Console.WriteLine(x);

        
        //Aritmetik (+, -, *, /, %, ++, --)
        x++;
        Console.WriteLine(x);
        }
    }
}
