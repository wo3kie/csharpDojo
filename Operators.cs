using static System.Diagnostics.Debug;

class Int {
    public Int(){
        I = 0;
    }

    public Int( int i ){
        I = i;
    }

    public int I {
        set;
        get;
    }

    public static Int operator+( Int i1, Int i2 ){
        return new Int( i1.I + i2.I );
    }

    public static Int operator-( Int i1, Int i2 ){
        return new Int( i1.I - i2.I );
    }

    public static bool operator==( Int i1, Int i2 ){
        return i1.I == i2.I;
    }

    public static bool operator!=( Int i1, Int i2 ){
        return !( i1 == i2 );
    }

    public override bool Equals( object o ){
        return this == (Int)(o);
    }

    public override int GetHashCode(){
        return I;
    }
}

class Operators
{
    public static void Main() {
        Assert( new Int(1) + new Int(2) == new Int(3) );
        Assert( new Int(1) + new Int(2) != new Int(4) );

        Assert( new Int(1) - new Int(1) == new Int(0) );
        Assert( new Int(1) - new Int(1) != new Int(1) );
    }
}

