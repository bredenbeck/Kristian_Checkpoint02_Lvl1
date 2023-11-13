namespace Sports_Management;

public class Player
{
    #region Fields and properties
    public string Name { get;}
    public int Number { get; set; }
    #endregion

    #region Constructors
    public Player(string name, int number)
    {
        Name = name;
        Number = number;
    }
    #endregion

    #region Methods: Override object class methods
    public override string ToString()
    {
        return $"#{Number}, {Name}";
    }

    public bool Equals(Player other)
    {
        return (this.ToString() == other.ToString());
    }

    public override bool Equals(object? obj)
    {
        if (obj is Player other)
        {
            return Equals(other);
        }
        else
        {
            return false;
        }
    }
    #endregion

    #region Operator overloads
    public static bool operator ==(Player left, Player right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Player left, Player right)
    {
        return !left.Equals(right);
    }

    #endregion
}