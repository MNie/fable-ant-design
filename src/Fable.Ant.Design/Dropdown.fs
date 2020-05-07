namespace Fable.AntD

open Fable.Import
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<RequireQualifiedAccess>]
module Dropdown =

    [<StringEnum>]
    type DropDownTrigger = Click | Hover | ContextMenu

    [<StringEnum>]
    type DropDownPlacement = TopLeft | TopCenter | TopRight | BottomLeft | BottomCenter | BottomRight

    type DropDownProps  =
        | Trigger of DropDownTrigger[]
        | Overlay of ReactElement
        | OnVisibleChange of (bool -> unit)
        | Visible of bool
        | Disabled of bool
        | Align of obj
        | GetPopupContainer of (ReactElement -> Browser.Types.HTMLElement)
        | PrefixCls of string
        | ClassName of string
        | TransitionName of string
        | Placement of DropDownPlacement
        | ForceRender of bool
        interface Props.IProp

    let inline dropdown  (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "Dropdown" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline button  (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "Dropdown.Button" "antd" (keyValueList CaseRules.LowerFirst props) children
