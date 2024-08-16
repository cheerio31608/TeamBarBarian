//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/1.Scripts/Shinwoo/PlayerInputTest.inputactions
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

public partial class @NpcInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @NpcInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputTest"",
    ""maps"": [
        {
            ""name"": ""NpcInput"",
            ""id"": ""a30e407a-78a4-4f0f-99fe-bd8b73fd71e7"",
            ""actions"": [
                {
                    ""name"": ""AutoMode"",
                    ""type"": ""Button"",
                    ""id"": ""aef6790b-6851-427c-8443-34428e930b74"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveNPC1"",
                    ""type"": ""Button"",
                    ""id"": ""746a3075-e861-4c2b-b932-743ff88d27de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveNPC2"",
                    ""type"": ""Button"",
                    ""id"": ""e85a9dc0-fb25-4f40-99c5-dd651efd47e6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveNPC3"",
                    ""type"": ""Button"",
                    ""id"": ""727cd413-9167-4ca5-a8ff-bffd0e88ac65"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveNPC4"",
                    ""type"": ""Button"",
                    ""id"": ""0a125284-3304-4ba4-bd95-a8d796b3feb9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChangeType1"",
                    ""type"": ""Button"",
                    ""id"": ""e10131d8-8967-4b9f-a418-64d7504fe8bd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChangeType2"",
                    ""type"": ""Button"",
                    ""id"": ""40b0e2bb-104e-4008-8484-9d720a03318a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""e0b94b63-54ca-466e-b229-0bfbc2aab62d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DrawAndSheath"",
                    ""type"": ""Button"",
                    ""id"": ""cfca167a-6c7a-420e-a7bc-d757702a291e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""111d9dc8-bd5e-4ddd-9825-beea84755448"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""AutoMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""4d205ff3-0bd7-46a4-a786-446b3bf7d22e"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveNPC1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Modifier"",
                    ""id"": ""8da187a4-e3f2-4e73-a078-f8efa27ae1bd"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveNPC1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Binding"",
                    ""id"": ""cfbdcc89-de8a-425a-afb9-beaf2bf12e0b"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveNPC1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""e9b5fdfe-8c5b-4ff6-8824-2ee573002ea6"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveNPC2"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Modifier"",
                    ""id"": ""1f67ccf7-be43-4c79-aaa8-a1f237909014"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveNPC2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Binding"",
                    ""id"": ""aaeac324-e7f0-4a43-90fb-ee4d299bb8eb"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveNPC2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""a49aef15-c39d-4c11-a7db-d9ecfbd62949"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveNPC3"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Modifier"",
                    ""id"": ""6d3965b4-d35e-4279-8ffc-d09067334468"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveNPC3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Binding"",
                    ""id"": ""51a8ae0b-1ed1-45fb-9751-ae5c3bdff47f"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveNPC3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""34657027-b86a-49b1-a05c-51d8a29bac75"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveNPC4"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Modifier"",
                    ""id"": ""347f71d6-49ff-4f64-9f37-b8a568ddc7e3"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveNPC4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Binding"",
                    ""id"": ""2a6d8984-94f1-4654-a2e6-bbe7c6a662af"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveNPC4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""eea56909-3d85-4161-96c1-b72a3b54dc7a"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeType1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Modifier"",
                    ""id"": ""5d098d04-6caf-4851-8afc-810e1ad2b20b"",
                    ""path"": ""<Keyboard>/alt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeType1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Binding"",
                    ""id"": ""c40daabf-6541-429a-9a66-1f4b27361eb1"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeType1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""66e11aae-5bad-45dd-b9f4-eb89bdf483aa"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeType2"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Modifier"",
                    ""id"": ""7ca4ce19-d29a-4ece-9c88-2827769ab580"",
                    ""path"": ""<Keyboard>/alt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeType2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Binding"",
                    ""id"": ""7f12b505-e26f-4b15-bb87-e52a72fe30f6"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeType2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""02999b26-5447-4750-8a60-8e3cc0c67336"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""21e189f9-5645-48b3-9f0d-5a3cde9ee7fc"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""DrawAndSheath"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardAndMouse"",
            ""bindingGroup"": ""KeyboardAndMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // NpcInput
        m_NpcInput = asset.FindActionMap("NpcInput", throwIfNotFound: true);
        m_NpcInput_AutoMode = m_NpcInput.FindAction("AutoMode", throwIfNotFound: true);
        m_NpcInput_MoveNPC1 = m_NpcInput.FindAction("MoveNPC1", throwIfNotFound: true);
        m_NpcInput_MoveNPC2 = m_NpcInput.FindAction("MoveNPC2", throwIfNotFound: true);
        m_NpcInput_MoveNPC3 = m_NpcInput.FindAction("MoveNPC3", throwIfNotFound: true);
        m_NpcInput_MoveNPC4 = m_NpcInput.FindAction("MoveNPC4", throwIfNotFound: true);
        m_NpcInput_ChangeType1 = m_NpcInput.FindAction("ChangeType1", throwIfNotFound: true);
        m_NpcInput_ChangeType2 = m_NpcInput.FindAction("ChangeType2", throwIfNotFound: true);
        m_NpcInput_Attack = m_NpcInput.FindAction("Attack", throwIfNotFound: true);
        m_NpcInput_DrawAndSheath = m_NpcInput.FindAction("DrawAndSheath", throwIfNotFound: true);
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

    // NpcInput
    private readonly InputActionMap m_NpcInput;
    private List<INpcInputActions> m_NpcInputActionsCallbackInterfaces = new List<INpcInputActions>();
    private readonly InputAction m_NpcInput_AutoMode;
    private readonly InputAction m_NpcInput_MoveNPC1;
    private readonly InputAction m_NpcInput_MoveNPC2;
    private readonly InputAction m_NpcInput_MoveNPC3;
    private readonly InputAction m_NpcInput_MoveNPC4;
    private readonly InputAction m_NpcInput_ChangeType1;
    private readonly InputAction m_NpcInput_ChangeType2;
    private readonly InputAction m_NpcInput_Attack;
    private readonly InputAction m_NpcInput_DrawAndSheath;
    public struct NpcInputActions
    {
        private @NpcInput m_Wrapper;
        public NpcInputActions(@NpcInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @AutoMode => m_Wrapper.m_NpcInput_AutoMode;
        public InputAction @MoveNPC1 => m_Wrapper.m_NpcInput_MoveNPC1;
        public InputAction @MoveNPC2 => m_Wrapper.m_NpcInput_MoveNPC2;
        public InputAction @MoveNPC3 => m_Wrapper.m_NpcInput_MoveNPC3;
        public InputAction @MoveNPC4 => m_Wrapper.m_NpcInput_MoveNPC4;
        public InputAction @ChangeType1 => m_Wrapper.m_NpcInput_ChangeType1;
        public InputAction @ChangeType2 => m_Wrapper.m_NpcInput_ChangeType2;
        public InputAction @Attack => m_Wrapper.m_NpcInput_Attack;
        public InputAction @DrawAndSheath => m_Wrapper.m_NpcInput_DrawAndSheath;
        public InputActionMap Get() { return m_Wrapper.m_NpcInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NpcInputActions set) { return set.Get(); }
        public void AddCallbacks(INpcInputActions instance)
        {
            if (instance == null || m_Wrapper.m_NpcInputActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_NpcInputActionsCallbackInterfaces.Add(instance);
            @AutoMode.started += instance.OnAutoMode;
            @AutoMode.performed += instance.OnAutoMode;
            @AutoMode.canceled += instance.OnAutoMode;
            @MoveNPC1.started += instance.OnMoveNPC1;
            @MoveNPC1.performed += instance.OnMoveNPC1;
            @MoveNPC1.canceled += instance.OnMoveNPC1;
            @MoveNPC2.started += instance.OnMoveNPC2;
            @MoveNPC2.performed += instance.OnMoveNPC2;
            @MoveNPC2.canceled += instance.OnMoveNPC2;
            @MoveNPC3.started += instance.OnMoveNPC3;
            @MoveNPC3.performed += instance.OnMoveNPC3;
            @MoveNPC3.canceled += instance.OnMoveNPC3;
            @MoveNPC4.started += instance.OnMoveNPC4;
            @MoveNPC4.performed += instance.OnMoveNPC4;
            @MoveNPC4.canceled += instance.OnMoveNPC4;
            @ChangeType1.started += instance.OnChangeType1;
            @ChangeType1.performed += instance.OnChangeType1;
            @ChangeType1.canceled += instance.OnChangeType1;
            @ChangeType2.started += instance.OnChangeType2;
            @ChangeType2.performed += instance.OnChangeType2;
            @ChangeType2.canceled += instance.OnChangeType2;
            @Attack.started += instance.OnAttack;
            @Attack.performed += instance.OnAttack;
            @Attack.canceled += instance.OnAttack;
            @DrawAndSheath.started += instance.OnDrawAndSheath;
            @DrawAndSheath.performed += instance.OnDrawAndSheath;
            @DrawAndSheath.canceled += instance.OnDrawAndSheath;
        }

        private void UnregisterCallbacks(INpcInputActions instance)
        {
            @AutoMode.started -= instance.OnAutoMode;
            @AutoMode.performed -= instance.OnAutoMode;
            @AutoMode.canceled -= instance.OnAutoMode;
            @MoveNPC1.started -= instance.OnMoveNPC1;
            @MoveNPC1.performed -= instance.OnMoveNPC1;
            @MoveNPC1.canceled -= instance.OnMoveNPC1;
            @MoveNPC2.started -= instance.OnMoveNPC2;
            @MoveNPC2.performed -= instance.OnMoveNPC2;
            @MoveNPC2.canceled -= instance.OnMoveNPC2;
            @MoveNPC3.started -= instance.OnMoveNPC3;
            @MoveNPC3.performed -= instance.OnMoveNPC3;
            @MoveNPC3.canceled -= instance.OnMoveNPC3;
            @MoveNPC4.started -= instance.OnMoveNPC4;
            @MoveNPC4.performed -= instance.OnMoveNPC4;
            @MoveNPC4.canceled -= instance.OnMoveNPC4;
            @ChangeType1.started -= instance.OnChangeType1;
            @ChangeType1.performed -= instance.OnChangeType1;
            @ChangeType1.canceled -= instance.OnChangeType1;
            @ChangeType2.started -= instance.OnChangeType2;
            @ChangeType2.performed -= instance.OnChangeType2;
            @ChangeType2.canceled -= instance.OnChangeType2;
            @Attack.started -= instance.OnAttack;
            @Attack.performed -= instance.OnAttack;
            @Attack.canceled -= instance.OnAttack;
            @DrawAndSheath.started -= instance.OnDrawAndSheath;
            @DrawAndSheath.performed -= instance.OnDrawAndSheath;
            @DrawAndSheath.canceled -= instance.OnDrawAndSheath;
        }

        public void RemoveCallbacks(INpcInputActions instance)
        {
            if (m_Wrapper.m_NpcInputActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(INpcInputActions instance)
        {
            foreach (var item in m_Wrapper.m_NpcInputActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_NpcInputActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public NpcInputActions @npcInput => new NpcInputActions(this);
    private int m_KeyboardAndMouseSchemeIndex = -1;
    public InputControlScheme KeyboardAndMouseScheme
    {
        get
        {
            if (m_KeyboardAndMouseSchemeIndex == -1) m_KeyboardAndMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardAndMouse");
            return asset.controlSchemes[m_KeyboardAndMouseSchemeIndex];
        }
    }
    public interface INpcInputActions
    {
        void OnAutoMode(InputAction.CallbackContext context);
        void OnMoveNPC1(InputAction.CallbackContext context);
        void OnMoveNPC2(InputAction.CallbackContext context);
        void OnMoveNPC3(InputAction.CallbackContext context);
        void OnMoveNPC4(InputAction.CallbackContext context);
        void OnChangeType1(InputAction.CallbackContext context);
        void OnChangeType2(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnDrawAndSheath(InputAction.CallbackContext context);
    }
}