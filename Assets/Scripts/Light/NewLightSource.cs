﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLightSource : MonoBehaviour
{
    public float lightRadius = 3.5f;

    private void Awake()
    {
        
    }

    private void Update()
    {
        transform.localScale = new Vector3(lightRadius * 2, lightRadius * 2, 1);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "LayeredObstacle")
        {
            other.GetComponent<NewLayeredObstacle>().AddLightSource(this);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "LayeredObstacle")
        {
            other.GetComponent<NewLayeredObstacle>().RemoveLightSource(this);
        }
    }
}