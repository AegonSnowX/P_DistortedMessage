using System;
using UnityEngine;

public abstract class FriendlyEntity: BaseEntity
{
    private int score = -10;
    private void Start()
    {
        scoreValue = score;
    }

    protected override void OnReportedAsFriendly()
    {
        Debug.Log("FriendlyEntity.OnReportedAsFriendly");
    }

    protected override void OnReportedAsHostile()
    {
        Debug.Log("FriendlyEntity.OnReportedAsHostile");
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