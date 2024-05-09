using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEventer : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameObject gO = GameObject.FindGameObjectWithTag("Character");
        if (gO.transform.parent != null)
        {
            gO.transform.parent = null;
            gO.GetComponent<CharacterMove>().speed = 4f;

        }
    }
}
