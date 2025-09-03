
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningPrize : MonoBehaviour
{
    private bool isWinning = false;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(-1.72f, 2.88f, 0), 0.005f);
        
        if (!isWinning && transform.position.y >= 2.88f)
        {
            isWinning = true;
            StartCoroutine(WinGame());
        }
    }

    IEnumerator WinGame()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("WinScreen");
    }
}
