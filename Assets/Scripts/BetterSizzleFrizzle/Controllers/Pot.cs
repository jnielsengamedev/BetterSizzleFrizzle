using System.Collections;
using BetterSizzleFrizzle.Data;
using UnityEngine;

namespace BetterSizzleFrizzle.Controllers
{
	public class Pot : MonoBehaviour
	{
		public PotType type;
		public long moneyAmount;

		[Header("Money Gaining Pot Properties")]
		public bool earningAutoMoney;

		public float secondsToWait;

		private void Awake()
		{
			if (type == PotType.MoneyGaining)
			{
				earningAutoMoney = true;
			}
		}

		private void Start()
		{
			if (type == PotType.MoneyGaining)
			{
				StartCoroutine(MoneyPot());
			}
		}

		private IEnumerator MoneyPot()
		{
			while (earningAutoMoney)
			{
				GameManager.Money.AddCash(moneyAmount);
				yield return new WaitForSeconds(secondsToWait);
			}
		}

		private void OnMouseDown()
		{
			if (type == PotType.Clicking)
			{
				GameManager.Money.AddCash(moneyAmount);
			}
		}
	}
}