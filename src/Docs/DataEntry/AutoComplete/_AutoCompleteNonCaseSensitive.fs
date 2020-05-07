module DataEntry.AutoComplete.AutoCompleteNonCaseSensitive
open Fable.Core
open Fable.Import.React
open Fable.React.Props

open Fable.AntD

let datasource = [|"Burns Bay Road"; "Downing Street"; "Wall Street"|] |> Array.map U2.Case1

//filterOption={(inputValue, option) => option.props.children.toUpperCase().indexOf(inputValue.toUpperCase()) !== -1}

let view () =
    AutoComplete.autoComplete [
        AutoComplete.DataSource datasource
        Style [ Width  200 ]
        Placeholder "try to type `b`"
        AutoComplete.FilterOption  (U2.Case2(fun inputValue option -> sprintf "%A" option.children |> (fun s -> s.ToUpperInvariant() ) |> fun s -> s.Contains(inputValue.ToUpperInvariant()) )) //option :?> Component))
    ] []
