using UnityEngine;

public class Smuggler : HostileEntity
{
    protected override void OnReportedAsFriendly()
    {
        base.OnReportedAsFriendly();
    }

    protected override void OnReportedAsHostile()
    {
        base.OnReportedAsHostile();
    }

    protected override void OnReportedAsUnknown()
    {
        base.OnReportedAsUnknown();
    }

    protected override void OnReportedAsSuspicious()
    {
        base.OnReportedAsSuspicious();
    }
}
