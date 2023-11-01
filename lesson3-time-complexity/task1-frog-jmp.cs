namespace Tasks;

public static class FrogJmp
{
  public static int Solution(int X, int Y, int D)
  {
    var round = (Y - X) % D > 0 ? 1 : 0;
    int jumps = (Y - X) / D + round;
    return jumps;
  }
}