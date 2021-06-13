using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class RecipeManager : MonoBehaviour
{
    private string[] colors = new string[] {"Red", "Blue", "Green", "Yellow", "Purple"};
    private string[] recipe = new string[5];
    public Text marcador;
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;
    public GameObject cube4;
    public GameObject cube5;

    public static RecipeManager Instance;
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        recipe = Shuffle(colors);
        marcador.text = "-->		-->		-->		-->";

        colorCube(cube1,  recipe[0]);
        colorCube(cube2,  recipe[1]);
        colorCube(cube3,  recipe[2]);
        colorCube(cube4,  recipe[3]);
        colorCube(cube5,  recipe[4]);
    }

    string[] Shuffle(string[] wordArray) {
        System.Random random = new System.Random();
        for (int i = wordArray.Length - 1; i > 0; i--){
            int swapIndex = random.Next(i + 1);
            string temp = wordArray[i];
            wordArray[i] = wordArray[swapIndex];
            wordArray[swapIndex] = temp;
        }
        return wordArray;
	}

    public string[] getRecipe(){
        return recipe;
    }

    public void colorCube(GameObject cube, String color){
        var cubeRenderer = cube.GetComponent<Renderer>();
        if(color == "Red"){
            cubeRenderer.material.SetColor("_Color", new Color(255,0,0));
        }
        if(color == "Blue"){
            cubeRenderer.material.SetColor("_Color", new Color(0,0,255));
        }
        if(color == "Green"){
            cubeRenderer.material.SetColor("_Color", new Color(0,255,0));
        }
        if(color == "Yellow"){
            cubeRenderer.material.SetColor("_Color", new Color(255,255,0));
        }
        if(color == "Purple"){
            cubeRenderer.material.SetColor("_Color", new Color(255,0,255));
        }

    }
}
