﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectTo : MonoBehaviour
{
    private bool move = false;

    public bool cycle = false;
    public bool moveAtStart = false;

    public float speed = 2f;
    public Transform target;

    private Vector3 basePosition;
    private Vector3 targettedPosition;

    private void Start()
    {
        basePosition = this.transform.position;
        targettedPosition = target.position;
        if (moveAtStart)
            move = true;
    }
    public void StartMoving()
    {
        move = true;
    }

    public void StopMoving()
    {
        move = false;
    }


    void Update()
    {
        if(move)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, target.position, speed * Time.deltaTime);

            if (this.transform.position == targettedPosition && cycle)
                target.position = basePosition;
            else if (this.transform.position == basePosition && cycle)
                target.position = targettedPosition;

        }
    }
}
