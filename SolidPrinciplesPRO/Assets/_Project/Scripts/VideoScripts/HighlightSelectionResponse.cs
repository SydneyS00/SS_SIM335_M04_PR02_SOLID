using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class HighlightSelectionResponse : MonoBehaviour, ISelectionResponse
{
    [SerializeField] public Material highlightMaterial;
    [SerializeField] public Material defaultMaterial;

    public void OnSelect(Transform selection)
    {
        var selectionRenderer = selection.GetComponent<Renderer>();
        if (selectionRenderer != null)
        {
            //Gets replaced with logic that uses an asset instead of material
            //We are not completely deleting the code since this goes agains the Open/Close method
            selectionRenderer.material = this.highlightMaterial;
        }
    }

    public void OnDeselect(Transform selection)
    {
        var selectionRenderer = selection.GetComponent<Renderer>();
        if (selectionRenderer != null)
        {
            //Gets replaced with logic that uses an asset instead of material
            //We are not completely deleting the code since this goes agains the Open/Close method
            //We want to instead implement a new class that modifies the behavior without losing the old behavior
            selectionRenderer.material = this.defaultMaterial;
        }
    }
}
