using UnityEngine;
using UnityEngine.InputSystem;

namespace UnityTask.BasketballProject
{
    public class ThrowingBall : MonoBehaviour
    {
        private InputActions _inputActions;

        private Vector2 _tapStartPos;
        private Vector2 _tapCurrentPos;

        void Start()
        {
            if (_inputActions == null)
            {
                _inputActions = new InputActions();
            }
            _inputActions.Enable();
            _inputActions.TouchScreen.Tap.started += TapStarted;
            _inputActions.TouchScreen.Tap.performed += TapPerformed;
            _inputActions.TouchScreen.Tap.canceled += TapCanceled;
        }

        private void TapStarted(InputAction.CallbackContext ctx)
        {
            _tapStartPos = ctx.ReadValue<Vector2>();
        }

        private void TapPerformed(InputAction.CallbackContext ctx)
        {
            _tapCurrentPos = ctx.ReadValue<Vector2>();
        }

        private void TapCanceled(InputAction.CallbackContext ctx)
        {
            Vector2 dif = _tapCurrentPos - _tapStartPos;
            gameObject.GetComponent<BallManager>().ThrowBall(new Vector3(dif.x, dif.y, dif.y));
        }

        private void OnDestroy()
        {
            _inputActions.TouchScreen.Tap.started -= TapStarted;
            _inputActions.TouchScreen.Tap.performed -= TapPerformed;
            _inputActions.TouchScreen.Tap.canceled -= TapCanceled;
        }
    }
}

