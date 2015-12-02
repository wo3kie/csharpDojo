using System.Collections.Generic;
using System.Linq;

public class LinqWhere
{
    public static void Main() {
        int [] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        {
            IEnumerable< int > even = Enumerable.Where(
                numbers,
                x => x % 2 == 0 
            );

            foreach( int i in even ){
                System.Console.WriteLine( i );
            }
        }

        {
            IEnumerable< int > odd = numbers.Where(
                x => x % 2 == 1
            );

            foreach( int i in odd ){
                System.Console.WriteLine( i );
            }
        }
    }
}

