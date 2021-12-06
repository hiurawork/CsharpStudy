using System;
using System.Collections.Generic;
using PachittoMonster;

namespace Main
{
  class Program
  {
    static void Main(string[] args)
    {
      // 1匹目
      Pekachu pekachu1 = new Pekachu("ぺかちゅう");
      pekachu1.ShowBaseName();
      pekachu1.ShowName();
      pekachu1.ShowSkill();


      // 2匹目
      Pekachu pekachu2 = new Pekachu("ぺかちゅう２号");
      pekachu2.ShowDetail();
    }
  }
}
