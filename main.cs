// Shaper by Sawyer Murdock - 3A - Programming 1 

// Sorry for the terrible formatting I can't be bothered to fix it manually

using System;

class Program {
  public static void Main (string[] args) {
    Console.Clear();
    Console.WriteLine ("Welcome to Shaper.");
    bool stop = false;
    double l, w, h, r;
    l = 0;
    w = 0;
    h = 0;
    do {
      Console.WriteLine ("\nEnter 1 to make a box\nEnter 2 to make a sphere\nEnter 3 to make a pyramid\nEnter q to quit");
    string inp = Console.ReadLine();
    if (inp == "1") {
      Console.WriteLine("\nYou are now making a box");
      
      Console.WriteLine("Enter a length:");
      l = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Enter a width:");
      w = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Enter a height:");
      h = Convert.ToDouble(Console.ReadLine());
      
      Box box = new Box(l,w,h);
      
      Console.WriteLine("Your box's volume is {0}", box.Volume());
      Console.WriteLine("Your box's surface area is {0}", box.SurfaceArea());
     }
    else if (inp == "2") {
      Console.WriteLine("\nYou are now making a sphere");
        
      Console.WriteLine("Enter a radius:");
      r = Convert.ToDouble(Console.ReadLine());
      
      Sphere sphere = new Sphere(r);
      
      Console.WriteLine("Your sphere's volume is {0}", sphere.Volume());
      Console.WriteLine("Your sphere's surface area is {0}", sphere.SurfaceArea());
     }
    else if (inp == "3") {
      Console.WriteLine("\nYou are now making a pyramid");
      
      Console.WriteLine("Enter a length:");
      l = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Enter a width:");
      w = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Enter a height:");
      h = Convert.ToDouble(Console.ReadLine());
      
      Pyramid pyramid = new Pyramid(l,w,h);
      
      Console.WriteLine("Your pyramid's volume is {0}", pyramid.Volume());
      Console.WriteLine("Your pyramid's surface area is {0}", pyramid.SurfaceArea());
     } else if (inp == "q") {
      stop = true;
     }
    else {
      Console.WriteLine("N/A");
      
    }
   } while (stop == false);
  }
}