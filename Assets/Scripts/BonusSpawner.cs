using UnityEngine;

public class BonusSpawner : MonoBehaviour
{
    [Range(0, 100)]
    public float spawnChancePercent = 30f;

    public float heightOffset = 2.5f;

    void Start()
    {
        if (Random.Range(0f, 100f) > spawnChancePercent)
        {
            Destroy(gameObject);
            return;
        }

        float randomOffsetY = Random.Range(-heightOffset, heightOffset);

        Vector3 currentPos = transform.localPosition;
        transform.localPosition = new Vector3(currentPos.x, randomOffsetY, currentPos.z);
    }
}