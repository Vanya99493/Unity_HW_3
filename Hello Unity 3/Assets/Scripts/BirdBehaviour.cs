using System.Collections;
using UnityEngine;

public class BirdBehaviour : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        transform.Translate(new Vector3(_speed * Time.fixedDeltaTime, 0, 0));
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        _animator.SetBool("explosion_b", true);
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(gameObject);
    }
}