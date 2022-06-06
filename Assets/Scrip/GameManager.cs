using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int lives = 3;
    public int contador=0;

    public void LossHealth(){
        lives--;

        if(lives <= 0){
            SceneManager.LoadScene("GameOver");
        }
        else{
            ResetLevel();
        }
    }

    public void ResetLevel(){
        FindObjectOfType<Ball>().ResetBall();
        FindObjectOfType<Player>().ResetPlayer();
    }
    

    public void CheckLevelCompleted(){
        int rand = Random.Range(1,3);
        if(rand==1){
            if(transform.childCount==1){
                SceneManager.LoadScene("pregunta");
            }
        }
        if(rand==2){
            if(transform.childCount==1){
                SceneManager.LoadScene("pregunta2");
            }
        }
        if(rand==3){
            if(transform.childCount==1){
                SceneManager.LoadScene("pregunta3");
            }
        }
    }
    
}
