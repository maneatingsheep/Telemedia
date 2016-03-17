using UnityEngine;
using System.Collections;

public class SRGUIInput : SRBaseGUIElement {

    public string Text = "";
    public GUIStyle Style;
    public bool isMultyLine = false;

    internal void SetSize(Vector2 size) {
        _Size = size;
    }
}
