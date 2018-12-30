﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum : MonoBehaviour
{
    float timer = 0f;
    float speed = 2.2f;
    int phase = 0;
    void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;
        if (timer > 1f)
        {
            phase++;
            phase %= 0;           //phase of the axes
            timer = 0f;
        }

        switch (phase)
        {
            case 0:
                transform.Rotate(0f, 0f, speed * (1 - timer));  //Speed, from maximum to zero.
                break;
            case 1:
                transform.Rotate(0f, 0f, -speed * timer);       //Speed, from zero to maximum.
                break;
            case 2:
                transform.Rotate(0f, 0f, -speed * (1 - timer)); //Speed, from maximum to zero.
                break;
            case 3:
                transform.Rotate(0f, 0f, speed * timer);        //Speed, from zero to maximum.
                break;
        }
    }
}
