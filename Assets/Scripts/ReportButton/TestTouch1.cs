using UnityEngine;

public class TestTouch1 : MonoBehaviour
{
    private InputManager inputManager;
    private Camera cameraMain;
    public CameraControl cameraControl;

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
        {
            if (hit.transform == transform)
            {
                // Press the button
                cameraControl.ToggleView();
            }
        }
    }

    private void HandleTouchEnd(Vector2 screenPosition, float time)
    {
        // Release the button
        transform.localPosition = originalPosition;
    }
}