/*
 * https://msdn.microsoft.com/en-us/library/system.collections.ienumerator(v=vs.110).aspx
 */

using System.Collections;

class Person
{
    public Person( string name ) {
        Name = name;
    }

    public string Name {
        set;
        get;
    }
}

class PeopleEnumerator
    : IEnumerator
{
    public PeopleEnumerator( Person [] people ) {
        position_ = -1;
        people_ = people;
    }

    public bool MoveNext() {
        position_ += 1;
        return position_ != people_.Length;
    }

    object IEnumerator.Current {
        get {
            return Current;
        }
    }

    public Person Current {
        get {
            return people_[ position_ ];
        }
    }

    public void Reset() {
        position_ = -1;
    }

    Person [] people_;
    int position_;
}

class People
    : IEnumerable
{
    public People( Person [] people ) {
        people_ = new Person[ people.Length ];

        for( int i = 0 ; i < people.Length ; ++ i ){
            people_[ i ] = people[ i ];
        }
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }

    public PeopleEnumerator GetEnumerator() {
        return new PeopleEnumerator( people_ );
    }

    Person[] people_;
}

class Enumerator {
    public static void Main() {
        Person [] people = new Person[] {
            new Person( "John" ),
            new Person( "Jack" )
        };

        foreach( Person p in new People( people ) ){
            System.Console.WriteLine( p.Name );
        }
    }
}

