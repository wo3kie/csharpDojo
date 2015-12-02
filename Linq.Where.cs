using static System.Diagnostics.Debug;

using System.Collections.Generic;
using System.Linq;

public class LinqWhere
{
    public static void Main() {
        int [] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        {
            IEnumerable< int > even = Enumerable.
                Where( numbers, x => x % 2 == 0 );

            int [] expected = { 2, 4, 6, 8, 10 };
            Assert( Enumerable.SequenceEqual( expected, even.ToArray() ) );
        }

        {
            IEnumerable< int > odd = numbers.
                Where( x => x % 2 == 1 );

            int [] expected = { 1, 3, 5, 7, 9 };
            Assert( Enumerable.SequenceEqual( expected, odd.ToArray() ) );
        }
    }
}

