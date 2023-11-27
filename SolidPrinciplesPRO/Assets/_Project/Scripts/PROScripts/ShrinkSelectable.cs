using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkSelectable : MonoBehaviour, ISelectionResponse
{
    [SerializeField] Material shrinkMaterial;
    [SerializeField] Material normalMaterial; 
    public void OnSelect(Transform selection)
    {
        //Our selectable object will shrink when hovered over
        var shrinkableObj = selection.GetComponent<Transform>();
        var shrinkScale = selection.transform.localScale / 0.5f;

        //It will also change color when it shrinks 
        var shrinkableMat = shrinkableObj.GetComponent<Renderer>(); 

        if(shrinkableObj != null)
        {
            shrinkableObj.transform.localScale = shrinkScale;

            shrinkableMat.material = shrinkMaterial; 
        }
    }

    public void OnDeselect(Transform selection)
    {
        //Will return to its normal size when it is not in a selectable range 
        var returnToSizeObj = selection.GetComponent<Transform>();
        var normalScale = selection.transform.localScale * 0.5f;

        //Will also return back to original color 
        var normalMat = selection.GetComponent<Renderer>(); 

        if(returnToSizeObj != null)
        {
            returnToSizeObj.transform.localScale = normalScale;

            normalMat.material = normalMaterial; 
        }
    }
}
