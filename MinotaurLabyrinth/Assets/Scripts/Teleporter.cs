using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject target;
    public bool entrance;
    public int rotation = 0;

    void Start()
    {
        this.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            if (entrance)
            {
                Vector3 diff = collision.gameObject.transform.position - gameObject.transform.position;
                collision.transform.position = target.transform.position + diff;
                collision.gameObject.transform.rotation *= Quaternion.Euler(0, rotation, 0);
            }
        }
    }
}
