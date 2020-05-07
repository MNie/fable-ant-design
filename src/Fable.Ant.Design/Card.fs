namespace Fable.AntD

open Fable.Import
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

type CardTabListType = {  key: string;  tab: ReactElement;}

[<RequireQualifiedAccess>]
module Card =

    [<StringEnum>]
    type CardType =
        | Inner
        | [<CompiledName("")>] Default



    type CardProps =
        | Actions of ReactElement list /// The action list, shows at the bottom of the Card.
        | BodyStyle of CSSProp ///Inline style to apply to the card content
        | Bordered of bool ///  Toggles rendering of the border around the card
        | Cover of ReactElement /// Card cover
        | Extra  of ReactElement /// Content to render in the top-right corner of the card
        | Hoverable of bool /// Lift up when hovering card
        | Loading of bool /// Shows a loading indicator while the contents of the card are being fetched
        | TabList of CardTabListType[] //  CardTabListType list /// List of TabPane's head.
        | ActiveTabKey of string    /// Current TabPane's key
        | DefaultActiveTabKey of string /// Initial active TabPane's key, if activeTabKey is not set.
        | Title of ReactElement /// Card title
        | Type of CardType /// Card style type, can be set to inner or not set
        | OnTabChange of (string -> unit) // Callback when tab is switched    (key) => void
        interface Fable.React.Props.IProp


    let inline card (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "Card" "antd" (keyValueList CaseRules.LowerFirst props) children
