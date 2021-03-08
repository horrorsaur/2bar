using System;
using System.Collections;
using System.Collections.Generic;
using Rewired;
using UnityEngine;


public class PlayerInput : MonoBehaviour
{
    private PlayerController controller;

    [Header("Skip input interpolation?")]
    [SerializeField] private bool useRawAxis;

    private Player inputControls;
    private int rewiredPlayerId = 0;

    [Header("Movement Input Actions")]
    // These are the actions listed under Rewired
    private const string HorizontalInput = "Move Horizontal";
    private const string VerticalInput = "Move Vertical";
    private const string InteractInput = "Interact";

    private void Awake() => inputControls = ReInput.players.GetPlayer(rewiredPlayerId);

    private void Start()
    {
        controller = GetComponent<PlayerController>();
    }

    private void Update()
    {
        HandleCharacterInput();
    }

    private void HandleCharacterInput()
    {
        PlayerInputs characterInputs = new PlayerInputs();

        characterInputs.MoveHorizontal = useRawAxis ? inputControls.GetAxisRaw(HorizontalInput) : inputControls.GetAxis(HorizontalInput);
        characterInputs.MoveVertical = useRawAxis ? inputControls.GetAxisRaw(VerticalInput) : inputControls.GetAxis(VerticalInput);
        characterInputs.Interact = inputControls.GetButtonDown(InteractInput);

        controller.SetInputs(ref characterInputs);
    }
}
