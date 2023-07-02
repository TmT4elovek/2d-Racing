using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class Road : MonoBehaviour
{

    public Transform P0;
    public Transform P1;
    public Transform P2;
    public Transform P3;


    [Range(0, 1)]
    public float t;

    void Update()
    {
        
        transform.position = Bezier.GetPoint(P0.position, P1.position, P2.position, P3.position, t);

    }


    private void OnDrawGizmos()
    {
        int sigmentsNumber = 20;
        Vector2 preveousePoint = P0.position;

        for (int i = 0; i < sigmentsNumber + 1; i++)
        {
            float paremeter = (float)i / sigmentsNumber;
            Vector2 point = Bezier.GetPoint(P0.position, P1.position, P2.position, P3.position, paremeter);
            Gizmos.DrawLine(preveousePoint, point);
            preveousePoint = point;
        }



    }
}
