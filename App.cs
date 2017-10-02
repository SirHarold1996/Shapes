using System;

namespace Shapes
{
    class App
    {
    public App()
    {
           
    }
    public void Run()
    {
      Triangle triangle1 = new Triangle();

      Console.WriteLine("Enter the height of the triangle: ");
      triangle1.Height = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Enter the base length of the triangle: ");
      triangle1.Baselength = Convert.ToDouble(Console.ReadLine());

      Console.Write("The area of the triangle is ");
      Console.WriteLine(triangle1.GetArea());  
    }
    }
}