using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCreater : MonoBehaviour
{
    public List<GameObject> enemyGroup;
    GameObject cam;
    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Character")
        {
            GameObject g = enemyGroup[Random.Range(0, enemyGroup.Count - 1)];

            Instantiate(g, new Vector2(1.9f, transform.position.y + 5f), Quaternion.identity);
            cam.transform.position = new Vector3(0f, transform.position.y + 5f, -10f);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Character")
        {
           // Destroy(gameObject.transform.parent);
        }
    }

}