using UnityEngine;

public class ReportScreen : MonoBehaviour
{
    [SerializeField] private CheckpointManager checkpointManager;

    public void OnFriendlyButtonPressed()
    {
        checkpointManager.ReportEntity(ReportDecision.Friendly);
    }

    public void OnHostileButtonPressed()
    {
        checkpointManager.ReportEntity(ReportDecision.Hostility);
    }

    public void OnSuspiciousButtonPressed()
    {
        checkpointManager.ReportEntity(ReportDecision.Suspicious);
    }
}
