using UnityEngine;

public abstract class HostileEntity: BaseEntity
{
    public override int ScoreValue => 5;
    protected override void OnReportedAsFriendly()
    {
        Debug.Log("HostileEntity.OnReportedAsFriendly");
        ScoreManager.Instance.RemoveScore(ScoreValue); //remove score as hostile != friendly
    }

    protected override void OnReportedAsHostile()
    {
        Debug.Log("HostileEntity.OnReportedAsHostile");
        ScoreManager.Instance.AddScore(ScoreValue); //add score as hostile == hostile
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
