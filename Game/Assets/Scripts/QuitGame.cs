using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void ExitGame()
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }
}
