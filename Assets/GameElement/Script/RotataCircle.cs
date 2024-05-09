using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RotataCircle : MonoBehaviour
{
    public bool move = false;
    GameObject gObj;
    void FixedUpdate()
    {
        if(move)
            transform.Rotate(0, 0, 0.5f);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Character")
        {
            if(gameObject.transform.parent.gameObject.transform.parent != null)
            {
                gObj = gameObject.transform.parent.gameObject.transform.parent.gameObject;
            }
            else{
                gObj = gameObject.transform.parent.gameObject; 
            }
            
            InvokeRepeating("DestroyEnemyGroup", 2f, 1f);
        }
    }
    void DestroyEnemyGroup()
    {
        Destroy(gObj);
        CancelInvoke("DestroyEnemyGroup");
    }
}
