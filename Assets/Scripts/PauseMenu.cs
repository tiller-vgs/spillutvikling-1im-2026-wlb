using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
   public GameObject Container;
    // Update is called once per frame
    void Update()
    {
        

       if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Debug.Log("ESC pressed");

           Container.SetActive(true);
           Time.timeScale =0; 
        } 
    }

    public void Resume()
    {
        Container.SetActive(false);
           Time.timeScale =1; 
    }

    public void Menu()
    {
       UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
