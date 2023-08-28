module Main

open Feliz
open Components
open Browser.Dom

let root = ReactDOM.createRoot (document.getElementById "feliz-app")

root.render (Components.Test())
