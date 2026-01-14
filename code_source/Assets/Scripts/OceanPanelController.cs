using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;
using System;

public class OceanPanelController : MonoBehaviour
{

    public GameObject panel;
    public TMP_Text showTxt;

    [Header("UI References (TMP)")]
    public TMP_Text oceanNameText;
    public TMP_Text oceanDescriptionText;

    private int currentIndex = 0;

    public GameObject vuforiaObject;

    // Ocean data
    private string[] oceanNames =
    {
        "Pacific Ocean",
        "Atlantic Ocean",
        "Indian Ocean",
        "Southern Ocean",
        "Arctic Ocean"
    };

    private string[] oceanDescriptions =
{
    "The largest and deepest ocean on Earth. It covers more than one-third of the planet’s surface and contains the deepest point on Earth, the Mariana Trench.",

    "Separates Europe and Africa from the Americas. It is the second-largest ocean and plays a major role in global climate and international trade routes.",

    "Located mainly in the Southern Hemisphere. It is the third-largest ocean and is known for its warm waters and important shipping and monsoon systems.",

    "Surrounds Antarctica and is extremely cold. It plays a key role in regulating Earth’s climate and ocean circulation with strong currents.",

    "The smallest and coldest ocean. It is mostly covered by ice and is home to unique wildlife adapted to very low temperatures."
};

    void Start()
    {
        UpdateUI();
    }

    public void NextOcean()
    {
        currentIndex++;

        if (currentIndex >= oceanNames.Length)
            currentIndex = 0; // Loop to first

        UpdateUI();
    }

    public void PreviousOcean()
    {
        currentIndex--;

        if (currentIndex < 0)
            currentIndex = oceanNames.Length - 1; // Loop to last

        UpdateUI();
    }

    private void UpdateUI()
    {
        oceanNameText.text = oceanNames[currentIndex];
        oceanDescriptionText.text = oceanDescriptions[currentIndex];
    }

    Boolean stat = false;
    public void showPanel()
    {
        if (stat == false)
        {
            panel.SetActive(true);
            stat = true;
            showTxt.text = "hide info";
            vuforiaObject.SetActive(!stat);
        }
        else
        {
            panel.SetActive(false);
            stat = false;
            showTxt.text = "show info";
            vuforiaObject.SetActive(!stat);

        }

    }

}