using static System.Diagnostics.Debug;

class Text
{
    char[] text_ = { 'H', 'e', 'l', 'l', 'o' };

    public char this[ int i ] {
        get { return text_[ i ]; }
        set { text_[ i ] = value; }
    }
}

public class Index
{
    public static void Main()
    {
        Text text = new Text();

        Assert( text[ 0 ] == 'H' );
        Assert( text[ 1 ] == 'e' );
        Assert( text[ 2 ] == 'l' );
        Assert( text[ 3 ] == 'l' );
        Assert( text[ 4 ] == 'o' );

        text[ 0 ] = 'W';
        text[ 1 ] = 'o';
        text[ 2 ] = 'r';
        text[ 3 ] = 'l';
        text[ 4 ] = 'd';

        Assert( text[ 0 ] == 'W' );
        Assert( text[ 1 ] == 'o' );
        Assert( text[ 2 ] == 'r' );
        Assert( text[ 3 ] == 'l' );
        Assert( text[ 4 ] == 'd' );
    }
}

