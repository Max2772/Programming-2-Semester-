namespace LB7;

class Polynom
{
    private int a, b, c;

    public Polynom()
    {
        a = 0;
        b = 0;
        c = 0;
    }

    public Polynom(int a, int b, int c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public int A
    {
        get => a;
        set => a = value;
    }

    public int B
    {
        get => b;
        set => b = value;
    }

    public int C
    {
        get => c;
        set => c = value;
    }

    public int this[int index]
    {
        get
        {
            switch (index)
            {
                case 0: return a;
                case 1: return b;
                case 2: return c;
                default: throw new IndexOutOfRangeException("Index out of range, use 0-2.");
            }
        }
        set
        {
            switch (index)
            {
                case 0: A = value; break;
                case 1: B = value; break;
                case 2: C = value; break;
                default: throw new IndexOutOfRangeException("Index out of range, use 0-2.");
            }
        }
    }

    public override string ToString()
    {
        return $"{a}x + {b}y + {c}z";
    }

    public static Polynom operator +(Polynom p1, Polynom p2)
    {
        return new Polynom(p1.a + p2.a, p1.b + p2.b, p1.c + p2.c);
    }

    public static Polynom operator -(Polynom p1, Polynom p2)
    {
        return new Polynom(p1.a - p2.a, p1.b - p2.b, p1.c - p2.c);
    }

    public static Polynom operator *(Polynom p, int num)
    {
        return new Polynom(p.a * num, p.b * num, p.c * num);
    }

    public static Polynom operator /(Polynom p, int num)
    {
        if (num == 0) throw new DivideByZeroException("Division by zero.");
        return new Polynom(p.a / num, p.b / num, p.c / num);
    }

    public static Polynom operator ++(Polynom p)
    {
        return new Polynom(p.a + 1, p.b + 1, p.c + 1);
    }

    public static Polynom operator --(Polynom p)
    {
        return new Polynom(p.a - 1, p.b - 1, p.c - 1);
    }

    public static bool operator ==(Polynom p1, Polynom p2)
    {
        return p1.a == p2.a && p1.b == p2.b && p1.c == p2.c;
    }

    public static bool operator !=(Polynom p1, Polynom p2)
    {
        return !(p1 == p2);
    }

    public static bool operator true(Polynom p)
    {
        return p.a != 0 || p.b != 0 || p.c != 0;
    }

    public static bool operator false(Polynom p)
    {
        return p.a == 0 && p.b == 0 && p.c == 0;
    }

    public static explicit operator int(Polynom p)
    {
        return p.a;
    }

    public static explicit operator Polynom(int a)
    {
        return new Polynom(a, 0, 0);
    }
}
