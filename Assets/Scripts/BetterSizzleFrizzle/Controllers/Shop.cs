using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace BetterSizzleFrizzle.Controllers
{
	public class Shop : MonoBehaviour
	{
		private VisualElement _rootElement;
		private Button _red;
		private Button _purple;
		private Button _blue;
		private Button _emptySlot;
		private Button _rainbow;

		private void Awake()
		{
			_rootElement = GetComponent<UIDocument>().rootVisualElement;
			_red = _rootElement.Q<Button>("Red");
			_purple = _rootElement.Q<Button>("Purple");
			_blue = _rootElement.Q<Button>("Blue");
			_emptySlot = _rootElement.Q<Button>("EmptySlot");
			_rainbow = _rootElement.Q<Button>("Rainbow");

			_red.clicked += Red;
			_purple.clicked += Purple;
			_blue.clicked += Blue;
			_emptySlot.clicked += EmptySlot;
			_rainbow.clicked += Rainbow;
		}

		/// <summary>
		/// Put code that you want to execute for the button by the Red pot.
		/// </summary>
		private void Red()
		{
		}

		/// <summary>
		/// Put code that you want to execute for the button by the Purple pot.
		/// </summary>
		private void Purple()
		{
		}

		/// <summary>
		/// Put code that you want to execute for the button by the Blue pot.
		/// </summary>
		private void Blue()
		{
		}

		/// <summary>
		/// Put code that you want to execute for the button by the Empty Slot.
		/// </summary>
		private void EmptySlot()
		{
		}

		/// <summary>
		/// Put code that you want to execute for the button by the Rainbow  pot.
		/// </summary>
		private void Rainbow()
		{
		}
	}
}