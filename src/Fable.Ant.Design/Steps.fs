namespace Fable.AntD

open Fable.Import
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<RequireQualifiedAccess>]
module Steps =

    [<StringEnum>]
    type StepsStatus = Wait | Process | Finish | Error

    [<StringEnum>]
    type StepsSize = Default | Small

    [<StringEnum>]
    type StepsDirection = Horizontal | Vertical

    type StepProgressDotInfo = { index:int; status:string; title:string; description:string  }

    type StepsProps =
        | PrefixCls of string
        | IconPrefix of string
        | Current of int
        | Status of StepsStatus
        | Size of  StepsSize
        | Direction of StepsDirection
        | ProgressDot of U2<bool, (ReactElement -> StepProgressDotInfo -> ReactElement)> /// iconDot, { index, status, title, description }
        //style?: React.CSSProperties;
        interface Fable.React.Props.IProp


    type StepProps =
        //className: PropTypes.string,
        | PrefixCls of string
        //style: PropTypes.object,
        | WrapperStyle of obj
        | ItemWidth of U2<int,string>
        | Status of string
        | IconPrefix of string
        | Icon of ReactElement
        | AdjustMarginRight of U2<int, string>
        | StepNumber of string
        | Description of ReactElement // obj
        | Title of ReactElement // obj
        | ProgressDot of U2<bool, unit->unit>
        | TailContent of obj
        interface Fable.React.Props.IProp

    let inline steps (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "Steps" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline step (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "Steps.Step" "antd" (keyValueList CaseRules.LowerFirst props) children
