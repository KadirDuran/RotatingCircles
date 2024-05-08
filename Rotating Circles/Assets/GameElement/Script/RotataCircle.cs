using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotataCircle : MonoBehaviour
{
    public bool move = false;
    void FixedUpdate()
    {
        if(move)
            transform.Rotate(0, 0, 0.5f);
    }
}
