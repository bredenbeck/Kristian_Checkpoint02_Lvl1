namespace Sports_Management
{
    // GITHUB: https://github.com/bredenbeck/Kristian_Checkpoint02_Lvl1

    internal class Program
    {
        static void Main(string[] args)
        {
            Team osloSquirrels = new("Oslo Squirrels");

            osloSquirrels.AddPlayer("Tom Romtomtom", 1);
            osloSquirrels.AddPlayer("Jack Snackpack", 4);
            osloSquirrels.AddPlayer("John Bond", 6);
            osloSquirrels.AddStar("Super Man", 9, "An intergalactic player.");

            osloSquirrels.PrintTeam();
        }
    }
}