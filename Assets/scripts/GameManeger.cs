using UnityEngine;

public class GameManeger : MonoBehaviour
{
    public float bgspeed = 1;
    public float Obstaculospeed;
    public void GameOver()
    {
        bgspeed = 0;
        Obstaculospeed = 0;
    }

}


