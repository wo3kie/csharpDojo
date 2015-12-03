using static System.Diagnostics.Debug;

class Number
{
    public Number( int value ){
        Value = value;
    }

    public int Value {
        set;
        get;
    }
}

static class NumberExtension
{
    public static Number Inverse( this Number n ){
        return new Number( - n.Value );
    }
}

public class Extension
{
    public static void Main(){
        Assert( new Number( -2 ).Inverse().Value == new Number( 2 ).Value );
        Assert( new Number( 0 ).Inverse().Value == new Number( 0 ).Value );
        Assert( new Number( 2 ).Inverse().Value == new Number( -2 ).Value );
    }
}

