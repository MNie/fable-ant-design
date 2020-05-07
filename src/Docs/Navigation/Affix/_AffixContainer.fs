module Navigation.Affix.AffixContainer
open Fable.React
open Fable.React.Props
open Fable.Core.JsInterop

open Fable.AntD

module Sub =
    let mutable containerRef : HTMLElement = null

let view () =
    div [ClassName "scrollable-container"; Ref (fun node  ->
                                                  if not (isNull node) then
                                                    Sub.containerRef <- node:?>HTMLElement )] [
      div [ClassName "background"] [
        Affix.affix [Affix.Target (fun ()-> Sub.containerRef) ] [
          Button.button [Button.Type Button.Primary] [str "Fixed at the top of container"]
        ]
      ]
    ]

