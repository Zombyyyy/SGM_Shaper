using System;

public class Sphere{
  double r;

  public Sphere(double r) {
    this.r = r;
  }

  public double Volume () {
     return (4D/3D * Math.PI * Math.Pow(r,3));
  }

  public double SurfaceArea () {
    return (4D * Math.PI * Math.Pow(r,2));
  }
}