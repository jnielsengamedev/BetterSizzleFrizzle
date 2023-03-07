using System;
using System.Collections;
using BetterSizzleFrizzle.Data;
using UnityEngine;

namespace BetterSizzleFrizzle.Controllers
{
	public class Pot : MonoBehaviour
	{
		public PotType type;
		public GameObject containedObject;

		[Header("Money Gaining Pot Properties")]
		public bool earningMoney;

		public long moneyAmount;
		public float secondsToWait;

		private void Awake()
		{
			if (type == PotType.MoneyGaining)
			{
				earningMoney = true;
			}
		}

		private void Start()
		{
			if (type == PotType.MoneyGaining)
			{
				StartCoroutine(MoneyPot());
			}
		}

		private void Update()
		{
			switch (type)
			{
				case PotType.Storage:
					StoragePot();
					break;
			}
		}

		private void StoragePot()
		{
			if (!containedObject) return;
			containedObject.transform.parent = transform;
			containedObject.transform.position = transform.position;
		}

		private IEnumerator MoneyPot()
		{
			while (earningMoney)
			{
				GameManager.Money.AddCash(moneyAmount);
				yield return new WaitForSeconds(secondsToWait);
			}
		}
	}
}