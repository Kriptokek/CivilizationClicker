using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class ClickableController : ViewController<ClickableView>
{
    private Camera _mainCamera;
    private bool _isDragging;
    private InputState _inputState;

    private void OnEnable()
    {
        _mainCamera = Camera.main;
        _inputState = InputState.Up;
    }

    public void OnMouseDown() 
    {
        View.ClickableSpriteRenderer.color = new Color(1f, 0.39f, 0.25f);
        _isDragging = true;
        _inputState = InputState.Down;
    }

    public void OnMouseUp()
    {
        View.ClickableSpriteRenderer.color = Color.white;
        _isDragging = false;
        _inputState = InputState.Up;
    }

    private void OnMouseDrag()
    {
        var cameraPosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition) + View.Offset;
        var newPosition = new Vector3(cameraPosition.x, cameraPosition.y, 0f);
        transform.position = newPosition;
        _inputState = InputState.Drag;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        ClickableController clickableController = other.GetComponent<ClickableController>();
        Debug.Log(clickableController);
        if (clickableController == null) return;
        
        if (_inputState != InputState.Up && clickableController.View.ElementId == View.ElementId)
        {
            Merge(other.gameObject);
        }
    }

    private void Merge(GameObject other)
    {
        View.jSignalInstantiate.Dispatch(View.ElementId + 1, gameObject.transform.position);
        Destroy(gameObject);
        Destroy(other);
    }
}

public enum InputState
{
    Up = 0,
    Down = 1,
    Drag = 2
}