using UnityEngine;
using UnityEngine.SceneManagement; // Namespace for scene management
using UnityEngine.UI; // Namespace for UI

public class PlayButton : MonoBehaviour
{
    public string Level; // The name of the next scene to load

    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnPlayButtonClick);
    }

    void OnPlayButtonClick()
    {
        SceneManager.LoadScene(Level);
    }
}
