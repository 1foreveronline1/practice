using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{
  class Prog
  {
    class Duck
    {
      public bool swim { get; set; } = false;
      public bool fly { get; set; } = false;
      public bool run { get; set; } = false;
      public bool fish { get; set; } = false;
      public bool home { get; set; } = false;
      public int ammount;
      public string name;

    }

    class Lake
    {
      public string name;
      public int ammount;

    }

    class Farm
    {
      public int ammount;
      public string name;
    }

    class Hunter
    {
      public int hunt;
    }

    public static void Main(string[] args)
    {
      Random random = new Random();

      Lake lake1 = new Lake();
      lake1.name = "Мьоса";
      lake1.ammount = random.Next(3, 148);

      Duck chern1 = new Duck();
      chern1.swim = true;
      chern1.name = "Чернетти";
      chern1.ammount = random.Next(1, lake1.ammount);

      Duck nirki = new Duck();
      nirki.swim = true;
      nirki.home = true;
      nirki.name = "Нырки";
      nirki.ammount = random.Next(1, lake1.ammount - chern1.ammount);

      Duck kryak = new Duck();
      kryak.run = true;
      kryak.name = "Кряква";
      kryak.ammount = lake1.ammount - chern1.ammount - kryak.ammount;


      Lake lake2 = new Lake();
      lake2.name = "Мьоса";
      lake2.ammount = 151 - lake1.ammount;

      Duck chern2 = new Duck();
      chern2.swim = true;
      chern2.home = true;
      chern2.name = "Чернетти";
      chern2.ammount = random.Next(1, lake2.ammount);

      Duck kamen = new Duck();
      kamen.fly = true;
      kamen.home = true;
      kamen.name = "Каменушки";
      kamen.ammount = random.Next(1, lake2.ammount - chern2.ammount);

      Duck chirok = new Duck();
      chirok.swim = true;
      chirok.name = "Чирок";
      chirok.ammount = lake2.ammount - chern2.ammount - kamen.ammount;

      Hunter hunt1 = new Hunter();
      hunt1.hunt = random.Next(1, 8);

      Hunter hunt2 = new Hunter();
      hunt2.hunt = random.Next(3, 5);

      Farm farm1 = new Farm();
      farm1.name = "SALEDY";
      farm1.ammount = hunt1.hunt + hunt2.hunt;

      Hunter hunt3 = new Hunter();
      hunt3.hunt = random.Next(1, 7);

      Hunter hunt4 = new Hunter();
      hunt4.hunt = random.Next(3, 9);

      Farm farm2 = new Farm();
      farm2.name = "TEGYKUT";
      farm2.ammount = hunt3.hunt + hunt4.hunt;
    }
  }
}
