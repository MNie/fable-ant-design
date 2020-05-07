module General.Button.ButtonGhost
open Fable.React
open Fable.React.Props
open Fable.AntD

let view () =
  div [Style [Background "rgb(190, 200, 200)"; Padding "26px 16px 16px" ]]
      [
        Button.button [Button.Type Button.Primary; Button.ButtonProps.Ghost true]  [str "Primary"]
        Button.button [Button.ButtonProps.Ghost true]  [str "Default"]
        Button.button [Button.Type Button.Dashed; Button.ButtonProps.Ghost true]  [str "Dashed"]
        Button.button [Button.Type Button.Danger; Button.ButtonProps.Ghost true]  [str "Danger"]
      ]
