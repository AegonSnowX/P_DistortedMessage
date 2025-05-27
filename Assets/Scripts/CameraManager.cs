using UnityEngine;
// CameraManager handles which camera is currently considered "active" for gameplay/view purposes.
// It allows switching between multiple cameras at runtime without duplicating logic.
// The currently active camera can be accessed globally via CameraManager.ActiveCamera,
// making it easy to use for raycasts, viewport logic, etc.
// because if we have multiple cameras that are able to raycast its hard to take control which is currently sending ray
public class CameraManager : Singleton<CameraManager>
{
    public static Camera ActiveCamera { get; private set; }

    // it sets the given camera as the active one.
    // disables the previously active camera (if any) and enables the new one.
    // useful for switching player views
    public void SetActiveCamera(Camera newCamera)
    {
        if (ActiveCamera != null)
            ActiveCamera.enabled = false;
        
        ActiveCamera = newCamera;
        ActiveCamera.enabled = true;
    }
}
