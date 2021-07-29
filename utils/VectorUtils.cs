using UnityEngine;

public class VectorUtils
{
    public static bool CompareDistance(Vector2 pointA, Vector2 pointB, float dist)
    {
        return (pointA - pointB).sqrMagnitude < dist * dist;
    }
}