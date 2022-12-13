using UnityEngine;

public class Popups : MonoBehaviour
{

    [SerializeField]
    private GameObject popup1;
    [SerializeField]
    private GameObject popup2;
    [SerializeField]
    private GameObject popup3;

    

    public void next1()
    {
        popup1.SetActive(false);
        popup2.SetActive(true);
        popup3.SetActive(false);
    }

    public void next2()
    {
        popup2.SetActive(false);
        popup3.SetActive(true);
    }

    public void close()
    {
        popup3.SetActive(false);
    }
}
