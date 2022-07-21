using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
    protected override void Greeting()
    {
        Debug.Log("This is a capsule!");
    }

    private void OnMouseDown()
    {
        Greeting();
    }
}
