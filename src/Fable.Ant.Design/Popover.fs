namespace Fable.AntD

open Fable.Import
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<RequireQualifiedAccess>]
module Popover =

    type PopoverProps  =
        | Title of ReactElement
        | Content of ReactElement
        interface Fable.React.Props.IProp

    let inline popover (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "Popover" "antd" (keyValueList CaseRules.LowerFirst props) children
