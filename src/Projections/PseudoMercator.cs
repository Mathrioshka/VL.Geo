using System;

namespace VL.Geo.Projections
{
  public static class PseudoMercator
  {
    public static float YToLatitude(float y)
    {
      return (float)Math.Atan(
        (float)Math.Exp(y / 180 * Math.PI)
      ) / (float)Math.PI * 360 - 90;
    }
    public static float LatitudeToY(float latitude)
    {
      return (float)Math.Log(
        (float)Math.Tan((latitude + 90) / 360 * (float)Math.PI)
      ) / (float)Math.PI * 180;
    }
  }
}
