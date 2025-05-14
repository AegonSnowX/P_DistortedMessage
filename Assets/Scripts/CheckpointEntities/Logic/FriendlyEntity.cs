using UnityEngine;

public abstract class FriendlyEntity: BaseEntity
{
    protected override void OnReportedAsFriendly()
    {
        Debug.Log("FriendlyEntity.OnReportedAsFriendly");
    }

    protected override void OnReportedAsHostile()
    {
        Debug.Log("FriendlyEntity.OnReportedAsHostile");
    }

    protected override void OnReportedAsUnknown()
    {
        Debug.Log("FriendlyEntity.OnReportedAsUnknown");
    }

    protected override void OnReportedAsSuspicious()
    {
        Debug.Log("FriendlyEntity.OnReportedAsSuspicious");
    }
}