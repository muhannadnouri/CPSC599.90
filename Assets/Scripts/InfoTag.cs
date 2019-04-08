using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoTag : MonoBehaviour
{
    public string MarkerName;
    public GameObject ObjectToToggleVisibility;
    private Renderer _textRenderer;
    public Text TextObject;
    public string TextToDisplay;
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
    }
    private void checkForTouch()
    {
        if (Input.touches.Length > 0)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                bool isObjectHit = ObjectToToggleVisibility.name == hit.collider.gameObject.name;
                if (Physics.Raycast(ray, out hit) && isObjectHit) 
                {
                    _isMarkerShowing = !_isMarkerShowing;
                    if (_isMarkerShowing)
                    {
                        TextObject.text = TextToDisplay;
                    }
                    else
                    {
                        TextObject.text = "";
                    }

                    
                }

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
                bool isObjectHit = this.name == hit.collider.gameObject.transform.parent.name;
                if (Physics.Raycast(ray, out hit) && isObjectHit)
                {
                    _isMarkerShowing = !_isMarkerShowing;
                    if (_isMarkerShowing)
                    {
                        TextObject.text = TextToDisplay;
                    }
                    else
                    {
                        TextObject.text = "";
                    }
                }
            }
        }
    }
}
