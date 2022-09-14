using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public TMP_InputField ip;
    public Button proceed;
    public Button quit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Proceed()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
