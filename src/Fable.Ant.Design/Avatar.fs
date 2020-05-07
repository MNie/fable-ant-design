namespace Fable.AntD

open Fable.Import
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<RequireQualifiedAccess>]
module Avatar =

    [<StringEnum>]
    type AvatarShape = Circle | Square

    [<StringEnum>]
    type AvatarSize = Large | Small | Default

    type AvatarProps =
        | Shape of AvatarShape
        | Size of AvatarSize
        | Src of string
        | Icon of string
        // style?: React.CSSProperties;
        | PrefixCls of string
        //className?: string;
        //children?: any;
        interface Fable.React.Props.IProp

    let inline avatar (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "Avatar" "antd" (keyValueList CaseRules.LowerFirst props) children
