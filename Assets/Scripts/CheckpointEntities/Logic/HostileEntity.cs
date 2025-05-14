using UnityEngine;

public abstract class HostileEntity: BaseEntity
{
    protected override void OnReportedAsFriendly()
    {
        Debug.Log("HostileEntity.OnReportedAsFriendly");
    }

    protected override void OnReportedAsHostile()
    {
        Debug.Log("HostileEntity.OnReportedAsHostile");
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
