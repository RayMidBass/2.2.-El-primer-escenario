using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeFont : MonoBehaviour
{
    public TMP_Text textElement; // Asigna el texto en el Inspector
    public TMP_FontAsset newFont; // Asigna la nueva fuente en el Inspector

    public void ChangeTextFont()
    {
        if (textElement != null && newFont != null)
        {
            textElement.font = newFont;
        }
    }
}

