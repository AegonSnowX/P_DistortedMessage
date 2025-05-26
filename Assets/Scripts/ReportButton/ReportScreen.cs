using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ReportScreen : MonoBehaviour
{
    [SerializeField] private ThreatManagerUpdated threatManagerUpdated;
    [SerializeField] private TMP_Text feedback;
    public bool isOpen = false;

    public void OnFriendlyButtonPressed()
    {
        threatManagerUpdated.ReportEntity(ReportDecision.Friendly); 
        
        Close();// CLOSES THE MONITOR
    }

    public void OnHostileButtonPressed()
    {
        threatManagerUpdated.ReportEntity(ReportDecision.Hostility);
        Close();// CLOSES THE MONITOR
    }

    public void OnSuspiciousButtonPressed()
    {
        threatManagerUpdated.ReportEntity(ReportDecision.Suspicious);
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