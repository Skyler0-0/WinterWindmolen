
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenTreasure : MonoBehaviour
{
    public static int locksOpen;

    private void OnMouseDown()
    {
        if (KeyCounter.keyCount >= 3)
        {
            SceneManager.LoadScene("WinScreen");
        }
        else
        {
            locksOpen = KeyCounter.keyCount;
        }
    }
}
