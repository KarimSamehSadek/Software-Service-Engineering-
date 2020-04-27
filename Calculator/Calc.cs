using System;
using System.Collections.Generic;
namespace Calculator
{
  public class Calc
  {
    public int Mult(int x, int y)
    {

      return x * y;
    }


    public int Div(int x, int y)
    {
      if (y == 0)
        return -9999;
      else
        return x / y;
    }
    /*
    public virtual getMockDiv(int x, int y)
    {
      throw new NotImplementedException();
    }
  }*/
    static public void main()
    {
      // Creating a dictionary
      // using Dictionary<TKey,TValue> class 
      //   Dictionary<int, string> My_dict1 =  new Dictionary<int, string>();
      Dictionary<int, int> dict = new Dictionary<int, int>();

      // Adding key/value pairs  
      // in the Dictionary 
      // Using Add() method 

      dict.Add(55, 25);
      dict.Add(66, 36);
      dict.Add(45, 20);
      dict.Add(55, 25);
      dict.Add(77,49);
      dict.Add(58,40);
      dict.Add(74, 28);
      dict.Add(99, 81);
      dict.Add(33, 9);
      dict.Add(22, 4);
    }

  }
}