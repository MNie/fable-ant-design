namespace Fable.AntD

open Fable.Import
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<RequireQualifiedAccess>]
module Icon =

    type IconProps =
        | Spin of bool
        | Type of string
        | Title of string
        interface Fable.React.Props.IProp

    let inline icon (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "Icon" "antd" (keyValueList CaseRules.LowerFirst props) children
