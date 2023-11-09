using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;

    private IMovable _movableObject;

    private void Start()
    {
        _movableObject = _gameObject.GetComponent<IMovable>();
        if (_movableObject == null)
            Debug.Log("Game object doesn't have IMovable interface");
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            _movableObject.Move();
    }
}
