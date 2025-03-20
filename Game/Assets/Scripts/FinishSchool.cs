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
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("SampleScene");
    }
    public void Finish()
    {
        StartCoroutine(SchoolComplete());
    }
        
}
