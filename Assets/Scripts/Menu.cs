using UnityEngine;
using UnityEngine.SceneManagement; // Necess�rio para carregar cenas

public class Menu : MonoBehaviour
{
    // Fun��o chamada quando o bot�o � clicado
    public void Play()
    {
        SceneManager.LoadScene("CenaJogo");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
