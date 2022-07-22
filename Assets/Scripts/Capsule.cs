using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Capsule : Shape
{
    private string shapeName = "Cool Capsule";
    private float area;
    private float radius;
    private float height;

    public GameObject textObj;
    private TextMeshProUGUI nameText;

    private void Start()
    {
        nameText = textObj.GetComponent<TextMeshProUGUI>();
        radius = gameObject.GetComponent<CapsuleCollider>().radius;
        height = gameObject.GetComponent<CapsuleCollider>().height;
    }

    protected override void DisplayInfo()
    {
        textObj.gameObject.SetActive(true);
        nameText.text = "Name: " + CapsuleName + "\nArea: " + CapsuleArea();
    }

    private void OnMouseDown()
    {
        DisplayInfo();
    }

    private void OnMouseUp()
    {
        textObj.gameObject.SetActive(false);
    }

    public string CapsuleName
    {
        get { return shapeName; }
    }

    private string CapsuleArea()
    {
        area = 2 * Mathf.PI * (radius * height);
        return area.ToString("0.00") + "sq.m";
    }
}
