using UnityEngine;
using UnityEngine.EventSystems;

public abstract class NewMonoBehaviourScript : MonoBehaviour, IReportable
{
    public string ID; //for tracking entities
    public float duration; // duration of the existence of that entity

    public void HandleReport(ReportDescision descision)     // for different types to handle report
    {
        switch (descision)
        {
            case ReportDescision.Friendly:
                OnReportedAsFriendly();
                break;
            case ReportDescision.Hostility:
                OnReportedAsHostile();
                break;
            case ReportDescision.Suspicious:
                OnReportedAsSuspicious();
                break;
            case ReportDescision.Unknown:
                OnReportedAsUnknown();
                break;
        }
    }
    protected virtual void OnReportedAsFriendly() { }
    protected virtual void OnReportedAsHostile() { }
    protected virtual void OnReportedAsUnknown() { }
    protected virtual void OnReportedAsSuspicious() { }

}
public enum ReportDescision
{
    Friendly, 
    Hostility,
    Suspicious, // I'll just put these two cuz I could've used bool but we for sure may need more types
    Unknown,
}