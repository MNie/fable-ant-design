module General.Button.ButtonIcons
open Fable.React
open Fable.AntD

let view () =
    div [] [
      Button.button [Button.Type Button.Primary; Button.Shape Button.Circle; Button.ButtonProps.Icon "search" ] []
      Button.button [Button.Type Button.Primary; Button.ButtonProps.Icon "search" ] [str "Search"]
      Button.button [Button.Shape Button.Circle; Button.ButtonProps.Icon "search" ] [ ]
      Button.button [Button.ButtonProps.Icon "search" ] [str "Search"]
      br []
      Button.button [Button.ButtonProps.Shape Button.Circle; Button.ButtonProps.Icon "search" ] []
      Button.button [Button.ButtonProps.Icon "search" ] [ str "Search"]
      Button.button [Button.Type Button.Dashed; Button.ButtonProps.Icon "search";Button.ButtonProps.Shape Button.Circle; ] [ ]
      Button.button [Button.Type Button.Dashed; Button.ButtonProps.Icon "search"; ] [ str "Search"]
    ]
