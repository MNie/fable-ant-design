namespace Fable.AntD

open Fable.Import
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Props

[<RequireQualifiedAccess>]
module Grid =

    [<StringEnum>]
    type RowAlignement = Top | Middle | Bottom

    [<StringEnum>]
    type RowJustify =  Start | End | Center | [<CompiledName("space-around")>] SpaceAround | [<CompiledName("space-between")>] SpaceBetween

    [<StringEnum>]
    type RowType = Flex

    type RowProps =
        | Align of RowAlignement /// the vertical alignment of the flex layout
        | Gutter of int /// spacing between grids, could be a number or a object like { xs: 8, sm: 16, md: 24} number/object
        | Justify of RowJustify /// horizontal arrangement of the flex layout: start end center space-around space-between
        | Type of RowType /// layout mode, optional flex, browser support
        | PrefixCls of string
        interface Fable.React.Props.IProp

    type ColSize = {
      span: int option;
      order: int option;
      offset: int option;
      push: int option;
      pull: int option;
    }

    module ColSize =

        let empty = { span= Some 1; order= None;offset= None; push=None;pull=None }

        let ofTuple (span,order,offset,push,pull) =
                        let ofInt (x:int) = if x < 0 then None else Some x
                        { span= ofInt span;
                          order= ofInt order;
                          offset= ofInt offset;
                          push= ofInt push;
                          pull= ofInt pull
                        }

    type ColProps =
      | Span of int
      | Order of int
      | Offset of int
      | Push of int
      | Pull of int
      | Xs of U2<int,ColSize>
      | Sm of U2<int,ColSize>
      | Md of U2<int,ColSize>
      | Lg of U2<int,ColSize>
      | Xl of U2<int,ColSize>
      | Xxl of U2<int,ColSize>
      | PrefixCls of string
      interface Fable.React.Props.IProp

    let inline row (props: IProp list) (children: ReactElement list): ReactElement =
        ofImport "Row" "antd" (keyValueList CaseRules.LowerFirst props) children

    let inline col (props: IProp list) (children: ReactElement list): ReactElement =
        ofImport "Col" "antd" (keyValueList CaseRules.LowerFirst props) children
