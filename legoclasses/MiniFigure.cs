using System;
using System.Collections.Generic;
using System.Text;

namespace legoclasses
{
    class MiniFigure
    {
        public string HairOrHat { get; set; }
        public string Head { get; set; }
        public string Torso { get; set; }
        public string Legs { get; set; }
        public string Accessories { get; set; }

        public void Jump()
        {
            Console.WriteLine("The lego jumped");
        }
        public void DoubleJump()
        {
            Console.WriteLine("The lego double jumped");
        }
        public void Attack()
        {
            Console.WriteLine("The lego attacked");
        }
        public void SpecialAttack()
        {
            Console.WriteLine("The lego special attacked");
        }
        public void Look()
        {
            Console.WriteLine("The lego looked");
        }
        public void Move()
        {
            Console.WriteLine("The lego moved");
        }
    }
}
