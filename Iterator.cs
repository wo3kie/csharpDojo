using System.Collections.Generic;
using static System.Diagnostics.Debug;

class Fibonacci
{
    public static IEnumerator< int > Get() {
        for( int prev = 0, cur = 1 ; ; ){
            yield return prev;

            int temp = prev;
            prev = cur;
            cur = cur + temp;
        }
    }
}

public class Iterator
{
    public static void Main() {
        IEnumerator< int > fib = Fibonacci.Get();

        fib.MoveNext();
        Assert( fib.Current == 0 );

        fib.MoveNext();
        Assert( fib.Current == 1 );

        fib.MoveNext();
        Assert( fib.Current == 1 );

        fib.MoveNext();
        Assert( fib.Current == 2 );

        fib.MoveNext();
        Assert( fib.Current == 3 );

        fib.MoveNext();
        Assert( fib.Current == 5 );
    }
}

