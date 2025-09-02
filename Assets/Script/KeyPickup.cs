using UnityEngine;


public class KeyPickup : MonoBehaviour
{
    public int keyID;
    public static bool destroyed = false;

    private void Awake()
    {
        if (destroyed && KeyCounter.keysDestroyed[keyID])
        {
            Destroy(this.gameObject);
        }
    }

    private void OnMouseDown()
    {
        KeyCounter.keyCount++;
        KeyCounter.keysDestroyed[keyID] = true;
        destroyed = true;
        Destroy(this.gameObject);
    }
}
