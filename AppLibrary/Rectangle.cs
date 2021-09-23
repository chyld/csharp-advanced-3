namespace AppLibrary
{
  public class Rectangle
  {
    public string Name;
    public int Length;
    public int Width;

    public override string ToString() => $"{Name} : {Length}x{Width}";
  }
}
