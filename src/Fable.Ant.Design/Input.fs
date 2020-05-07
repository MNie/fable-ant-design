namespace Fable.AntD

open Fable.Import
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<RequireQualifiedAccess>]
module Input =

    type AbstractInputProps =
        | PrefixCls of string
        //className?: string
        | DefaultValue of obj
        | Value of obj
        | TabIndex of int
        //style?: React.CSSProperties;
        interface Fable.React.Props.IProp

    type InputProps  =
        | Placeholder of string
        | Type of string
        | Id of U2<int, string>
        | Name of string
        | Size of Common.Size
        | MaxLength of int //?: number | string
        | Disabled of bool
        | ReadOnly of bool
        | AddonBefore of Browser.Types.Node
        | AddonAfter of Browser.Types.Node
        | OnPressEnter of Browser.Types.Event
        | OnKeyDown of Browser.Types.KeyboardEvent
        | OnKeyUp of Browser.Types.KeyboardEvent
        | OnChange of Browser.Types.Event  //React.ChangeEventHandler
        | OnClick of Browser.Types.MouseEvent
        | OnFocus of Browser.Types.FocusEvent
        | OnBlur of Browser.Types.FocusEvent
        | AutoComplete of string
        | Prefix of Browser.Types.Node
        | Suffix of Browser.Types.Node
        | SpellCheck of bool
        | AutoFocus of bool
        interface Fable.React.Props.IProp

    let inline input (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "Input" "antd" (keyValueList CaseRules.LowerFirst props) children

    type GroupProps =
        //className?: string;
        | Size of Common.Size
        //children?: any;
        //style?: React.CSSProperties;
        | PrefixCls of string
        | Compact of bool
        interface Fable.React.Props.IProp

    let inline group (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "Input.Group" "antd" (keyValueList CaseRules.LowerFirst props) children

    type SearchProps =
        | InputPrefixCls of string
        | OnSearch of (string -> unit)
        | EnterButton of U2<bool, Browser.Types.Node>
        interface Fable.React.Props.IProp

    let inline search (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "Input.Search" "antd" (keyValueList CaseRules.LowerFirst props) children

    type AutoSizeType = {minRows: int option; maxRows: int option}

    type TextAreaProps =
        | Autosize of U2<bool, AutoSizeType>
        | OnPressEnter of Browser.Types.KeyboardEvent
        interface Fable.React.Props.IProp

    //type HTMLTextareaProps = React.TextareaHTMLAttributes<HTMLTextAreaElement>;

    let inline textarea (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "Input.TextArea" "antd" (keyValueList CaseRules.LowerFirst props) children
