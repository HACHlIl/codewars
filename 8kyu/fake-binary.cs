public class Kata
{
  public static string FakeBin(string x)
  {   
    for ( var i = 0; i < x.Length; i++ )
        {
          if ( x[i] < 5 )
          {
            x[i] = 0;
          }
          else if ( x[i] > 5 )
          {
            x[i] = 1;
          } 
          return x;
        }
}
}