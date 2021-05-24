using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauldronManager : MonoBehaviour
{
   public string color = "";
   public GameObject poties; 
   public ParticleSystem part;
   public Light light;


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        
        if((other.gameObject.CompareTag("Red"))){
            if(color == ""){
                color = "Red";
                light.color = new Color(255,0,0);
                light.intensity = 50;
                Destroy(other.gameObject);
            }
            else if(color == "Red"){
                Destroy(other.gameObject);
                color = "";
                light.intensity = 0;
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
                light.color = new Color(0,0,255);
                light.intensity = 50;
                Destroy(other.gameObject);
            }
            else if(color == "Blue"){
                Destroy(other.gameObject);
                light.intensity = 0;
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
                light.color = new Color(0,255,0);
                light.intensity = 50;
                Destroy(other.gameObject);
            }
            else if(color == "Green"){
                Destroy(other.gameObject);
                color = "";
                light.intensity = 0;
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
                light.color = new Color(255,255,0);
                light.intensity = 50;
                Destroy(other.gameObject);
            }
            else if(color == "Yellow"){
                Destroy(other.gameObject);
                color = "";
                light.intensity = 0;
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
                light.color = new Color(255,0,255);
                light.intensity = 50;
                Destroy(other.gameObject);
            }
            else if(color == "Purple"){
                Destroy(other.gameObject);
                color = "";
                light.intensity = 0;
                part.Play();
                part.startColor = new Color(255,0,255);
            }
            else{
                other.transform.SetParent(poties.transform, true);
            }
        }
    }
}
