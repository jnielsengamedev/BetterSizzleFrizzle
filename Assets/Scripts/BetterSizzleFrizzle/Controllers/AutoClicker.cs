using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace BetterSizzleFrizzle.Controllers
{
	public class AutoClicker: MonoBehaviour
	{
		private List<Pot> _pots;

		private void Awake()
		{
			FindPots();
		}

		/// <summary>
		/// This method finds all the pots in a scene and puts them in a List.
		/// </summary>
		private void FindPots()
		{
			_pots = FindObjectsOfType<Pot>().ToList();
		}

		/// <summary>
		/// This method gets a random pot from the pots List and returns it.
		/// </summary>
		/// <returns>A Pot.</returns>
		private Pot GetRandomPot()
		{
			return _pots[Random.Range(0, _pots.Count)];
		}
	}
}