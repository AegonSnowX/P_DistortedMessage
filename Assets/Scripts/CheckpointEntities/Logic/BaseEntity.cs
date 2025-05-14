using UnityEngine;
using UnityEngine.EventSystems;

public abstract class BaseEntity : MonoBehaviour, IReportable
{
    public string ID; //for tracking entities
    public float duration; // duration of the existence of that entity

    public void HandleReport(ReportDecision decision)     // for different types to handle report
    {
        switch (decision)
        {
            case ReportDecision.Friendly:
                OnReportedAsFriendly();
                break;
            case ReportDecision.Hostility:
                OnReportedAsHostile();
                break;
            case ReportDecision.Suspicious:
                OnReportedAsSuspicious();
                break;
            case ReportDecision.Unknown:
                OnReportedAsUnknown();
                break;
        }
    }
    protected virtual void OnReportedAsFriendly() { }
    protected virtual void OnReportedAsHostile() { }
    protected virtual void OnReportedAsUnknown() { }
    protected virtual void OnReportedAsSuspicious() { }

}
public enum ReportDecision
{
    Friendly, 
    Hostility,
    Suspicious, // I'll just put these two cuz I could've used bool but we for sure may need more types
    Unknown,
}