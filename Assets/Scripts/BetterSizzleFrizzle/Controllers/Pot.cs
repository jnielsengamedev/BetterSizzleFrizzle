using UnityEngine;

namespace BetterSizzleFrizzle.Controllers
{
    public class Pot : MonoBehaviour
    {
        public GameObject containedObject;

        private void Update()
        {
            if (!containedObject) return;
            containedObject.transform.parent = transform;
            containedObject.transform.position = transform.position;
        }
    }
}
