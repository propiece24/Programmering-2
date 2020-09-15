using System;

namespace Modellering
{
    class Program
    {
        static void Main(string[] args)
        {
            
          Enemy Goomba  = new Enemy();

          Goomba.x = 10;
          Goomba.y = 15;
          Goomba.isDead = true;
          Goomba.hp = 0;

          Player Fart = new Player();

          Fart.y = 10;
          Fart.x = 10;
          Fart.Speed = 5;
          Fart.isLeft = false;

          Weapon goliathSlayer = new Weapon();

          goliathSlayer.dmg = 10;
          goliathSlayer.fireSpeed = 15;







        }
    }
}
