namespace Fable.AntD

open Fable.Import
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Props

[<RequireQualifiedAccess>]
module List =

    [<StringEnum>]
    type ColumnCount =
        | [<CompiledName("1")>] One
        | [<CompiledName("2")>] Two
        | [<CompiledName("3")>] Three
        | [<CompiledName("4")>] Four
        | [<CompiledName("6")>] Six
        | [<CompiledName("8")>] Eight
        | [<CompiledName("12")>] Twelve
        | [<CompiledName("24")>] TwentyFour


    [<StringEnum>]
    type ColumnType =
        | Gutter
        | Column
        | Xs
        | Sm
        | Md
        | Lg
        | Xl
        | Xxl

    type ListGridType = {
      gutter: int option
      column: ColumnCount option
      xs: ColumnCount option
      sm: ColumnCount option
      md: ColumnCount option
      lg: ColumnCount option
      xl: ColumnCount option
      xxl: ColumnCount option
    }

    [<StringEnum>]
    type ListSize = Small | Default | Large


    type ListProps =
        | Bordered of bool
        | DataSource of obj[]
        | Extra of ReactElement
        | Grid of ListGridType
        | ItemLayout of string
        | Loading of bool //U2<bool,SpinProps>; TODO
        | LoadMore of ReactElement
        | Pagination of obj
        | PrefixCls of string
        | RowKey of obj
        | RenderItem of  (obj * int -> ReactElement)
        | Size of ListSize
        | Split of bool
        | Header of ReactElement
        | Footer of ReactElement
        | Locale of obj
        interface Fable.React.Props.IProp


    let inline list (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "List" "antd" (keyValueList CaseRules.LowerFirst props) children


    type ListItemProps =
        | PrefixCls of string
        | Extra of ReactElement
        | Actions of ReactElement[]
        | Grid of ListGridType
        interface Fable.React.Props.IProp

    type ListItemMetaProps =
        | Avatar of ReactElement
        | Description of ReactElement
        | PrefixCls of string
        | Title of ReactElement
        interface Fable.React.Props.IProp



    let inline item (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "List.Item" "antd" (keyValueList CaseRules.LowerFirst props) children
