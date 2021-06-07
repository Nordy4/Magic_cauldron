using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CauldronManager : MonoBehaviour
{
   public string color = "";
   public GameObject poties; 
   public ParticleSystem part;
   public Light light_red;
   public Light light_blue;
   public Light light_green;
   public Light light_yellow;
   public Light light_purple;
   private bool moveCauldron = false;

   public string[] recipe = new string[5]; 

   void Start()
    {
        recipe = RecipeManager.Instance.getRecipe();
    }
    
    private void OnTriggerEnter(Collider other){
        if(recipe.Length > 0){
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
                    if(recipe.Length > 0){
                        SoundManager.Instance.PlayCauldronSound();
                        SoundManager.Instance.PlayOkObject();
                    }
                    else{
                        SoundManager.Instance.PlayWinGame();
                    }
                    
                }
                else{
                    other.transform.SetParent(poties.transform, true);
                    SoundManager.Instance.PlayLoseGame();
                }
            }
            else{
                other.transform.SetParent(poties.transform, true);
                SoundManager.Instance.PlayLoseGame();
            }
        }
        else{
            moveCauldron = true;
            SoundManager.Instance.PlayWinGame();
        }
          
    }     

    private void turnOnLight(string color){
        if(color == "Red"){
            light_red.intensity = 15;
        }
        if(color == "Blue"){
            light_blue.intensity = 15;
        }
        if(color == "Green"){
            light_green.intensity = 15;
        }
        if(color == "Yellow"){
            light_yellow.intensity = 15;
        }
        if(color == "Purple"){
            light_purple.intensity = 15;
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

        /*
        if((other.gameObject.CompareTag("Red"))){
            if(color == ""){
                color = "Red";
                light_red.intensity = 15;
                Destroy(other.gameObject);
            }
            else if(color == "Red"){
                Destroy(other.gameObject);
                color = "";
                light_red.intensity = 0;
                part.Play();
                part.startColor = new Color(255,0,0);
            }
            else{
                other.transform.SetParent(poties.transform, true);
            }
        }

        if((other.gameObject.CompareTag("Blue"))){
            if(color == ""){
                color = "Blue";
                light_blue.intensity = 15;
                Destroy(other.gameObject);
            }
            else if(color == "Blue"){
                Destroy(other.gameObject);
                light_blue.intensity = 0;
                color = "";
                part.Play();
                part.startColor = new Color(0,0,255);
            }
            else{
                other.transform.SetParent(poties.transform, true);
            }
        }

        if((other.gameObject.CompareTag("Green"))){
            if(color == ""){
                color = "Green";
                light_green.intensity = 15;
                Destroy(other.gameObject);
            }
            else if(color == "Green"){
                Destroy(other.gameObject);
                color = "";
                light_green.intensity = 0;
                part.Play();
                part.startColor = new Color(0,255,0);
            }
            else{
                other.transform.SetParent(poties.transform, true);
            }
        }

        if((other.gameObject.CompareTag("Yellow"))){
            if(color == ""){
                color = "Yellow";
                light_yellow.intensity = 15;
                Destroy(other.gameObject);
            }
            else if(color == "Yellow"){
                Destroy(other.gameObject);
                color = "";
                light_yellow.intensity = 0;
                part.Play();
                part.startColor = new Color(255,255,0);
            }
            else{
                other.transform.SetParent(poties.transform, true);
            }
        }

        if((other.gameObject.CompareTag("Purple"))){
            if(color == ""){
                color = "Purple";
                light_purple.intensity = 15;
                Destroy(other.gameObject);
            }
            else if(color == "Purple"){
                Destroy(other.gameObject);
                color = "";
                light_purple.intensity = 0;
                part.Play();
                part.startColor = new Color(255,0,255);
            }
            else{
                other.transform.SetParent(poties.transform, true);
            }
        }*/
    
}
