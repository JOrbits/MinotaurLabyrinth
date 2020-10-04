using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObject : MonoBehaviour
{

    public GameObject[] enable;
    public GameObject[] disable;

    void Start()
    {
        this.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            foreach(GameObject e in enable)
            {
                e.SetActive(true);
            }

            foreach (GameObject e in disable)
            {
                e.SetActive(false);
            }
        }
    }
}
