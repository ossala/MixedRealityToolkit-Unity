﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.MixedReality.Toolkit.Internal.Definitions.Utilities;
using Microsoft.MixedReality.Toolkit.Internal.Interfaces.InputSystem;
using UnityEngine.EventSystems;

namespace Microsoft.MixedReality.Toolkit.Internal.EventDatum.Input
{
    /// <summary>
    /// Describes an Input Event where a button, key, or trigger was pressed.
    /// </summary>
    public class InputPressedEventData : InputEventData
    {
        /// <summary>
        /// The amount, from 0.0 to 1.0, that the select was pressed.
        /// </summary>
        public float PressedAmount { get; private set; }

        /// <inheritdoc />
        public InputPressedEventData(EventSystem eventSystem) : base(eventSystem) { }

        /// <summary>
        /// Populates the event with data.
        /// </summary>
        /// <param name="inputSource"></param>
        /// <param name="inputAction"></param>
        /// <param name="pressedAmount"></param>
        public void Initialize(IMixedRealityInputSource inputSource, IMixedRealityInputAction inputAction, float pressedAmount)
        {
            Initialize(inputSource, inputAction);
            PressedAmount = pressedAmount;
        }

        /// <summary>
        /// Populates the event with data.
        /// </summary>
        /// <param name="inputSource"></param>
        /// <param name="handedness"></param>
        /// <param name="inputAction"></param>
        /// <param name="pressedAmount"></param>
        public void Initialize(IMixedRealityInputSource inputSource, Handedness handedness, IMixedRealityInputAction inputAction, float pressedAmount)
        {
            Initialize(inputSource, handedness, inputAction);
            PressedAmount = pressedAmount;
        }
    }
}