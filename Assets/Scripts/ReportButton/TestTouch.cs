using Unity.Android.Types;
using UnityEngine;

public class TestTouch : MonoBehaviour
{
    [SerializeField] ThreatManagerUpdated threatManagerUpdated;
    [SerializeField] ReportScreen screen; // used to show the reportScreen
    private InputManager inputManager;

    //bools
    private Vector3 originalPosition;
    public float pressDepth = 1f;

    private void Awake()
    {
        inputManager = InputManager.Instance;
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
        Ray ray = CameraManager.ActiveCamera.ScreenPointToRay(screenPosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        { 
            Debug.Log(hit.transform.position);
            Debug.DrawRay(ray.origin, ray.direction * 100f, Color.red); // 100 units long, red color
            Debug.Log("Hit object name: " + hit.collider.gameObject.name);

            if (hit.transform == transform)
            {
                Debug.Log(hit.transform.position);
              
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