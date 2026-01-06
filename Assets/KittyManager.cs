using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KittyManager : MonoBehaviour
{
    public GameObject[] kitties;

    // Start is called before the first frame update
    void Start()
    {
        // ---LOOPS---
        for (int i = 0; i < kitties.Length; i++)
        {
            Debug.Log("Setting kitty spin speed via manager" + i);

            // ---METHOD CALL (w/ parameter)---
            kitties[i].gameObject.GetComponent<CatBehavior>().setSpinSpeed(100.0f);
        }

        // or--- (enhanced for loop)
        //foreach (GameObject kitty in kitties)
        //{
        //    Debug.Log("Setting kitty spin speed via manager for " + kitty.name);
        //    kitty.gameObject.GetComponent<CatBehavior>().setSpinSpeed(100.0f);
        //}

        // or-- (while loop)
        int index = 0;
        //while (index < kitties.Length)
        //{
        //    Debug.Log("Setting kitty spin speed via manager " + index);
        //    kitties[index].gameObject.GetComponent<CatBehavior>().setSpinSpeed(100.0f);
        //    index++;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
