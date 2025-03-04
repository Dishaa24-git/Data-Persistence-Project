using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;  // Make sure to include this if using TextMeshPro

public class StartMenu : MonoBehaviour
{
    public TMP_InputField playerNameInput; // Assign in the inspector

    public void StartGame()
    {
        string playerName = playerNameInput.text;

        if (!string.IsNullOrEmpty(playerName))
        {
            PlayerPrefs.SetString("PlayerName", playerName);  // Save player name
            PlayerPrefs.Save();  // Save PlayerPrefs changes

            SceneManager.LoadScene("Main");  // Ensure Main scene name is correct
        }
    }
}
