using UnityEngine;

public class GameManeger : MonoBehaviour
{
    public float bgspeed = 1;
    public float ObstaculosSpeed = 1;

    public bool gamePlaying;
    public GameObject player;
    public GameObject obstaculoSpaw;
    public GameObject gameOverPanel;
    public GameObject gameStartpanel;

    

    
   public void Começar()
    {
        gamePlaying = true;
        obstaculoSpaw.SetActive(true);
        player.GetComponent<Rigidbody2D> ().gravityScale = 1;
        gameStartpanel.SetActive(false);
    }
    
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        gamePlaying = false;
        bgspeed = 0;
        ObstaculosSpeed = 0;

    }

}


