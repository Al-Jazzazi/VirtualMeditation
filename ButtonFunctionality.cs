/*
THe button functionality is the script for making the menu in the main menu scene 
functional where the user has three options: 
1. Going to a random environment 
2. Selecting a particular environment
    A desert or a forest
3. Quitting the program 

*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctionality : MonoBehaviour
{
    //Creating instance objects of the class
    [SerializeField]
    private GameObject MainButtons;
    [SerializeField]
    private GameObject SelectionButtons;

//The chooser button is activated when the user chooses to select from the enviroments rather than selecting a random enviroment
    public void Chooser()
    {

        MainButtons.SetActive(false);
        SelectionButtons.SetActive(true);

    }
//The backbutton function is when the user chooses to go back from the selecting scenes menu to the main menu where they can choose between quitting, random scene
//or choosing a scene
    public void BackButton()
    {

        MainButtons.SetActive(true);
        SelectionButtons.SetActive(false);

    }

    public void Randomize()
    {
    
        //A random method built in c# using Random.Range
        int numb;
        numb = Random.Range(0, 2);
        if (numb == 0)
        {
            SceneManager.LoadScene("Forest");
        }
        else
        {
            SceneManager.LoadScene("Desert");
        }

    }

    //If the user wants to quit progam, it closes the application 
    public void Quit()
    {

        Application.Quit();

    }


    //These two buttons load the selected scene. 
    public void ForestButton()
    {

        SceneManager.LoadScene("Forest");

    }

    public void DesertButton()
    {

        SceneManager.LoadScene("Desert");

    }

}
