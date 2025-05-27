using UnityEngine;

public class SimpleCameraSwitcher : MonoBehaviour
{
    public Camera camA;
    public Camera camB;
    public GameObject monitorUI;

    private bool usingCamA = true;

    void Start()
    {
        CameraManager.Instance.SetActiveCamera(camA); // start with camA
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

        Camera activeCam = usingCamA ? camA : camB;
        CameraManager.Instance.SetActiveCamera(activeCam);

        if (monitorUI != null)
            monitorUI.SetActive(usingCamA); // Disable UI when on camB
    }
}
