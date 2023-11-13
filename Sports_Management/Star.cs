namespace Sports_Management;

public class Star : Player
{
    #region Fields and properties
    public string Description { get; set; }
    #endregion
    
    #region
    public Star(string name, int number, string description) : base(name, number) 
    {
        Description = description;
    }
    #endregion
}