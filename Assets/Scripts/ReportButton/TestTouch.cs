using Unity.Android.Types;
using UnityEngine;

public class TestTouch : MonoBehaviour
{
    [SerializeField] ThreatManagerUpdated threatManagerUpdated;
    [SerializeField] ReportScreen screen; // used to show the reportScreen
    private InputManager inputManager;
    private Camera cameraMain;

    //bools
    private Vector3 originalPosition;
    public float pressDepth = 1f;

    private void Awake()
    {
        inputManager = InputManager.Instance;
        cameraMain = Camera.main;
        originalPosition = transform.localPosition;
    }

    private void OnEnable()
    {
        inputManager.OnStartTouch += HandleTouchStart;
        inputManager.OnEndTouch += HandleTouchEnd;
    }

    private void OnDisable()
    {
        inputManager.OnStartTouch -= HandleTouchStart;
        inputManager.OnEndTouch -= HandleTouchEnd;
    }

    private void HandleTouchStart(Vector2 screenPosition, float time)
    {
        Ray ray = cameraMain.ScreenPointToRay(screenPosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        { Debug.Log(hit.transform.position);
            if (hit.transform == transform)
            {
                Debug.Log(hit.transform.position);
               // Debug.Log(hit.)
                // Press the button
                transform.localPosition = originalPosition - new Vector3(0, pressDepth, 0);
                
                if (!screen.isOpen && threatManagerUpdated.isUnderThreat)
                    screen.Open();
            }
        }
    }

    private void HandleTouchEnd(Vector2 screenPosition, float time)
    {
        // Release the button
        transform.localPosition = originalPosition;
    }
}