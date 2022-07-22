using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sphere : Shape
{

    private string shapeName = "Super Sphere";
    private float area;
    private float radius;

    public GameObject textObj;
    private TextMeshProUGUI nameText;

    private void Start()
    {
        nameText = textObj.GetComponent<TextMeshProUGUI>();
        radius = gameObject.GetComponent<SphereCollider>().radius;
    }


    protected override void DisplayInfo()
    {
        textObj.gameObject.SetActive(true);
        nameText.text = "Name: " + SphereName + "\nArea: " + SphereArea();
    }

    private void OnMouseDown()
    {
        DisplayInfo();
    }

    private void OnMouseUp()
    {
        textObj.gameObject.SetActive(false);
    }

    public string SphereName
    {
        get { return shapeName; }
    }

    private string SphereArea()
    {
        area = 4 * Mathf.PI * (radius * radius);
        return area.ToString("0.00") + "sq.m";
    }
}
