namespace theCode
{
  public class Program
  {
    static void Main(string[] args)
    {
      NumbersClass myNumbers = new NumbersClass();
      myNumbers.Add(5);
      myNumbers.Add(10);
      myNumbers.Add(15);
      myNumbers.Add(20);

      foreach (var num in myNumbers)
        Console.WriteLine(num);
    }


    public class Number
    {
      public int Value { get; set; }
      public Number(int value)
      {
        Value = value;
      }
    }

    public class NumberEnum : IEnumerator<Number>
    {
      public List<Number> _numbers;

      int position = -1;

      public NumberEnum(List<Number> numberslist)
      {
        _numbers = numberslist;
      }

      public bool MoveNext()
      {
        position++;
        return (position < _numbers.Count);
      }

      public void Reset()
      {
        position = -1;
      }

      public Number Current
      {
        get
        {
          try
          {
            return _numbers[position];
          }
          catch (IndexOutOfRangeException)
          {
            throw new InvalidOperationException();
          }
        }
      }

      object IEnumerator<Number>.Current
      {
        get
        {
          return Current;
        }
      }
    }

    public class NumbersClass : IEnumerable<Number>
    {
      // public IEnumerator<Number> GetEnumerator()
      // {
      //   foreach (Number num in Numbers)
      //     yield return num;
      // }
      // IEnumerator<Number> IEnumerable<Number>.GetEnumerator()
      // {
      //   return GetEnumerator();
      // }
      
      public List<Number> Numbers { get; set; }
      public NumbersClass()
      {
        Numbers = new List<Number>();
      }

      public void Add(int value)
      {
        Numbers.Add(new Number(value));
      }

      IEnumerator<Number> IEnumerable<Number>.GetEnumerator()
      {
        return (IEnumerator<Number>)GetEnumerator();
      }

      public NumberEnum GetEnumerator()
      {
        return new NumberEnum(Numbers);
      }
    }

  }
}