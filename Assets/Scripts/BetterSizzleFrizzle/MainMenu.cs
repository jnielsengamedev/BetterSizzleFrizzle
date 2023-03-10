using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

namespace BetterSizzleFrizzle
{
    public class MainMenu : MonoBehaviour
    {
        private VisualElement _rootElement;
        private Button _play;

        private void Awake()
        {
            _rootElement = GetComponent<UIDocument>().rootVisualElement;
            _play = _rootElement.Q<Button>("Play");
            
            _play.clicked += Play;
        }

        private void Play()
        {
            SceneManager.LoadScene("BetterSizzleFrizzle");
        }
    }
}
