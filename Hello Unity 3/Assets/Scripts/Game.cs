using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    [SerializeField] private GameObject _playerObj;
    [SerializeField] private AudioSource _vietnamAudio;

    private Vector3[] _playerPositions = new Vector3[] { new Vector3(5f, -3f, 0f), new Vector3(5f, 0f, 0f), new Vector3(5f, 3f, 0f) };
    private int _currentPlayerPosition = 1;

    public void MoveUp()
    {
        if(_currentPlayerPosition < 2)
        {
            _playerObj.transform.position = _playerPositions[++_currentPlayerPosition];
        }
    }

    public void MoveDown()
    {
        if (_currentPlayerPosition > 0)
        {
            _playerObj.transform.position = _playerPositions[--_currentPlayerPosition];
        }
    }

    public void ChangeVietnamAudio(GameObject sender)
    {
        _vietnamAudio.volume = sender.gameObject.GetComponent<Scrollbar>().value;
    }
}