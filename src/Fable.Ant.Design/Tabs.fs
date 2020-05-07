namespace Fable.AntD

open Fable.Import
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<RequireQualifiedAccess>]
module Tabs =

    [<StringEnum>]
    type TabsType =
        | Line
        | Card
        | [<CompiledName("editable-card")>] EditableCard

    [<StringEnum>]
    type TabsPosition = Top | Right | Bottom | Left

    [<StringEnum>]
    type TabsSize = Large | Default | Small


    type TabsAnimation = { inkBar: bool; tabPane: bool; }

    type TabsProps  =
        | ActiveKey of string
        | DefaultActiveKey of string
        | HideAdd of bool
        | OnChange of (string -> unit)
        | OnTabClick of (unit -> unit) //  of React.MouseEventHandler ?
        | OnPrevClick of Browser.Types.MouseEvent
        | OnNextClick of Browser.Types.MouseEvent
        | TabBarExtraContent of Browser.Types.Node
        | TabBarStyle of CSSProp
        | Type of TabsType
        | TabPosition of TabsPosition
        | OnEdit of ((U2<string,Browser.Types.MouseEvent> * obj) -> unit)
        | Size of TabsSize
        //| Style?: React.CSSProperties;
        | PrefixCls of string
        // className?: string;
        | Animated of  U2<bool,TabsAnimation>
        | TabBarGutter of int
        interface Fable.React.Props.IProp

    type TabPaneProps =
        | Tab of U2<Browser.Types.Node, string>
        //style?: React.CSSProperties;
        | Closable of bool
        //className?: string;
        //disabled?: boolean;
        | ForceRender of bool
        interface Fable.React.Props.IProp

    let inline tabs (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "Tabs" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline tabPane (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "Tabs.TabPane" "antd" (keyValueList CaseRules.LowerFirst props) children
