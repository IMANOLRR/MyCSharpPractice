using System;

public class Counter
{
    public int Count { get; set; } = 5;
    private int count;
    public Counter()
    {
       count = 5;
    }

    public Counter(int initialValue)
    {
        count = initialValue;
    }
    public void increment()
    { 
    count++;
        count++;
        count++;
    }
    public void decrement()
    {
        count--;
        count--;
    }

    public int getCount()
    {
        return count;
    }

    public void setCount(int newValue)
    {
        count = newValue;
    }

    public static void Main()
    {
        Counter counter = new Counter();
        Console.WriteLine(counter.getCount());

        counter.increment();
        Console.WriteLine(counter.getCount());

        counter.decrement();
        Console.WriteLine(counter.getCount());  

    }
}