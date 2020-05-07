module DataEntry.AutoComplete.AutoCompleteBasic
open Fable.React
open Fable.React.Props

open Fable.AntD

let onSelect (value:AutoComplete.SelectValue) _ =
    console.log("onSelect",value)

let view datasource onSearch () =
    AutoComplete.autoComplete [
        AutoComplete.DataSource datasource
        Style [ Width  200 ]
        AutoComplete.OnSelect onSelect
        AutoComplete.OnSearch onSearch
        Placeholder "input here"
    ] []
