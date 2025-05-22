using UnityEngine;
// i'll keep this file for sometime else not used now
public class ReportScreenHandler : MonoBehaviour
{
    [SerializeField] ReportScreen screen; // to handle report screen

    public void CloseMonitor() => screen.Close(); // to close
    public void OpenMonitor() => screen.Open(); //to open
    
    public bool IsMonitorOpen() => screen.isOpen;
}
