using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Square : Shape
{
    private string m_name = "Cosmic Cube";
    private float area;
    private float cubeSide;

    public GameObject textObj;
    private TextMeshProUGUI nameText;

    private void Start()
    {
        nameText = textObj.GetComponent<TextMeshProUGUI>();
        cubeSide = gameObject.GetComponent<BoxCollider>().size.x;

    }

    protected override void Greeting()
    {
        textObj.gameObject.SetActive(true);
        nameText.text = "name: " + cubeName + "\nArea: " + CubeArea();
    }

    private void OnMouseDown()
    {
        Greeting();
    }

    public string cubeName
    {
        get { return m_name; }
    }

    private string CubeArea()
    {
        area = 6 * Mathf.Sqrt(cubeSide);
        return area.ToString();
    }
}
