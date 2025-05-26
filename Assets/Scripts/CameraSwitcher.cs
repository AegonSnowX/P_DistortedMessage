using UnityEngine;

public class SimpleCameraSwitcher : MonoBehaviour
{
    public Camera camA;
    public Camera camB;
    public GameObject monitorUI;

    private bool usingCamA = true;

    void Start()
    {
        camA.gameObject.SetActive(true);
        camB.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchCamera();
        }
    }

    public void SwitchCamera()
    {
        usingCamA = !usingCamA;

        camA.gameObject.SetActive(usingCamA);
        camB.gameObject.SetActive(!usingCamA);

        if (monitorUI != null)
            monitorUI.SetActive(usingCamA); // Disable UI when on camB
    }
}
