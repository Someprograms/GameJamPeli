using System.Collections;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class PlayerController2 : MonoBehaviour
{
    [SerializeField] bool onRight = false;
    [SerializeField] bool onLeft = false;
    public int points = 0;
    public TMP_Text pointText;
    public Rigidbody rb;
    public float speed;
    public bool isAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pointText.text = ($"points: {points}");
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            if (Input.GetKeyDown(KeyCode.D))
            {
                onLeft = false;
                if (transform.position.x == 3)
                    onRight = true;
                if (!onRight)
                    transform.position = new Vector3(transform.position.x + 3, transform.position.y, transform.position.z);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                onRight = false;
                if (transform.position.x == -3)
                    onLeft = true;
                if (!onLeft)
                    transform.position = new Vector3(transform.position.x - 3, transform.position.y, transform.position.z);
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("choice"))
        {
            Debug.Log("collision");
            if(other.gameObject.name == "RightChoice")
            {
                points++;
                pointText.text = ($"points: {points}");
            }
            else if (other.gameObject.name == "WrongChoice")
            {

                points--;
                pointText.text = ($"points: {points}");
                PlayerDeath();

                
            }
           
        }
        if (other.gameObject.name == "Death")
        {
            PlayerDeath();
        }
        if(other.gameObject.name == "Finish")
        {
            //Win
            if (!PlayerPrefs.HasKey("CodeComplete"))
            {
                if (PlayerPrefs.HasKey("Completed"))
                    PlayerPrefs.SetInt("Completed", PlayerPrefs.GetInt("Completed") + 1);
                else
                    PlayerPrefs.SetInt("Completed", 1);
                Debug.Log(PlayerPrefs.GetInt("Completed"));
                PlayerPrefs.SetString("CodeComplete", "true");

            }
            
            SceneManager.LoadScene("SampleScene");

        }
    }
    public void PlayerDeath()
    {
        isAlive = false;
        rb.isKinematic = true;
        gameObject.GetComponentInChildren<Animator>().enabled = false;
        StartCoroutine(Wait());
        
    }

    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("LeetCodeMiniGame");
    }

}
