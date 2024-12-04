﻿using System;
using System.Collections.Generic;
namespace SLua {
	[LuaBinder(1)]
	public class BindUnityUI {
		public static Action<IntPtr>[] GetBindList() {
			Action<IntPtr>[] list= {
				Lua_UnityEngine_UI_AnimationTriggers.reg,
				Lua_UnityEngine_EventSystems_UIBehaviour.reg,
				Lua_UnityEngine_UI_Selectable.reg,
				Lua_UnityEngine_UI_Button.reg,
				Lua_UnityEngine_UI_CanvasUpdate.reg,
				Lua_UnityEngine_UI_ICanvasElement.reg,
				Lua_UnityEngine_UI_CanvasUpdateRegistry.reg,
				Lua_UnityEngine_UI_ColorBlock.reg,
				Lua_UnityEngine_UI_ClipperRegistry.reg,
				Lua_UnityEngine_UI_Clipping.reg,
				Lua_UnityEngine_UI_IClipper.reg,
				Lua_UnityEngine_UI_IClippable.reg,
				Lua_UnityEngine_UI_DefaultControls.reg,
				Lua_UnityEngine_UI_Dropdown.reg,
				Lua_UnityEngine_UI_FontData.reg,
				Lua_UnityEngine_UI_FontUpdateTracker.reg,
				Lua_UnityEngine_UI_Graphic.reg,
				Lua_UnityEngine_EventSystems_BaseRaycaster.reg,
				Lua_UnityEngine_UI_GraphicRaycaster.reg,
				Lua_UnityEngine_UI_GraphicRegistry.reg,
				Lua_UnityEngine_UI_IMaskable.reg,
				Lua_UnityEngine_UI_MaskableGraphic.reg,
				Lua_UnityEngine_UI_Image.reg,
				Lua_UnityEngine_UI_InputField.reg,
				Lua_UnityEngine_UI_AspectRatioFitter.reg,
				Lua_UnityEngine_UI_CanvasScaler.reg,
				Lua_UnityEngine_UI_ContentSizeFitter.reg,
				Lua_UnityEngine_UI_LayoutGroup.reg,
				Lua_UnityEngine_UI_GridLayoutGroup.reg,
				Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.reg,
				Lua_UnityEngine_UI_HorizontalLayoutGroup.reg,
				Lua_UnityEngine_UI_ILayoutElement.reg,
				Lua_UnityEngine_UI_ILayoutController.reg,
				Lua_UnityEngine_UI_ILayoutGroup.reg,
				Lua_UnityEngine_UI_ILayoutSelfController.reg,
				Lua_UnityEngine_UI_ILayoutIgnorer.reg,
				Lua_UnityEngine_UI_LayoutElement.reg,
				Lua_UnityEngine_UI_LayoutRebuilder.reg,
				Lua_UnityEngine_UI_LayoutUtility.reg,
				Lua_UnityEngine_UI_VerticalLayoutGroup.reg,
				Lua_UnityEngine_UI_Mask.reg,
				Lua_UnityEngine_UI_MaskUtilities.reg,
				Lua_UnityEngine_UI_IMaterialModifier.reg,
				Lua_UnityEngine_UI_Navigation.reg,
				Lua_UnityEngine_UI_RawImage.reg,
				Lua_UnityEngine_UI_RectMask2D.reg,
				Lua_UnityEngine_UI_ScrollRect.reg,
				Lua_UnityEngine_UI_Scrollbar.reg,
				Lua_UnityEngine_UI_Slider.reg,
				Lua_UnityEngine_UI_SpriteState.reg,
				Lua_UnityEngine_UI_StencilMaterial.reg,
				Lua_UnityEngine_UI_Text.reg,
				Lua_UnityEngine_UI_Toggle.reg,
				Lua_UnityEngine_UI_ToggleGroup.reg,
				Lua_UnityEngine_UI_VertexHelper.reg,
				Lua_UnityEngine_UI_BaseMeshEffect.reg,
				Lua_UnityEngine_UI_IMeshModifier.reg,
				Lua_UnityEngine_UI_Shadow.reg,
				Lua_UnityEngine_UI_Outline.reg,
				Lua_UnityEngine_UI_PositionAsUV1.reg,
				Lua_UnityEngine_EventSystems_AbstractEventData.reg,
				Lua_UnityEngine_EventSystems_BaseEventData.reg,
				Lua_UnityEngine_EventSystems_AxisEventData.reg,
				Lua_UnityEngine_EventSystems_PointerEventData.reg,
				Lua_UnityEngine_EventSystems_EventHandle.reg,
				Lua_UnityEngine_EventSystems_IEventSystemHandler.reg,
				Lua_UnityEngine_EventSystems_IPointerEnterHandler.reg,
				Lua_UnityEngine_EventSystems_IPointerExitHandler.reg,
				Lua_UnityEngine_EventSystems_IPointerDownHandler.reg,
				Lua_UnityEngine_EventSystems_IPointerUpHandler.reg,
				Lua_UnityEngine_EventSystems_IPointerClickHandler.reg,
				Lua_UnityEngine_EventSystems_IBeginDragHandler.reg,
				Lua_UnityEngine_EventSystems_IInitializePotentialDragHandler.reg,
				Lua_UnityEngine_EventSystems_IDragHandler.reg,
				Lua_UnityEngine_EventSystems_IEndDragHandler.reg,
				Lua_UnityEngine_EventSystems_IDropHandler.reg,
				Lua_UnityEngine_EventSystems_IScrollHandler.reg,
				Lua_UnityEngine_EventSystems_IUpdateSelectedHandler.reg,
				Lua_UnityEngine_EventSystems_ISelectHandler.reg,
				Lua_UnityEngine_EventSystems_IDeselectHandler.reg,
				Lua_UnityEngine_EventSystems_IMoveHandler.reg,
				Lua_UnityEngine_EventSystems_ISubmitHandler.reg,
				Lua_UnityEngine_EventSystems_ICancelHandler.reg,
				Lua_UnityEngine_EventSystems_EventSystem.reg,
				Lua_UnityEngine_EventSystems_EventTrigger.reg,
				Lua_UnityEngine_EventSystems_EventTriggerType.reg,
				Lua_UnityEngine_EventSystems_ExecuteEvents.reg,
				Lua_UnityEngine_EventSystems_BaseInput.reg,
				Lua_UnityEngine_EventSystems_BaseInputModule.reg,
				Lua_UnityEngine_EventSystems_PointerInputModule.reg,
				Lua_UnityEngine_EventSystems_StandaloneInputModule.reg,
				Lua_UnityEngine_EventSystems_MoveDirection.reg,
				Lua_UnityEngine_EventSystems_RaycastResult.reg,
				Lua_UnityEngine_EventSystems_RaycasterManager.reg,
				Lua_UnityEngine_EventSystems_PhysicsRaycaster.reg,
				Lua_UnityEngine_EventSystems_Physics2DRaycaster.reg,
				Lua_UnityEngine_UI_Button_ButtonClickedEvent.reg,
				Lua_UnityEngine_UI_DefaultControls_IFactoryControls.reg,
				Lua_UnityEngine_UI_DefaultControls_Resources.reg,
				Lua_UnityEngine_UI_Dropdown_OptionData.reg,
				Lua_UnityEngine_UI_Dropdown_OptionDataList.reg,
				Lua_UnityEngine_UI_Dropdown_DropdownEvent.reg,
				Lua_UnityEngine_UI_GraphicRaycaster_BlockingObjects.reg,
				Lua_UnityEngine_UI_Image_Type.reg,
				Lua_UnityEngine_UI_Image_FillMethod.reg,
				Lua_UnityEngine_UI_Image_OriginHorizontal.reg,
				Lua_UnityEngine_UI_Image_OriginVertical.reg,
				Lua_UnityEngine_UI_Image_Origin90.reg,
				Lua_UnityEngine_UI_Image_Origin180.reg,
				Lua_UnityEngine_UI_Image_Origin360.reg,
				Lua_UnityEngine_UI_InputField_ContentType.reg,
				Lua_UnityEngine_UI_InputField_InputType.reg,
				Lua_UnityEngine_UI_InputField_CharacterValidation.reg,
				Lua_UnityEngine_UI_InputField_LineType.reg,
				Lua_UnityEngine_UI_InputField_SubmitEvent.reg,
				Lua_UnityEngine_UI_InputField_OnChangeEvent.reg,
				Lua_UnityEngine_UI_AspectRatioFitter_AspectMode.reg,
				Lua_UnityEngine_UI_CanvasScaler_ScaleMode.reg,
				Lua_UnityEngine_UI_CanvasScaler_ScreenMatchMode.reg,
				Lua_UnityEngine_UI_CanvasScaler_Unit.reg,
				Lua_UnityEngine_UI_ContentSizeFitter_FitMode.reg,
				Lua_UnityEngine_UI_GridLayoutGroup_Corner.reg,
				Lua_UnityEngine_UI_GridLayoutGroup_Axis.reg,
				Lua_UnityEngine_UI_GridLayoutGroup_Constraint.reg,
				Lua_UnityEngine_UI_MaskableGraphic_CullStateChangedEvent.reg,
				Lua_UnityEngine_UI_Navigation_Mode.reg,
				Lua_UnityEngine_UI_ScrollRect_MovementType.reg,
				Lua_UnityEngine_UI_ScrollRect_ScrollbarVisibility.reg,
				Lua_UnityEngine_UI_ScrollRect_ScrollRectEvent.reg,
				Lua_UnityEngine_UI_Scrollbar_Direction.reg,
				Lua_UnityEngine_UI_Scrollbar_ScrollEvent.reg,
				Lua_UnityEngine_UI_Selectable_Transition.reg,
				Lua_UnityEngine_UI_Slider_Direction.reg,
				Lua_UnityEngine_UI_Slider_SliderEvent.reg,
				Lua_UnityEngine_UI_Toggle_ToggleTransition.reg,
				Lua_UnityEngine_UI_Toggle_ToggleEvent.reg,
				Lua_UnityEngine_EventSystems_PointerEventData_InputButton.reg,
				Lua_UnityEngine_EventSystems_PointerEventData_FramePressState.reg,
				Lua_UnityEngine_EventSystems_EventTrigger_TriggerEvent.reg,
				Lua_UnityEngine_EventSystems_EventTrigger_Entry.reg,
				Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.reg,
			};
			return list;
		}
	}
}
