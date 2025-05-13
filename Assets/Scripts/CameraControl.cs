using UnityEngine;
using UnityEngine.UI;

public class CameraControl : MonoBehaviour
{    public Camera playerCam;
    public Camera cctvCam;
    private bool showingCCTV = false;

    void Start()
    {
        SetView(false); // Start with playerCam
    }

    public void ToggleView()
    {
        showingCCTV = !showingCCTV;
        SetView(showingCCTV);
    }
void SetView(bool cctv)
{
    Debug.Log("Something is working");
    if (cctv)
    {
        playerCam.depth = 0;
        cctvCam.depth = 1;
    }
    else
    {
        playerCam.depth = 1;
        cctvCam.depth = 0;
    }
}}



