using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickExample : MonoBehaviour {

    public Color hoverColor = new Color(1f, 0f, 0f);
    public Color clickColor = new Color(0f, 1f, 0f);

    private BasicController ctl;
    private Color defaultColor = new Color(0f, 0f, 0f);
    private Renderer ren;

    private void Awake() {
        ctl = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<BasicController>();
        ren = GetComponent<Renderer>();
        defaultColor = ren.sharedMaterial.GetColor("_Color");
    }
	
	private void Update() {
        if (ctl.isLooking && ctl.isLookingAt == gameObject.name) {
            if (ctl.isDrawing) {
                ren.sharedMaterial.SetColor("_Color", clickColor);
            }
            else {
                ren.sharedMaterial.SetColor("_Color", hoverColor);
            }
        } else {
            ren.sharedMaterial.SetColor("_Color", defaultColor);
        }
	}

}
