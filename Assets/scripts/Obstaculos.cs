
using Unity.VisualScripting;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    public float speed;
    private GameManeger gm;
    void Start()
    {
        gm = FindObjectOfType<GameManeger>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position +=   Vector3.left * Time.deltaTime * speed * gm.ObstaculosSpeed;
    }
}
