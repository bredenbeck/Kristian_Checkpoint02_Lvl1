namespace Sports_Management.UnitTesting
{
    public class Tests
    {
        private Team teamWithPlayersFromSetup;
        private Team teamWithoutPlayersFromSetup;

        [SetUp]
        public void Setup()
        {
            teamWithPlayersFromSetup = new Team("Team with players from start");
            teamWithPlayersFromSetup.Players.Add(new Player("Tom", 5));
            teamWithPlayersFromSetup.Players.Add(new Player("John", 45));
            teamWithPlayersFromSetup.Players.Add(new Player("Sarah", 32));
            teamWithPlayersFromSetup.Players.Add(new Star("Rocky", 1, "Has the eye of a tiger"));

            teamWithoutPlayersFromSetup = new Team("Team without players from start");
        }

        #region Team methods
        [Test]
        public void PrintTeam_TeamWithPlayers_()
        {
            // ASSIGN

            // ACT

            // ASSERT
            Assert.Pass();
        }

        #endregion
    }
}