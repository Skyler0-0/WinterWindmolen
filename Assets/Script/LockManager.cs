using UnityEngine;

public class LockManager : MonoBehaviour
{
    public int lockID;

    private void Update()
    {
        if (lockID < OpenTreasure.locksOpen)
        {
            Destroy(this.gameObject);
        }
    }
}
