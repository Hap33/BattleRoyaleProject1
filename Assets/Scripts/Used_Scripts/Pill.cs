﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pill : MonoBehaviour {

    public int rotationSpeed;
    public float hooveringSpeed, distHoovering;

    private Vector3 initPos;
    private float hooveUp, hooveDown;
    private int hooveDir;

    private void Start()
    {
        initPos = this.transform.position;
        hooveDown = initPos.y - (distHoovering / 2);
        hooveUp = initPos.y + (distHoovering / 2);
        hooveDir = 1;
    }

    void Update () {
        //Rotate the pumpkin
        this.transform.RotateAround(this.transform.position, Vector3.up, rotationSpeed * Time.timeScale);

        //Move the pumpkin up and down
        if (this.transform.position.y > hooveUp)
            hooveDir = -1;
        else if (this.transform.position.y < hooveDown) 
            hooveDir = 1;

        this.GetComponent<Rigidbody>().velocity = new Vector3(0, hooveDir * hooveringSpeed * Time.timeScale, 0);
    }
}
