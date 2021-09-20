using System;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class ClickableController : ViewController<ClickableView>, IClickable
{
    private Camera _mainCamera;
    private InputState _inputState;

    private void OnEnable()
    {
        _mainCamera = Camera.main;
        _inputState = InputState.Up;
    }

    public void OnMouseDown() 
    {
        View.ClickableSpriteRenderer.color = new Color(1f, 0.39f, 0.25f);
        _inputState = InputState.Down;
    }

    public void OnMouseUp()
    {
        View.ClickableSpriteRenderer.color = Color.white;
        _inputState = InputState.Up;
        Click();
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
        var clickableController = other.GetComponent<ClickableController>();
        if (clickableController == null) return;
        
        if (_inputState != InputState.Up && clickableController.View.ElementId == View.ElementId)
        {
            Merge(clickableController);
        }
    }

    private void Merge(Component clickableController)
    {
        View.jSignalInstantiate.Dispatch(View.ElementId + 1, gameObject.transform.position);
        
        Destroy(gameObject);
        Destroy(clickableController.gameObject);
    }

    public void Click()
    {
        switch (View.NativeCurrencies)
        {
            case NativeCurrencies.Wooden:
                View.jPlayerProfile.PlayerResource.AddWoodenCurrency(View.NativeCurrencyProductivity);
                break;
            case NativeCurrencies.Iron:
                View.jPlayerProfile.PlayerResource.AddIronCurrency(View.NativeCurrencyProductivity);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        
        View.jPlayerProfile.PlayerResource.AddGoldCurrency(View.GoldCurrencyProductivity);
    }
}