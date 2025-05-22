using UnityEngine;

public class ReportScreen : MonoBehaviour
{
    [SerializeField] private CheckpointManager checkpointManager;
    public bool isOpen = false;

    public void OnFriendlyButtonPressed()
    {
        checkpointManager.ReportEntity(ReportDecision.Friendly); 
        Close();// CLOSES THE MONITOR
    }

    public void OnHostileButtonPressed()
    {
        checkpointManager.ReportEntity(ReportDecision.Hostility);
        Close();// CLOSES THE MONITOR
    }

    public void OnSuspiciousButtonPressed()
    {
        checkpointManager.ReportEntity(ReportDecision.Suspicious);
        Close();// CLOSES THE MONITOR
    }

    public void Open()
    {
        isOpen = true;
        gameObject.SetActive(true); // to open
    }

    public void Close()
    {
        gameObject.SetActive(false); // to close
        isOpen = false;
    }
}