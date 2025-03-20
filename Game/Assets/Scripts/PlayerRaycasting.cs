using UnityEngine;

public class PlayerRaycasting : MonoBehaviour
{
    public string colName;
    public FirstPersonController fpc;
    public GameObject reticle;
    public Canvas desktop;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Start()
    {
        desktop.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.name == colName)
            {
                reticle.SetActive(true);
            }
            else
            {
                reticle.SetActive(false);
            }
        }

        if (Input.GetMouseButtonDown(0) && reticle.activeInHierarchy)
        {
            print("going in");
            desktop.gameObject.SetActive(true);
            fpc.enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }
    }
}
