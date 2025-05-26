using UnityEngine;

public class Entity : MonoBehaviour
{
    public int cameraID;
    public Color entityColor;

    public void Assign(int camIndex, Color color)
    {
        cameraID = camIndex;
        entityColor = color;
        GetComponent<Renderer>().material.color = color;
    }

    public void HandleReport(ReportDecision decision)
    {
        // Extend later: scoring, feedback, etc.
        Debug.Log($"Entity on Camera {cameraID} reported as {decision}");
        Destroy(gameObject);
    }
}
