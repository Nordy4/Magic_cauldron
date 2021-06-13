using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class DropManager : MonoBehaviour
{
    private int count = 0; 
    public ParticleSystem part;

    private void OnTriggerStay(Collider other){
        if(other.CompareTag("Cauldron") && count < 1){
            SoundManager.Instance.PlayWinGame();
            count = 1;
            part.Play();
            part.startColor = new Color(255,255,255);
        }
        Invoke("ResetGame", 7);
    }

    private void ResetGame(){
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );
    }
}
