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
        marcador.text = recipe[0]+" -> "+
                        recipe[1]+" -> "+
                        recipe[2]+" -> "+
                        recipe[3]+" -> "+
                        recipe[4];
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
