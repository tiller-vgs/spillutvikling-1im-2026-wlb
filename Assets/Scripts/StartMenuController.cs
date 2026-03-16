using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
   public void OnStartClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Tester");
    }

    public void OnQuitClick()
    {
       Application.Quit(); 
    }
}
