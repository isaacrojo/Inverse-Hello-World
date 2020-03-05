using System;

namespace P_5_Inverse_Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            string HelloWorld = "Hello World!";
            int charCount = HelloWorld.Length;
            char[] caracteresHelloWorld = new char [charCount];

           // caracteresHelloWorld[0]

           for(int i = 0; i < HelloWorld.Length; i++) 
           {
              Console.WriteLine(HelloWorld[i]);

              int newIndex = (HelloWorld.Length) -1 - i; 

              caracteresHelloWorld[newIndex] = HelloWorld[i];      //se iguala el string y el array

           }

           Console.WriteLine(caracteresHelloWorld);



           // Console.WriteLine(helloWorld.Substring(0, 4));      //substring para fragmentos del string
            
        }
    }
}
