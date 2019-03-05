using System;

namespace legoclasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var Lego1 = new MiniFigure
            {
                HairOrHat = "Bald",
                Head = "Pirate",
                Torso = "Pirate",
                Legs = "Pirate",
                Accessories = "Parrot",
            };
            var Lego2 = new MiniFigure
            {
                HairOrHat = "Afro",
                Head = "Cowboy",
                Torso = "Cowboy",
                Legs = "Cowboy",
                Accessories = "Pistol",
            };
            Lego1.Move();
            Lego1.Attack();
            Lego1.Jump();
            Lego2.SpecialAttack();
            Lego2.DoubleJump();
            Console.ReadLine();
        }
    }
}