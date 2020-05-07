namespace Fable.AntD

open Fable.Import
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<RequireQualifiedAccess>]
module Switch =

    [<StringEnum>]
    type SwitchSize = Small | Default

    type SwitchProps =
        | PrefixCls of string
        | Size of SwitchSize
        | ClassName of string
        | Checked of bool
        | DefaultChecked of bool
        | OnChange of (bool -> unit)
        | CheckedChildren of  ReactElement // React.ReactNode
        | UnCheckedChildren of ReactElement  // React.ReactNode
        | Disabled of bool
        | Loading of bool
        interface Fable.React.Props.IProp

    let inline switch (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "Switch" "antd" (keyValueList CaseRules.LowerFirst props) children
