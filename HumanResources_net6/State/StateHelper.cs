namespace HumanResources_net6.State
{
	internal class StateHelper
	{
		public static List<State> GetStates(string defaultState)
		{
			return new List<State>
			{
				new State {Id = 0, Name = defaultState},
				new State {Id = 1, Name = "Zatrudniony"},
				new State {Id = 2, Name = "Zwolniony"},
			};
		}
	}
}
