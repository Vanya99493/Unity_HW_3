using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _birdPref;
    [SerializeField] private float _startDelay;
    [SerializeField] private float _spawnDelay;

    private Vector3[] _spawnPositions = new Vector3[] { new Vector3(-14.5f, -3f, 0f), new Vector3(-14.5f, 0f, 0f), new Vector3(-14.5f, 3f, 0f) };

    private void Start()
    {
        StartCoroutine(SpawnBirds());
    }

    private IEnumerator SpawnBirds()
    {
        yield return new WaitForSeconds(_startDelay);

        while (true)
        {
            Instantiate(_birdPref, _spawnPositions[Random.Range(0, _spawnPositions.Length)], Quaternion.identity);
            yield return new WaitForSeconds(_spawnDelay);
        }
    }
}