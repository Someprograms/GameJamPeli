using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CompletedCheck : MonoBehaviour
{
    public TMP_Text text;
    public TMP_Text winText;
    public Button quitButton;
    public FirstPersonController fpc;
    public PlayerRaycasting playerRaycasting;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PlayerPrefs.HasKey("Completed"))
        {
            if(PlayerPrefs.GetInt("Completed") > 1)
            {
                playerRaycasting.enabled = false;
                fpc.enabled = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

                winText.text = "You got job interviews";
                quitButton.gameObject.SetActive(true);
            }
            text.text = ($"Tasks Completed: {PlayerPrefs.GetInt("Completed")}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
