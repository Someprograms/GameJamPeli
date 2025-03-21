using UnityEngine;

public class Back : MonoBehaviour
{
    public Canvas desktop;
    public FirstPersonController fpc;
    public void GoBack()
    {
        desktop.gameObject.SetActive(false);
        fpc.enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }
}
