namespace VetorPhysicsApp

module GUI =
    open Avalonia.Controls
    open Avalonia.FuncUI
    open Avalonia.FuncUI.DSL
    open Avalonia.Layout

    let view =
        Component(fun ctx ->
            let state = ctx.useState ""
            DockPanel.create [
                DockPanel.verticalAlignment VerticalAlignment.Center
                DockPanel.horizontalAlignment HorizontalAlignment.Center
                DockPanel.children [
                    TextBlock.create [
                        TextBlock.dock Dock.Top
                        TextBlock.fontSize 48.0
                        TextBlock.horizontalAlignment HorizontalAlignment.Center
                        TextBlock.text "Enter a vector in the format: (x,y)"
                    ]
                    TextBlock.create [
                        TextBlock.dock Dock.Bottom
                        TextBlock.fontSize 28.0
                        TextBlock.horizontalAlignment HorizontalAlignment.Center
                        TextBlock.text (string state.Current)
                    ](*
                    Line.create [
                      Shapes.Line.startPoint (50.0, 25.0)
                      Shapes.Line.endPoint (100.0, 300.0)
                    ]
                    Canvas.create [
                      Canvas.left 25.0
                      Canvas.top 25.0
                      Canvas.right 25.0
                      Canvas.bottom 25.0
                    ]*)
                    TextBox.create [
                      TextBox.text ""
                      TextBox.fontSize 28.0
                      TextBox.horizontalAlignment HorizontalAlignment.Center
                      TextBox.onTextChanged (fun newString -> newString |> state.Set)
                    ]
                ]
            ]
        )
