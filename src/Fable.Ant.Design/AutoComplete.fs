namespace Fable.AntD

open Fable.Import
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<RequireQualifiedAccess>]
module AutoComplete =

    // Should Be in SELECT !
    type LabeledValue = { key: string; label: Browser.Types.Node}
    type SelectValue = U6<string, string[], float, float[], LabeledValue, LabeledValue[]>

    type DataSourceItemObject = { value: string; text: string; }
    type DataSourceItemType = U2<string,DataSourceItemObject>

    [<StringEnum>]
    type AutoCompleteSize = Default | Large | Small

    type AutoCompleteInputProps =
        | OnChange of Browser.Types.Event
        | Value of obj
        interface Fable.React.Props.IProp


    type ValidInputElement = U3<Browser.Types.HTMLInputElement, Browser.Types.HTMLTextAreaElement, ReactElement>

    type OptionProps = {
        disabled: bool option;
        value: U2<string,float> option;
        title: string option;
        children: Browser.Types.Node option;
    }

    type AutoCompleteProps =
        | Value of SelectValue
        | DefaultValue of SelectValue
        | DataSource of DataSourceItemType[]
        | OptionLabelProp of string
        | OnChange of (SelectValue -> unit)
        | OnSelect of (SelectValue -> obj -> unit) //=> any;
        //| Children?: ValidInputElement |
        // ReactElement<OptionProps> |
        // Array<ReactElement<OptionProps>>;
        // FROM AbstractSelectProps !!
        | PrefixCls of string
        | Size of AutoCompleteSize
        | NotFoundContent of Browser.Types.Node
        | TransitionName of string
        | ChoiceTransitionName of string
        | ShowSearch of bool
        | AllowClear of bool
        | Disabled of bool
        | DefaultActiveFirstOption of bool
        | DropdownClassName of string
        | DropdownStyle of CSSProp
        | DropdownMenuStyle of CSSProp
        | OnSearch of (string -> unit)
        | FilterOption of U2<bool, (string -> Component<OptionProps,obj> -> bool)>
        interface Fable.React.Props.IProp

    let inline autoComplete (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "AutoComplete" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline option  (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "AutoComplete.Option " "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline optGroup  (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "AutoComplete.OptGroup " "antd" (keyValueList CaseRules.LowerFirst props) children
