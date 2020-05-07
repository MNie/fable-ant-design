module Layout.Grid.GridGutter
open Fable.React
open Fable.React.Props
open Fable.AntD

let view () =
    div [ ] [
      Grid.row [ Grid.Gutter 16 ] [
        Grid.col [ Grid.Span 6; ClassName "gutter-row" ] [ div [ClassName "gutter-box"][str "col-6" ]]
        Grid.col [ Grid.Span 6; ClassName "gutter-row" ] [ div [ClassName "gutter-box"][str "col-6" ]]
        Grid.col [ Grid.Span 6; ClassName "gutter-row" ] [ div [ClassName "gutter-box"][str "col-6" ]]
        Grid.col [ Grid.Span 6; ClassName "gutter-row" ] [ div [ClassName "gutter-box"][str "col-6" ]]
      ]
    ]
