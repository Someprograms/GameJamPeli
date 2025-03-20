using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishSchool : MonoBehaviour
{
    public Canvas canvas;
    public Canvas canvas2;
    public IEnumerator SchoolComplete()
    {
        canvas.gameObject.SetActive(true);
        canvas2.gameObject.SetActive(false);
        if (!PlayerPrefs.HasKey("SchoolDone"))
        {
            if (PlayerPrefs.HasKey("Completed"))
                PlayerPrefs.SetInt("Completed", PlayerPrefs.GetInt("Completed") + 1);
            else
                PlayerPrefs.SetInt("Completed", 1);
        }
       
        yield return new WaitForSeconds(4);
        PlayerPrefs.SetString("SchoolDone", "true");
        SceneManager.LoadScene("SampleScene");
    }
    public void Finish()
    {
        StartCoroutine(SchoolComplete());
    }
        
}
