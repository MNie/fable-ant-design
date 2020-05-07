module Layout.Grid.BasicGrid
open Fable.React
open Fable.AntD

let view () =
    div [ ]
      [ Grid.row [ ] [
          Grid.col [ Grid.Span 12 ] [ str "col-12" ]
          Grid.col [ Grid.Span 12 ] [str "col-12" ]
        ]
        Grid.row [ ] [
          Grid.col [ Grid.Span 8 ] [ str "col-8" ]
          Grid.col [ Grid.Span 8 ] [ str "col-8" ]
          Grid.col [ Grid.Span 8 ] [ str "col-8" ]
        ]
        Grid.row [ ] [
          Grid.col [ Grid.Span 6 ] [ str "col-6" ]
          Grid.col [ Grid.Span 6 ] [ str "col-6" ]
          Grid.col [ Grid.Span 6 ] [ str "col-6" ]
          Grid.col [ Grid.Span 6 ] [ str "col-6" ]
        ]
      ]
