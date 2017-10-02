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
      Triangle triangle2 = new Triangle(3, 4);

      Console.WriteLine("Enter the height of the triangle: ");
      try 
      {
        triangle1.Height = Convert.ToDouble(Console.ReadLine());
      }
      catch (OverflowException)
      {
          Console.WriteLine("Must be a positive number ");
      }


      Console.WriteLine("Enter the base length of the triangle: ");
      try
      {
      triangle1.Baselength = Convert.ToDouble(Console.ReadLine());
      }
      catch (OverflowException)
      {
          Console.WriteLine("Must be a positive number ");
      }

      Console.Write("The area of the triangle1 is ");
      Console.WriteLine(triangle1.GetArea());  

      Console.Write("The area of the triangle2 is ");
      Console.WriteLine(triangle2.GetArea());  

      Console.Write("The perimeter of the triangle1 is ");
      Console.WriteLine(triangle1.GetPerimeter());  

      Console.Write("The perimeter of the triangle2 is ");
      Console.WriteLine(triangle2.GetPerimeter());  
      
    }
    }
}