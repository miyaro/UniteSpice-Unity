using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif // UNITY_EDITOR

[ExecuteInEditMode]
public class PositionsUtils : MonoBehaviour
{
    [SerializeField] public int positionCount = 4;

    [SerializeField] public float positionRadius = 2.5f;

    [SerializeField] public float baseAngle = 0.0f;

    public Vector3[] Positions { get; set; }

    private void Awake()
    {
        UpdatePositions();
    }

#if UNITY_EDITOR

    [SerializeField] protected Color debugSphereColor = Color.red;

    [SerializeField] protected float debugSphereRadius = 0.3f;

    protected virtual void OnDrawGizmos()
    {
        UpdatePositions();

        Gizmos.color = debugSphereColor;

        foreach (var pos in Positions)
            Gizmos.DrawSphere(pos, debugSphereRadius);
    }

#endif // UNITY_EDITOR

    public void UpdatePositions()
    {
        if (positionCount < 0)
            positionCount = 0;

        Positions = new Vector3[positionCount];

        Positions[0] = transform.position;

        if (positionCount == 0)
            return;

        var count = positionCount - 1;

        if (count > 0)
        {
            var angle = baseAngle * Mathf.PI / 180.0f;
            var angleStep = Mathf.PI * 2.0f / count;

            for (int i = 0; i < count; i++)
            {
                Positions[i + 1] = new Vector3(
                                       Mathf.Cos(angle) * positionRadius,
                                       0.0f,
                                       Mathf.Sin(angle) * positionRadius) + transform.position;
                angle += angleStep;
            }
        }
    }
}