namespace Fable.AntD

open Fable.Import
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props


[<RequireQualifiedAccess>]
module Calendar =

    [<StringEnum>]
    type CalendarMode =
        | Month
        | Year

    type CalendarProps =
        | PrefixCls of string
        //className?: string;
        | Value of obj // moment.Moment
        | DefaultValue of obj // moment.Moment;
        | Mode of CalendarMode
        | Fullscreen of bool
        | DateCellRender of (obj -> ReactElement) // => React.ReactNode;
        | MonthCellRender of (obj -> ReactElement) // => React.ReactNode;
        | DateFullCellRender of (obj -> ReactElement) // => React.ReactNode;
        | MonthFullCellRender of (obj -> ReactElement) //=> React.ReactNode;
        | Locale of obj
        //style?: React.CSSProperties;
        | OnPanelChange of (obj * CalendarMode -> unit)
        | OnSelect of (obj -> unit)
        | DisabledDate of (obj -> bool)
        | ValidRange of obj * obj //[moment.Moment, moment.Moment];
        interface Fable.React.Props.IProp

    let inline calendar  (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "Calendar " "antd" (keyValueList CaseRules.LowerFirst props) children
