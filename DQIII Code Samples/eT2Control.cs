﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eT2Control : MonoBehaviour
{

    //Platform and enemy route script
    
    public Transform pos1, pos2;

    public float speed;

    public Transform startPos;

    Vector3 nextPos;

    private void Start()
    {
        nextPos = startPos.position;
    }

    private void Update()
    {
        if(transform.position == pos1.position)
        {
            nextPos = pos2.position;
        }
        
        else if(transform.position == pos2.position)
        {
            nextPos = pos1.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }

    
}
