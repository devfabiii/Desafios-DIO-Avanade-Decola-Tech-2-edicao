using System; 
using System.Globalization;

class DIO {

    static void Main(string[] args) { 

      double a, c, S= 0;
      for (a = 1; a <= 100; a++)
      {
          c = 1 / a;  //coloque a sua lógica nos espaços em branco
          S += c;
      }

      Console.WriteLine(S.ToString("F2", CultureInfo.InvariantCulture));

    }

}