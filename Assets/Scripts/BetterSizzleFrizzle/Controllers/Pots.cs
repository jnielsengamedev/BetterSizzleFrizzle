using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using UnityEngine;

namespace BetterSizzleFrizzle.Controllers
{
    public class Pots : MonoBehaviour
    {
        public List<Pot> pots;

        public void StoreItem(GameObject item)
        {
            var pot = ReturnEmptyPot();
            if (pot != null) pot.containedObject = item;
        }

        [CanBeNull]
        private Pot ReturnEmptyPot()
        {
            return pots.FirstOrDefault(pot => !pot.containedObject);
        }

        public static Pots Get()
        {
            return GameObject.Find("Pots").GetComponent<Pots>();
        }
    }
}
