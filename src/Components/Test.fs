[<AutoOpen>]
module Components.Test

open Feliz


type Components =

    [<ReactComponent>]
    static member Test() =

        let (count, setCount) = React.useState 0

        Html.div
            [ Html.h1 count
              Html.button [ prop.onClick (fun _ -> setCount (count + 1)); prop.text "Increment" ] ]
