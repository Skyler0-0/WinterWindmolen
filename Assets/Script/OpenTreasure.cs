
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenTreasure : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (KeyCounter.keyCount >= 3)
        {
            SceneManager.LoadScene("WinScreen");
        }
    }
}
