using System;

namespace prog2
{
    class Program
    {
        static void Main(string[] args)
        {

          int[] arr = {33, 44, 55, 66};


          Audience a1 = new Audience();

          a1.excitement = 30;

          FootBall theBall = new FootBall(); 
          FootBall theOtherBall = new FootBall();


          theBall.x = 100;

          System.Console.WriteLine(theOtherBall.x);

          Console.ReadLine();

        }
    }
}
