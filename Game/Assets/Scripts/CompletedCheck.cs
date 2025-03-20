using TMPro;
using UnityEngine;

public class CompletedCheck : MonoBehaviour
{
    public TMP_Text text;
    public TMP_Text winText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PlayerPrefs.HasKey("Completed"))
        {
            if(PlayerPrefs.GetInt("Completed") > 1)
            {
                winText.text = "Job Interview for microsoft: Junior .NET Developer";
            }
            text.text = ($"Tasks Completed: {PlayerPrefs.GetInt("Completed")}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
