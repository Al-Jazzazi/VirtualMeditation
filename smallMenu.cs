/*
Small menu is added to the forest and desert scenes in case the user wants to go back,
Instead of having to go back by quitting the program and running it again, we choose 
to have the smallMenu in each scene 
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class smallMenu : MonoBehaviour
{

    [SerializeField]
    //Initilzing an instance object 
    private GameObject pausemenu;


//Two buttons, one for loading the main menu scene and the other for quitting the program
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
