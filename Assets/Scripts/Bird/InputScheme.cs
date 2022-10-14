// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Bird/InputScheme.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputScheme : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputScheme()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputScheme"",
    ""maps"": [
        {
            ""name"": ""BirdMover"",
            ""id"": ""38501164-c90a-4805-a15b-509f68f48332"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""267a4fb4-5bb2-4780-a098-7c3ef2a75b8d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""822ba51e-d93e-41dc-ba8d-9c3695f9923e"",
                    ""path"": ""<Touchscreen>/touch0/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""35b8aa4b-d474-4603-ad09-3591fd503268"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PC"",
            ""bindingGroup"": ""PC"",
            ""devices"": []
        },
        {
            ""name"": ""Mobile"",
            ""bindingGroup"": ""Mobile"",
            ""devices"": []
        },
        {
            ""name"": ""GameController"",
            ""bindingGroup"": ""GameController"",
            ""devices"": []
        }
    ]
}");
        // BirdMover
        m_BirdMover = asset.FindActionMap("BirdMover", throwIfNotFound: true);
        m_BirdMover_Jump = m_BirdMover.FindAction("Jump", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // BirdMover
    private readonly InputActionMap m_BirdMover;
    private IBirdMoverActions m_BirdMoverActionsCallbackInterface;
    private readonly InputAction m_BirdMover_Jump;
    public struct BirdMoverActions
    {
        private @InputScheme m_Wrapper;
        public BirdMoverActions(@InputScheme wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_BirdMover_Jump;
        public InputActionMap Get() { return m_Wrapper.m_BirdMover; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BirdMoverActions set) { return set.Get(); }
        public void SetCallbacks(IBirdMoverActions instance)
        {
            if (m_Wrapper.m_BirdMoverActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_BirdMoverActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_BirdMoverActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_BirdMoverActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_BirdMoverActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public BirdMoverActions @BirdMover => new BirdMoverActions(this);
    private int m_PCSchemeIndex = -1;
    public InputControlScheme PCScheme
    {
        get
        {
            if (m_PCSchemeIndex == -1) m_PCSchemeIndex = asset.FindControlSchemeIndex("PC");
            return asset.controlSchemes[m_PCSchemeIndex];
        }
    }
    private int m_MobileSchemeIndex = -1;
    public InputControlScheme MobileScheme
    {
        get
        {
            if (m_MobileSchemeIndex == -1) m_MobileSchemeIndex = asset.FindControlSchemeIndex("Mobile");
            return asset.controlSchemes[m_MobileSchemeIndex];
        }
    }
    private int m_GameControllerSchemeIndex = -1;
    public InputControlScheme GameControllerScheme
    {
        get
        {
            if (m_GameControllerSchemeIndex == -1) m_GameControllerSchemeIndex = asset.FindControlSchemeIndex("GameController");
            return asset.controlSchemes[m_GameControllerSchemeIndex];
        }
    }
    public interface IBirdMoverActions
    {
        void OnJump(InputAction.CallbackContext context);
    }
}
