using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatBehavior : MonoBehaviour
{

    // ---DECLARING VARIABLES---
    public bool isSpinning;

    // or:
    [SerializeField] private float spinSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        isSpinning = true;
        Debug.Log(name + " isSpinning at start  is " + isSpinning);
        Debug.Log(name + " Spin speed at start is " + spinSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        // ---CONDITIONAL---
        if (isSpinning)
        {
            // ---METHOD CALL---
            Spin();
        }
    }

    // ---METHOD DECLARATION---
    private void Spin()
    {
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }

    // ---METHOD DECLARATION (w paramater)---
    public void setSpinSpeed(float speed)
    {
        Debug.Log("Setting spin speed to " + speed);
        spinSpeed = speed;
    }
}
