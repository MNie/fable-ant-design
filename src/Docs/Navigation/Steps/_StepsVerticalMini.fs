module Navigation.Steps.StepsVerticalMini
open Fable.React
open Fable.AntD

let view () =
  Steps.steps [Steps.Direction Steps.Vertical; Steps.Size Steps.Small; Steps.Current 1] [
    Steps.step [Steps.Title (str "Finished"); Steps.Description (str "This is a description.")] []
    Steps.step [Steps.Title (str "In Progress"); Steps.Description (str "This is a description.")] []
    Steps.step [Steps.Title (str "Waiting"); Steps.Description (str "This is a description.")] []
  ]
