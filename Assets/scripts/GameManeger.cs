using UnityEngine;

public class GameManeger : MonoBehaviour
{
    public float bgspeed = 1;
    public void GameOver()
    {
        bgspeed = 0;
    }
}
