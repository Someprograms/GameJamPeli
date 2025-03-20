using UnityEngine;
using UnityEngine.SceneManagement;
public class Leetcode : MonoBehaviour
{
    public Canvas minigameCanvas;
    public Canvas desktop;
    public Canvas background;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToMinigame()
    {
        SceneManager.LoadScene("LeetCodeMiniGame");
        
    }
}
