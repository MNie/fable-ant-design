namespace Fable.AntD

open Fable.Import
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<RequireQualifiedAccess>]
module Alert =

    type AlertType = Success | Info | Warning | Error

    type AffixProps =
        | Type of AlertType
        | Closable of bool
        | CloseText of Browser.Types.Node
        | Message of Browser.Types.Node
        | Description of Browser.Types.Node
        | OnClose of Browser.Types.MouseEvent
        | AfterClose of (unit -> unit)
        | ShowIcon of bool
        | IconType of string
        //| style?: React.CSSProperties;
        | PrefixCls of string
        //className?: string;
        | Banner of bool
        interface Fable.React.Props.IProp

    let inline alert (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "Alert" "antd" (keyValueList CaseRules.LowerFirst props) children
