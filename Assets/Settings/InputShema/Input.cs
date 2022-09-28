// GENERATED AUTOMATICALLY FROM 'Assets/Settings/InputShema/Input.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace GameInput
{
    public class @Input : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @Input()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input"",
    ""maps"": [
        {
            ""name"": ""Bird"",
            ""id"": ""df136421-0a45-45c7-ad3a-d83d4ee1bfc8"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""88aabd61-b91c-4b06-8203-64bd768d7ff1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1cabb7a9-0ad6-4d4d-b74b-c505cb2044a8"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d60e051b-69fd-4201-80b5-206ec86dc662"",
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
        }
    ]
}");
            // Bird
            m_Bird = asset.FindActionMap("Bird", throwIfNotFound: true);
            m_Bird_Jump = m_Bird.FindAction("Jump", throwIfNotFound: true);
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

        // Bird
        private readonly InputActionMap m_Bird;
        private IBirdActions m_BirdActionsCallbackInterface;
        private readonly InputAction m_Bird_Jump;
        public struct BirdActions
        {
            private @Input m_Wrapper;
            public BirdActions(@Input wrapper) { m_Wrapper = wrapper; }
            public InputAction @Jump => m_Wrapper.m_Bird_Jump;
            public InputActionMap Get() { return m_Wrapper.m_Bird; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(BirdActions set) { return set.Get(); }
            public void SetCallbacks(IBirdActions instance)
            {
                if (m_Wrapper.m_BirdActionsCallbackInterface != null)
                {
                    @Jump.started -= m_Wrapper.m_BirdActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_BirdActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_BirdActionsCallbackInterface.OnJump;
                }
                m_Wrapper.m_BirdActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                }
            }
        }
        public BirdActions @Bird => new BirdActions(this);
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
        public interface IBirdActions
        {
            void OnJump(InputAction.CallbackContext context);
        }
    }
}
