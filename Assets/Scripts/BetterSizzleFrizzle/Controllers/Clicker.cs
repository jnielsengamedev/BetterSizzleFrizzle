using UnityEngine;

namespace BetterSizzleFrizzle.Controllers
{
    public class Clicker : MonoBehaviour
    {
        public long money;
        
        private void OnMouseDown()
        {
            GameManager.Money.AddCash(money);
        }
    }
}
