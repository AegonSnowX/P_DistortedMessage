using UnityEngine;
using UnityEngine.UI;
public class SurveillanceUI : MonoBehaviour
{
    public RawImage fullscreenView;
    public Button exitButton;
    public GameObject monitorPanel; // Parent of all 6 buttons

    public void OpenFullscreen(RenderTexture feed)
    {
        fullscreenView.texture = feed;
        fullscreenView.gameObject.SetActive(true);
        exitButton.gameObject.SetActive(true);
        monitorPanel.SetActive(false);
    }

    public void CloseFullscreen()
    {
        fullscreenView.gameObject.SetActive(false);
        exitButton.gameObject.SetActive(false);
        monitorPanel.SetActive(true);
    }
}
