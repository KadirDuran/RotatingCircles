using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCreater : MonoBehaviour
{
    public List<GameObject> enemyGroup;
    GameObject cam;
    List<string> colorPalet = new List<string>{
        "#115F66",
        "#156A73",
        "#1A757F",
        "#1F808B",
        "#248B97",
        "#2996A2",
        "#2EA1AE",
        "#33ACBA",
        "#38B7C5",
        "#3DC2D1" };
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
            Color colorx = new Color();
            ColorUtility.TryParseHtmlString(colorPalet[Random.Range(0, colorPalet.Count - 1)], out colorx);
            cam.GetComponent<Camera>().backgroundColor = colorx;
            cam.transform.position = new Vector3(0f, transform.position.y + 5f, -10f);
        }
    }
}