// Copyright (c) 2015 - 2023 Doozy Entertainment. All Rights Reserved.
// This code can only be used under the standard Unity Asset Store End User License Agreement
// A Copy of the EULA APPENDIX 1 is available at http://unity3d.com/company/legal/as_terms

//.........................
//.....Generated Class.....
//.........................
//.......Do not edit.......
//.........................

using System.Collections.Generic;
// ReSharper disable All
namespace Doozy.Runtime.UIManager.Components
{
    public partial class UIButton
    {
        public static IEnumerable<UIButton> GetButtons(UIButtonId.Action id) => GetButtons(nameof(UIButtonId.Action), id.ToString());
        public static bool SelectButton(UIButtonId.Action id) => SelectButton(nameof(UIButtonId.Action), id.ToString());
    }
}

namespace Doozy.Runtime.UIManager
{
    public partial class UIButtonId
    {
        public enum Action
        {
            AddToCart,
            AddToFavorites,
            Calendar,
            Camera,
            Close,
            Gamepad,
            Gift,
            Language,
            Map,
            Minus,
            Plus,
            Redo,
            Refresh,
            Reply,
            ReportBug,
            Search,
            SendEmail,
            Share,
            Star,
            Start,
            Tag,
            Undo
        }    
    }
}
