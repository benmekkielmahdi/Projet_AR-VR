using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animationClick : MonoBehaviour
{
    public Button rotateButton;       // assign your UI button here
    public float rotationSpeed = 40f;

    private bool isRotating = false;

    void Start()
    {
        // Add the button listener directly in the object script
        if (rotateButton != null)
        {
            rotateButton.onClick.AddListener(ToggleRotation);
        }
    }

    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.World);
        }
    }

    // This is called by the button
    void ToggleRotation()
    {
        isRotating = !isRotating;
    }
}
