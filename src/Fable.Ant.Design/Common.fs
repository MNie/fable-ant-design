[<RequireQualifiedAccess>]
module Fable.AntD.Common

open Fable.Core

[<StringEnum>]
type Size = Large | Default | Small


[<Emit("$2[$0] = $1")>]
let setProp (propName: string) (propValue: obj) (any: obj) : unit = jsNative

[<Emit("$0[$1]")>]
let getAs<'a> (x: obj) (key: string) : 'a = jsNative
