using System;
using UnityEngine;

public abstract class FriendlyEntity: BaseEntity
{
    public override int ScoreValue => 10;
    
    protected override void OnReportedAsFriendly()
    {
        Debug.Log("FriendlyEntity.OnReportedAsFriendly");
        ScoreManager.Instance.AddScore(ScoreValue);// friend == friendly
        Die();
    }

    protected override void OnReportedAsHostile()
    {
        Debug.Log("FriendlyEntity.OnReportedAsHostile");
        ScoreManager.Instance.RemoveScore(ScoreValue); // friend != hostile
        Die();
    }

    protected override void OnReportedAsUnknown()
    {
        Debug.Log("FriendlyEntity.OnReportedAsUnknown");
    }

    protected override void OnReportedAsSuspicious()
    {
        Debug.Log("FriendlyEntity.OnReportedAsSuspicious");
    }

    public override void Die()
    {
        //customs stuff can be added for both hostile and friendly
        base.Die();
    }
}