
using UnityEngine;

public class OpenTreasure : MonoBehaviour
{
    public static int locksOpen;
    public Sprite openChestSprite;
    public GameObject prize;

    private void OnMouseDown()
    {
        locksOpen = KeyCounter.keyCount;

        if (KeyCounter.keyCount >= 3)
        {
            GetComponent<SpriteRenderer>().sprite = openChestSprite;
            prize.SetActive(true);
        }
    }
}
