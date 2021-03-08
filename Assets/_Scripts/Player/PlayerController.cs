using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;


public struct PlayerInputs
{
    public float MoveHorizontal;
    public float MoveVertical;
    public bool Interact;
}

public class PlayerController : NetworkBehaviour
{
    [SerializeField] private float speed;

    public bool canMove { get; private set; } = true;
    public bool canInteract { get; private set; } = true;

    private Rigidbody2D body;
    private Vector2 movementInput;
    private bool interactionRequested;

    private void Start() => body = GetComponent<Rigidbody2D>();

    private void FixedUpdate()
    {
        if (!isLocalPlayer)
            return;

        if (canMove)
            Move();
    }

    public void SetInputs(ref PlayerInputs _input)
    {
        movementInput = new Vector3(_input.MoveHorizontal, _input.MoveVertical);

        if (_input.Interact)
            interactionRequested = true;
    }

    private void Move()
    {
        body.MovePosition(body.position + movementInput * speed * Time.deltaTime);
    }

    #region Getters
    public bool CanMove => canMove;
    public bool CanInteract => canInteract;
    #endregion

    #region Setters
    public bool SetCanMove(bool value) => canMove = value;
    public bool SetCanInteract(bool value) => canInteract = value;
    #endregion
}
