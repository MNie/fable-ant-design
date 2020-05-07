namespace Fable.AntD

open Fable.Import
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<RequireQualifiedAccess>]
module Breadcrumb =

    type Route = { path: string; breadcrumbName: string;}

    type BreadcrumbProps =
        | ItemRender of (Route * obj * Route[] * string[] -> Browser.Types.Node)
        | Params of obj
        | Routes of obj[]
        | Separator of U2<string, Browser.Types.Node>
        interface Fable.React.Props.IProp

    type BreadcrumbItemProps =
        | Href of string
        interface Fable.React.Props.IProp

    let inline breadcrumb  (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "Breadcrumb" "antd" (keyValueList CaseRules.LowerFirst props) children



    let inline item (props: IProp list) (children: ReactElement list): ReactElement =
       ofImport "Breadcrumb.Item" "antd" (keyValueList CaseRules.LowerFirst props) children
