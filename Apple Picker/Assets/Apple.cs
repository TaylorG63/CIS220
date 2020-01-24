using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        //print("In Update");
        if (transform.position.y < bottomY)
        {
            print("Inside the if statement");
            Destroy(this.gameObject);
        }
    }
}
