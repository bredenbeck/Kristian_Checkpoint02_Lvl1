namespace Sports_Management;

public class Star : Player
{
    #region Fields and properties
    public string Description { get; set; }
    #endregion
    
    #region
    public Star(string name, int number, string description = "No description provided for this player.") : base(name, number) 
    {
        Description = description;
    }
    #endregion

    #region Methods: Override object class methods
    public override string ToString()
    {
        return $"#{Number}, {Name} *** STAR PLAYER *** Description: {Description}";
    }

    public bool Equals(Star other)
    {
        return (this.ToString() == other.ToString());
    }

    public override bool Equals(object? obj)
    {
        if (obj is Star other)
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
    public static bool operator ==(Star left, Star right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Star left, Star right)
    {
        return !left.Equals(right);
    }

    #endregion
}