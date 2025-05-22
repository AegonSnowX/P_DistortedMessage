using UnityEngine;

public abstract class HostileEntity: BaseEntity
{
    private int score = 10;
    private void Start()
    {
        scoreValue = score;
    }
    protected override void OnReportedAsFriendly()
    {
        Debug.Log("HostileEntity.OnReportedAsFriendly");
    }

    protected override void OnReportedAsHostile()
    {
        Debug.Log("HostileEntity.OnReportedAsHostile");
        Die();
    }

    protected override void OnReportedAsUnknown()
    {
        Debug.Log("HostileEntity.OnReportedAsUnknown");
    }

    protected override void OnReportedAsSuspicious()
    {
        Debug.Log("HostileEntity.OnReportedAsSuspicious");
    }
}
