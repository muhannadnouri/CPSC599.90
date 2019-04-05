using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public string MarkerName;
    public GameObject ObjectToToggleVisibility;
    private Renderer _textRenderer;
    private bool _isMarkerShowing;
    void Start()
    {
        _isMarkerShowing = false;
    }

    // Update is called once per frame
    void Update()
    {
        checkForTouch();
        checkForMouseClick();
        toggleInfoMarkerVisibility();
    }
    private void checkForTouch()
    {
        if (Input.touches.Length > 0)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                _isMarkerShowing = !_isMarkerShowing;
            }
        }
    }
    private void checkForMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                _isMarkerShowing = !_isMarkerShowing;
            }
        }
    }
    private void toggleInfoMarkerVisibility()
    {
        ObjectToToggleVisibility.SetActive(_isMarkerShowing);
    }
}