using System;

namespace Main
{
  class ArrayError : Exception
  {
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public ArrayError() : base("指定された箇所に値が存在しない") { }
  }
}