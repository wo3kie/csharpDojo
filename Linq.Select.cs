using static System.Diagnostics.Debug;

using System.Collections.Generic;
using System.Linq;

public class LinqSelect
{
    public static void Main()
    {
        int [] numbers = { 1, 2, 3, 4, 5 };

        {
            IEnumerable< int > tens = Enumerable.
                Select( numbers, x => 10 * x );

            int [] expected = { 10, 20, 30, 40, 50 };
            Assert( Enumerable.SequenceEqual( tens.ToArray(), expected ) );
        }

        {
            IEnumerable< double > fractions = numbers.
                Select( x => 1.0 / x );

            double [] expected = { 1.0 / 1, 1.0 / 2, 1.0 / 3, 1.0 / 4, 1.0 / 5 };
            Assert( Enumerable.SequenceEqual( fractions.ToArray(), expected ) );
        }

        {
            IEnumerable< int > less3 =
                from n in numbers
                where n < 3
                select n;

            int [] expected = { 1, 2 };
            Assert( Enumerable.SequenceEqual( less3.ToArray(), expected ) );
        }

        {
            IEnumerable< int > more3 = numbers.
                Where( x => x > 3 ).
                Select( x => x );

            int [] expected = { 4, 5 };
            Assert( Enumerable.SequenceEqual( more3.ToArray(), expected ) );
        }
    }
}

