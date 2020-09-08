using System;

namespace prog2
{
    class Program
    {
        static void Main(string[] args)
        {
          FootBall theBall = new FootBall(); 
          FootBall theOtherBall = new FootBall();


          theBall.x = 100;

          System.Console.WriteLine(theOtherBall.x);

          Console.ReadLine();

        }
    }
}
