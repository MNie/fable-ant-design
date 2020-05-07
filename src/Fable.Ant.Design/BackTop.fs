namespace Fable.AntD

open Fable.Import
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<RequireQualifiedAccess>]
module BackTop =

    type BackTopTarget =  HTMLElement | Window

    type BackTopProps =
        | VisibilityHeight of int
        | OnClick of Browser.Types.MouseEvent
        | Target of (unit -> BackTopTarget)
        | PrefixCls of string
        // className?: string;
        // style?: React.CSSProperties;
        interface Fable.React.Props.IProp

    let inline backTop (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "BackTop" "antd" (keyValueList CaseRules.LowerFirst props) children
