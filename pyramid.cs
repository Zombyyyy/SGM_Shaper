using System;

public class Pyramid{
  double l, w, h;
    

  public Pyramid(double l, double w, double h) {
    this.l = l;
    this.w = w;
    this.h = h;
  }

  public double Volume () {
     return (l * w * h)/3;
  }

  public double SurfaceArea () {
    return ((l * w) + 
            (l * Math.Sqrt(Math.Pow((w / 2D),2) + Math.Pow(h,2))) +
            (w * Math.Sqrt(Math.Pow((l / 2D),2) + Math.Pow(h,2))));
  }
}
