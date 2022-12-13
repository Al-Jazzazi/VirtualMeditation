using UnityEngine;
using UnityEngine.SceneManagement;

public class smallMenu : MonoBehaviour
{

    [SerializeField]
    private GameObject pausemenu;



    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}