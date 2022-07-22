using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// INHERITANCE
public class Square : Shape
{
    private string shapeName = "Cosmic Cube";
    private float area;
    private float cubeSide;

    public GameObject textObj;
    private TextMeshProUGUI nameText;

    private void Start()
    {
        nameText = textObj.GetComponent<TextMeshProUGUI>();
        cubeSide = gameObject.GetComponent<BoxCollider>().size.x;
    }

    // POLYMORPHISM
    protected override void DisplayInfo()
    {
        textObj.gameObject.SetActive(true);
        nameText.text = "Name: " + CubeName + "\nArea: " + CubeArea();
    }

    private void OnMouseDown()
    {
        // ABSTRACTION
        DisplayInfo();
    }

    private void OnMouseUp()
    {
        textObj.gameObject.SetActive(false);
    }

    public string CubeName
    {
        // ENCAPSULATION
        get { return shapeName; }
    }

    private string CubeArea()
    {
        area = 6 * (cubeSide * cubeSide);
        return area.ToString("0.00") + "sq.m";
    }
}
