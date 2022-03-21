public class Box{
  double l, w, h;

  public Box(double l, double w, double h) {
    this.l = l;
    this.w = w;
    this.h = h;
  }

  public double Volume () {
     return (l*w*h);
  }

  public double SurfaceArea () {
    return (((l*h) + (h*w) + (l*w))*2);
  }
}