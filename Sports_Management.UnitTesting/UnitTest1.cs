using System.Diagnostics.CodeAnalysis;

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
        public void ToString_Team_StringWithTeamName()
        {
            // ASSIGN
            string expected = "Team with players from start";

            // ACT
            string actual = teamWithPlayersFromSetup.ToString();

            // ASSERT
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void PrintTeam_TeamWithPlayers_StringWithTeamNameAndPlayers()
        {
            // ASSIGN
            string expected = $"{teamWithPlayersFromSetup.Name}\n" +
                $"------------------\n" +
                $"{teamWithPlayersFromSetup.Players[0]}\n" +
                $"{teamWithPlayersFromSetup.Players[1]}\n" +
                $"{teamWithPlayersFromSetup.Players[2]}\n" +
                $"{teamWithPlayersFromSetup.Players[3]}";

            // ACT
            string actual = teamWithPlayersFromSetup.PrintTeam();

            // ASSERT
            Assert.That(actual, Is.EqualTo(expected));
        }

        #endregion
    }
}