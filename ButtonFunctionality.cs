using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctionality : MonoBehaviour
{
    [SerializeField]
    private GameObject MainButtons;
    [SerializeField]
    private GameObject SelectionButtons;


    public void Chooser()
    {

        MainButtons.SetActive(false);
        SelectionButtons.SetActive(true);

    }

    public void BackButton()
    {

        MainButtons.SetActive(true);
        SelectionButtons.SetActive(false);

    }

    public void Randomize()
    {

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

    public void Quit()
    {

        Application.Quit();

    }

    public void ForestButton()
    {

        SceneManager.LoadScene("Forest");

    }

    public void DesertButton()
    {

        SceneManager.LoadScene("Desert");

    }

}
