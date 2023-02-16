//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Player Controls/ThirdPersonControl.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @ThirdPersonControl : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @ThirdPersonControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ThirdPersonControl"",
    ""maps"": [
        {
            ""name"": ""PlayerOnGround"",
            ""id"": ""0ec8972b-a99e-41bd-9633-6d3af00e7420"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""010468bd-d14f-4127-851f-e2285689273a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""c8f0282d-9f4e-4cd9-b206-614100083a1f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Caw"",
                    ""type"": ""Button"",
                    ""id"": ""ca985b4a-2cc4-4ee8-8c8e-c8c6cb08b9fc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a4f5dcb8-0464-43a4-ae16-887e56bfd5be"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9b30298b-93c3-40d3-8e8a-26e1bfa45e13"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""18d188c4-0b7a-4630-9468-72e0adfbc1a4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1fd74396-e00b-40c8-b60d-f1cb2d984a0f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""61bcf2ae-33d3-4696-b059-fe879fdada73"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8f13afb7-a269-42c3-a7be-9c3032360d2c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""142e4410-e508-40d1-9f55-b5679a6a2d63"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""86dcf674-655b-496a-b88f-b1bf5965fc00"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Caw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bab3126b-f43d-4072-abec-5a292cd5c184"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Caw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fde2b296-143b-4c44-a299-d370f4677a8e"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=12,y=12)"",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8213d428-8053-48ed-8829-0a089a56c9f1"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2(invertX=false)"",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5787e32-af5e-4612-96b1-feeb49832d29"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""890f4f38-1d7c-4d7f-b923-758d177cab4c"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Test"",
            ""id"": ""871a3a9f-037d-41a7-abbe-26e58287d8de"",
            ""actions"": [
                {
                    ""name"": ""UnlockMouse"",
                    ""type"": ""Button"",
                    ""id"": ""a39331cc-1682-4370-9c60-cfeaf3efa184"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fd957034-aaec-4671-a69c-47b2c469df9c"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UnlockMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerOnGround
        m_PlayerOnGround = asset.FindActionMap("PlayerOnGround", throwIfNotFound: true);
        m_PlayerOnGround_Movement = m_PlayerOnGround.FindAction("Movement", throwIfNotFound: true);
        m_PlayerOnGround_Jump = m_PlayerOnGround.FindAction("Jump", throwIfNotFound: true);
        m_PlayerOnGround_Caw = m_PlayerOnGround.FindAction("Caw", throwIfNotFound: true);
        m_PlayerOnGround_Look = m_PlayerOnGround.FindAction("Look", throwIfNotFound: true);
        // Test
        m_Test = asset.FindActionMap("Test", throwIfNotFound: true);
        m_Test_UnlockMouse = m_Test.FindAction("UnlockMouse", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerOnGround
    private readonly InputActionMap m_PlayerOnGround;
    private IPlayerOnGroundActions m_PlayerOnGroundActionsCallbackInterface;
    private readonly InputAction m_PlayerOnGround_Movement;
    private readonly InputAction m_PlayerOnGround_Jump;
    private readonly InputAction m_PlayerOnGround_Caw;
    private readonly InputAction m_PlayerOnGround_Look;
    public struct PlayerOnGroundActions
    {
        private @ThirdPersonControl m_Wrapper;
        public PlayerOnGroundActions(@ThirdPersonControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerOnGround_Movement;
        public InputAction @Jump => m_Wrapper.m_PlayerOnGround_Jump;
        public InputAction @Caw => m_Wrapper.m_PlayerOnGround_Caw;
        public InputAction @Look => m_Wrapper.m_PlayerOnGround_Look;
        public InputActionMap Get() { return m_Wrapper.m_PlayerOnGround; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerOnGroundActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerOnGroundActions instance)
        {
            if (m_Wrapper.m_PlayerOnGroundActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerOnGroundActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerOnGroundActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerOnGroundActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_PlayerOnGroundActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerOnGroundActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerOnGroundActionsCallbackInterface.OnJump;
                @Caw.started -= m_Wrapper.m_PlayerOnGroundActionsCallbackInterface.OnCaw;
                @Caw.performed -= m_Wrapper.m_PlayerOnGroundActionsCallbackInterface.OnCaw;
                @Caw.canceled -= m_Wrapper.m_PlayerOnGroundActionsCallbackInterface.OnCaw;
                @Look.started -= m_Wrapper.m_PlayerOnGroundActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerOnGroundActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerOnGroundActionsCallbackInterface.OnLook;
            }
            m_Wrapper.m_PlayerOnGroundActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Caw.started += instance.OnCaw;
                @Caw.performed += instance.OnCaw;
                @Caw.canceled += instance.OnCaw;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
            }
        }
    }
    public PlayerOnGroundActions @PlayerOnGround => new PlayerOnGroundActions(this);

    // Test
    private readonly InputActionMap m_Test;
    private ITestActions m_TestActionsCallbackInterface;
    private readonly InputAction m_Test_UnlockMouse;
    public struct TestActions
    {
        private @ThirdPersonControl m_Wrapper;
        public TestActions(@ThirdPersonControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @UnlockMouse => m_Wrapper.m_Test_UnlockMouse;
        public InputActionMap Get() { return m_Wrapper.m_Test; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TestActions set) { return set.Get(); }
        public void SetCallbacks(ITestActions instance)
        {
            if (m_Wrapper.m_TestActionsCallbackInterface != null)
            {
                @UnlockMouse.started -= m_Wrapper.m_TestActionsCallbackInterface.OnUnlockMouse;
                @UnlockMouse.performed -= m_Wrapper.m_TestActionsCallbackInterface.OnUnlockMouse;
                @UnlockMouse.canceled -= m_Wrapper.m_TestActionsCallbackInterface.OnUnlockMouse;
            }
            m_Wrapper.m_TestActionsCallbackInterface = instance;
            if (instance != null)
            {
                @UnlockMouse.started += instance.OnUnlockMouse;
                @UnlockMouse.performed += instance.OnUnlockMouse;
                @UnlockMouse.canceled += instance.OnUnlockMouse;
            }
        }
    }
    public TestActions @Test => new TestActions(this);
    public interface IPlayerOnGroundActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCaw(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
    }
    public interface ITestActions
    {
        void OnUnlockMouse(InputAction.CallbackContext context);
    }
}
