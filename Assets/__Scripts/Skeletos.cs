﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Skeletos : Enemy
{ // a
    [Header("Set in Inspector: Skeletos")] // b
    public int speed = 2;
    public float timeThinkMin = 1f;
    public float timeThinkMax = 4f;
    [Header("Set Dynamically: Skeletos")]
    public int facing = 0;
    public float timeNextDecision = 0;
    void Update()
    {
        if (Time.time >= timeNextDecision)
        { // c
            DecideDirection();
        }
        // rigid is inherited from Enemy and is initialized in Enemy.Awake()
        rigid.velocity = directions[facing] * speed;
    }
    void DecideDirection()
    { // d
        facing = Random.Range(0, 4);
        timeNextDecision = Time.time + Random.Range(timeThinkMin, timeThinkMax);
    }
}