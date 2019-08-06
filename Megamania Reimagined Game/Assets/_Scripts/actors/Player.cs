﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Ship
{

    #region ATTRIBUTES
    [Header("Shooting Data")]
    public KeyCode DebugKey; //change this to touch controls
    #endregion

    protected override void OnDeath()
    {
        Debug.Log("explode");
    }

    protected override void shoot()
    {
        realTime = Time.time;

        if (Input.GetKey(DebugKey) && realTime >= nextFire)
        {
            Debug.Log("shot");
            nextFire =realTime + fireRate;
        }

    }

    // Start is called before the first frame update
    protected override void Start()
    {

        movement = new Play();
        base.Start();

    }

}
