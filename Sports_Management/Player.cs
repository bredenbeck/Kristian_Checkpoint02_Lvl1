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
        return $"{Name}, #{Number}";
    }
    #endregion
}