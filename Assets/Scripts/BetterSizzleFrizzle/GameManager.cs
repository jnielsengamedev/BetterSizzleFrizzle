using System;
using BetterSizzleFrizzle.Data;
using UnityEngine;
using UnityEngine.UIElements;

namespace BetterSizzleFrizzle
{
	public class GameManager : MonoBehaviour
	{
		public Money Money;
		private VisualElement _rootElement;
		private Label _moneyLabel;
		
		private void Awake()
		{
			_rootElement = GetComponent<UIDocument>().rootVisualElement;
			_moneyLabel = _rootElement.Q<Label>("Money");
			Money = new Money();
		}

		private void Update()
		{
			UpdateUI();
		}

		private void UpdateUI()
		{
			_moneyLabel.text = $"Money: ${Money.Cash}";
		}
	}
}
