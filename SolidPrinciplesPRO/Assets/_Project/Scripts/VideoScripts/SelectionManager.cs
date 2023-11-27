﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";

    private IRayProvider _rayProvider; 
    private ISelectionResponse _selectionResponse;
    private ISelector _selector; 

    private Transform _currentSelection;
    private Transform _selection; 

    private void Awake()
    {
        //Tutorial Stuff
        _selectionResponse = GetComponent<ISelectionResponse>();
        _rayProvider = GetComponent<IRayProvider>();
        _selector = GetComponent<ISelector>();

        //Slease stuff
        SceneManager.LoadScene("Environment", LoadSceneMode.Additive);
        SceneManager.LoadScene("UI", LoadSceneMode.Additive);
    }

    private void Update()
    {
        //Deselection/Selection response
        if (_currentSelection != null)
        {
            _selectionResponse.OnDeselect(_currentSelection);
        }

        _selector.Check(_rayProvider.CreateRay());
        _currentSelection = _selector.GetSelection(); 

        //Deselection/Selection 
        if (_currentSelection != null)
        {
            _selectionResponse.OnSelect(_currentSelection);
        }
    }

    
    
}





