namespace Fable.AntD

open Fable.Import
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<RequireQualifiedAccess>]
module Button =

    [<StringEnum>]
    type ButtonType =
        | Primary
        | Dashed
        | Ghost
        | Danger

    [<StringEnum>]
    type ButtonSize =
        | Small
        | Default
        | Large

    [<StringEnum>]
    type ButtonShape =
        | Circle
        | [<CompiledName("circle-outline")>] CircleOutline

    type ButtonProps =
        | Ghost of bool
        | Href of string
        | Target of string
        | Type of ButtonType
        | HtmlType of string
        | Icon of string
        | Shape of ButtonShape
        | Size of ButtonSize
        | Loading of bool
        interface Fable.React.Props.IProp

    let inline button (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "Button" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline group (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "Button.Group" "antd" (keyValueList CaseRules.LowerFirst props) children
