using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPlayers : MonoBehaviour
{
    public List<Transform> target;

    public Vector3 offset;

    // Update is called once per frame
    void LateUpdate()
    {
        if(target.Count == 0)
            return;

        Vector3 centerPoint = GetPointCenter();
        Debug.Log(centerPoint.ToString());

        Vector2 newPosition = centerPoint + offset;

        transform.position = newPosition;
        transform.position += new Vector3(0,0,-10);
    }

    public void AddTargets (GameObject targetP)
    {
        target.Add(targetP.transform);
    }

    Vector3 GetPointCenter () 
    {
        if(target.Count == 1)
        {
            return target[0].position;
        }

        var bounds = new Bounds(target[0].position, Vector2.zero);

        for (int i = 0; i < target.Count; i++)
        {
            bounds.Encapsulate(target[i].position);
        }

        return bounds.center;
    }

     private float GetGreatestDistance()
    {
        var bounds = new Bounds(target[0].position, Vector3.zero);

        for (int i = 0; i < target.Count; i++)
        {
            bounds.Encapsulate(target[i].position);
        }

        return Mathf.Max(bounds.size.x, bounds.size.y);
    }
}
