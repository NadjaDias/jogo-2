using UnityEngine;
using UnityEngine.SceneManagement; // Necessário para carregar cenas

public class Menu : MonoBehaviour
{
    // Função chamada quando o botão é clicado
    public void Play()
    {
        SceneManager.LoadScene("CenaJogo");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
