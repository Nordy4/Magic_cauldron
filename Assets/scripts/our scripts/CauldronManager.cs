using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using UnityEngine.SceneManagement;

public class CauldronManager : MonoBehaviour
{
    
   public GameObject cauldron;
   public GameObject drop;
   public string color = "";
   public ParticleSystem part;
   public Light light_red;
   public Light light_blue;
   public Light light_green;
   public Light light_yellow;
   public Light light_purple;
   private bool moveCauldron = false;
   public bool redPlayer = false;
   public bool bluePlayer = false;
   int aux = 0;

   public string[] recipe = new string[5]; 

   void Start()
    {
        recipe = RecipeManager.Instance.getRecipe();
    }

    void Update(){
        if(redPlayer && bluePlayer && moveCauldron){
            Vector3 newPosition = new Vector3(drop.transform.position.x,
                                            drop.transform.position.y,
                                            drop.transform.position.z);
            cauldron.transform.position = Vector3.Lerp(cauldron.transform.position, newPosition,Time.deltaTime);
        }  
        redPlayer = false;
        bluePlayer = false;

    }
    
    private void OnTriggerStay(Collider other){
        
        if(recipe.Length > 0 && !other.CompareTag("Player1") && !other.CompareTag("Player2")){
            if(other.gameObject.CompareTag(recipe[0])){
                if(color == ""){
                    color = recipe[0];
                    turnOnLight(recipe[0]);
                    Destroy(other.gameObject);
                    SoundManager.Instance.PlayCauldronSound();
                }
                else if(color == recipe[0]){
                    Destroy(other.gameObject);
                    color = "";
                    turnOffLight(recipe[0]);
                    turnOnParticles(recipe[0]);
                    recipe = recipe.Where((source, index)=>index != 0).ToArray();
                    SoundManager.Instance.PlayCauldronSound();
                    SoundManager.Instance.PlayOkObject(); 
                    if(recipe.Length == 0){
                        moveCauldron = true;
                    }                  
                }
            }
            else{
                aux++;
                if(aux <=1){
                    SoundManager.Instance.PlayLoseGame();
                }
                other.transform.SetParent(cauldron.transform, true);
                Invoke("ResetGame", 3);
            }
        }

        //Move cauldron
        if(moveCauldron){
            if(other.CompareTag("Player1")){
                redPlayer = true;              
            }
            if(other.CompareTag("Player2")){
                bluePlayer = true;
            }
        }
    }     

    private void onTriggerExit(Collider other){
        if(moveCauldron){
            if(other.CompareTag("Player1")){
                redPlayer = false;
            }
            if(other.CompareTag("Player2")){
                bluePlayer = false;
            }
            
        }
    }

    private void turnOnLight(string color){
        if(color == "Red"){
            light_red.intensity = 60;
        }
        if(color == "Blue"){
            light_blue.intensity = 60;
        }
        if(color == "Green"){
            light_green.intensity = 60;
        }
        if(color == "Yellow"){
            light_yellow.intensity = 60;
        }
        if(color == "Purple"){
            light_purple.intensity = 60;
        }
    }  

    private void turnOffLight(string color){
        if(color == "Red"){
            light_red.intensity = 0;
        }
        if(color == "Blue"){
            light_blue.intensity = 0;
        }
        if(color == "Green"){
            light_green.intensity = 0;
        }
        if(color == "Yellow"){
            light_yellow.intensity = 0;
        }
        if(color == "Purple"){
            light_purple.intensity = 0;
        }
    }

    private void turnOnParticles(string color){
        if(color == "Red"){
            part.Play();
            part.startColor = new Color(255,0,0);
        }
        if(color == "Blue"){
            part.Play();
            part.startColor = new Color(0,0,255);
        }
        if(color == "Green"){
            part.Play();
            part.startColor = new Color(0,255,0);
        }
        if(color == "Yellow"){
            part.Play();
            part.startColor = new Color(255,255,0);
        }
        if(color == "Purple"){
            part.Play();
            part.startColor = new Color(255,0,255);
        }
    } 
    

    private void ResetGame(){
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );
    }
}
