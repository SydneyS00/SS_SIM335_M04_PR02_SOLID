using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Selectable : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI lookPercentageLabel;

    [HideInInspector] public float LookPercentage;

    private void Update()
    {
        lookPercentageLabel.text = LookPercentage.ToString("F3"); 
    }
}
