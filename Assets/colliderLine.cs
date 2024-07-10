using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class colliderLine : MonoBehaviour
{
    private LineRenderer lineRenderer;

    public float colliderWidth;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        createColliders();
     
    }

    void createColliders()
    {
        EdgeCollider2D Collider2D = gameObject.AddComponent<EdgeCollider2D>();
        Vector3[] posiciones = new Vector3[lineRenderer.positionCount];
        lineRenderer.GetPositions(posiciones);

        List<Vector2> puntos = new List<Vector2>();
        for (int i = 0; i < posiciones.Length; i++)
        {
            Vector2 pos = posiciones[i];
            puntos.Add(pos);
        }
        
        Collider2D.SetPoints(puntos);
        Collider2D.edgeRadius = colliderWidth;
    }
}
