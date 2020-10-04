using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressTrigger : MonoBehaviour
{
    public int progress;

    void Start()
    {
        this.GetComponent<SpriteRenderer>().enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            SliderController.controller.SetProgress(progress);
        }
    }
}
