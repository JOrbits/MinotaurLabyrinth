using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public Material lineMat;
    public GameObject player;
    public LayerMask mask;

    void DrawRays()
    {
        lineMat.SetPass(0);
        float step = 0.1f;
        GL.Begin(GL.TRIANGLE_STRIP);
        GL.Color(new Color(lineMat.color.r, lineMat.color.g, lineMat.color.b, lineMat.color.a));
        for (float i=0; i<360; i += step)
        {
            Vector2 hit = GetHitPoint(new Vector2(Mathf.Cos(i * Mathf.Deg2Rad), Mathf.Sin(i * Mathf.Deg2Rad)));
            GL.Vertex3(hit.x, hit.y, 0);

            GL.Vertex3(player.transform.position.x, player.transform.position.y, 0);
        }

        Vector2 hitX = GetHitPoint(new Vector2(Mathf.Cos(0 * Mathf.Deg2Rad), Mathf.Sin(0 * Mathf.Deg2Rad)));
        GL.Vertex3(hitX.x, hitX.y, 0);

        GL.End();
    }

    Vector2 GetHitPoint(Vector2 direction)
    {
        RaycastHit2D hit = Physics2D.Raycast(player.transform.position, direction, 30, mask);
        if (hit)
        {
            return new Vector2(hit.point.x, hit.point.y);
        }
        else
        {
            return new Vector2(player.transform.position.x + (15 * direction.x), player.transform.position.y + (15 * direction.y));
        }
    }

    void OnPostRender()
    {
        DrawRays();
    }
}
