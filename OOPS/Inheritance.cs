namespace OOPS
{

    public class Inheritance
    {
        internal void MaxSpeed(int speed)
        {
            int MaxSpeed = speed;
            Console.WriteLine(MaxSpeed);

        }
        public void ABS()
        {
            Console.WriteLine("ABS is applied");
        }
    }

    public class Volvo : Inheritance
    {
        public void Test()
        {
            Console.WriteLine("In Volvo car");
        }
        public void ABS()
        {
            Console.WriteLine("ADvanced Volvo aBS");
        }

        
    }
    public class VolvoSports : Volvo
    {
        public void Sportmethod()
        {
            Console.WriteLine("This is sport mode");
        }
    }
}