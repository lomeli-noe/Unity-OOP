using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    protected override void Greeting()
    {

        Debug.Log("This is a sphere!");
    }

    private void OnMouseDown()
    {
        Greeting();
    }
}
