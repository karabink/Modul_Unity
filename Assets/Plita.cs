﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plita : MonoBehaviour
{
    public float Speed = 0.5f;

    public Vector3 Direction;

    // Start is called before the first frame update

    void Start()

    {

        Direction = transform.right;

    }

    // Update is called once per frame

    void Update()

    {

        transform.Translate(Direction * Speed * Time.deltaTime);

    }
}
