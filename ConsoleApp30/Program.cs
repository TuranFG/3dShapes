namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var cuboid = new Cuboid(10, 20, 30);
            Console.WriteLine(cuboid);
        
            var cone = new Cone(40, 20);
            Console.WriteLine(cone);

            var cylinder = new Cylinder(40, 20);
            Console.WriteLine(cylinder);
        }
    }
}