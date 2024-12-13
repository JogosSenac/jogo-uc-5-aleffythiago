
using UnityEngine;

public class Textura : MonoBehaviour
{
    public float speed = 1;
    public GameManeger gm;
    public Renderer rem;

    // Update is called once per frame
    void Update()
    {
        rem.material.mainTextureOffset -= Vector2.left * Time.deltaTime * speed * gm.bgspeed;
    }
}
