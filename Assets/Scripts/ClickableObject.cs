﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver() {
        if (Input.GetMouseButtonDown(0)) {
            transform.Translate(0, 1, 0);
        }
    }
}