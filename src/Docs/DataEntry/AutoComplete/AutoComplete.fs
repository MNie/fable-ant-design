namespace DataEntry.AutoComplete

open Fable.Core
open Fable.Core.JsInterop
open Elmish
open Fable.AntD

module Types =

    [<StringEnum>]
    type Demos = Basic | Customized | CustomizeInputComponent | NonCaseSensitive | LookupPatternsCertainCategory | LookupPatternsUncertainCategory


    type Model = {
        tabs:Map<Demos,DemoCard.Types.Tab>
        basicDataSource: AutoComplete.DataSourceItemType []
        customizedDataSource: AutoComplete.DataSourceItemType []
        customizeInputComponentDataSource: AutoComplete.DataSourceItemType []
        NonCaseSensitiveDataSource: AutoComplete.DataSourceItemType []
    }

    type Msg =
      | ChangeTabMsg of Demos * DemoCard.Types.Tab
      | SearchBasicMsg of string
      | SearchCustomizedMsg of string
      | SearchCustomizeInputComponentMsg of string

open Types

module State =

    let updateBasicDataSource (value:string) =
      match value with
      | null | "" -> [||]
      | _ -> [|1..3|] |> Array.map (fun i -> String.replicate i value |> U2.Case1 )

    let updateCustomizedDataSource value =
      match value with
      | null | "" -> [||]
      | s when (s.Contains "@") -> [||]
      | _ -> [|"gmail.com"; "yahoo.com"; "live.com"|] |> Array.map (fun domain -> value + "@"+ domain |> U2.Case1 )


    let init () : Model * Cmd<Msg> =

      let tabs = [ Basic; Customized; CustomizeInputComponent; NonCaseSensitive; LookupPatternsCertainCategory]
                    |> List.map (fun x->x,DemoCard.Types.Demo)
                    |>  Map.ofList
      { tabs = tabs; basicDataSource = [||]; customizedDataSource = [||]; customizeInputComponentDataSource = [||]; NonCaseSensitiveDataSource = [||] }, Cmd.Empty

    let update msg (model:Model) : Model * Cmd<Msg> =
       match msg with
       | ChangeTabMsg (demo,tab) ->{model with tabs = model.tabs.Add(demo, tab)}, []
       | SearchBasicMsg value ->{model with basicDataSource = (updateBasicDataSource value) }, []
       | SearchCustomizedMsg value ->{model with customizedDataSource = (updateCustomizedDataSource value) }, []
       | SearchCustomizeInputComponentMsg value ->{model with customizeInputComponentDataSource = (updateBasicDataSource value) }, []


module View =

    open Fable.React
    open DemoCard.Types


    let root (model:Model) (dispatch:Msg->unit) =

      let demos =
        [| Basic, {
            title = "Basic";
            demo = DataEntry.AutoComplete.AutoCompleteBasic.view model.basicDataSource (SearchBasicMsg >> dispatch);
            source = importAll "!!highlight-loader?raw=true&lang=fsharp!./_AutoCompleteBasic.fs";
            activeTab = DemoCard.Types.Demo
            }
           Customized, {
            title = "Customized" ;
            demo = DataEntry.AutoComplete.AutoCompleteCustomized.view model.customizedDataSource (SearchCustomizedMsg >> dispatch);
            source = importAll "!!highlight-loader?raw=true&lang=fsharp!./_AutoCompleteCustomized.fs";
            activeTab = DemoCard.Types.Demo
            }
           CustomizeInputComponent, {
            title = "Customize input component" ;
            demo = DataEntry.AutoComplete.AutoCompleteCustomizeInputComponent.view model.customizeInputComponentDataSource (SearchCustomizeInputComponentMsg >> dispatch);
            source = importAll "!!highlight-loader?raw=true&lang=fsharp!./_AutoCompleteCustomizeInputComponent.fs";
            activeTab = DemoCard.Types.Demo
            }
           NonCaseSensitive, {
            title = "Non-case-sensitive AutoComplete" ;
            demo = DataEntry.AutoComplete.AutoCompleteNonCaseSensitive.view;
            source = importAll "!!highlight-loader?raw=true&lang=fsharp!./_AutoCompleteNonCaseSensitive.fs";
            activeTab = DemoCard.Types.Demo
            }
           LookupPatternsCertainCategory, {
            title = "Lookup-Patterns - Certain Category" ;
            demo = DataEntry.AutoComplete.AutoCompleteLookupPatternsCertainCategory.view;
            source = importAll "!!highlight-loader?raw=true&lang=fsharp!./_AutoCompleteLookupPatternsCertainCategory.fs";
            activeTab = DemoCard.Types.Demo
            }

        |] |> Map.ofArray

      let renderDemo demo =
        DemoCard.View.root {demos.[demo] with activeTab = model.tabs.[demo] }  (fun msg -> ChangeTabMsg (demo, msg) |> dispatch  )

      div [ ] [
        yield h1 [] [str "AutoComplete"]
        yield! ([ Basic; Customized; CustomizeInputComponent; NonCaseSensitive; LookupPatternsCertainCategory ] |> List.map renderDemo)
        ]
