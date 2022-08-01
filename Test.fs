module test

open System
open vectors

(* Constructs a float list from numbers a to b,
works with or without a unit of measurement. I wrote this because apparently
this syntax doesn't support units of measurement: [1<m/s> .. 100<m/s>] *)
let newList a b =
  let rec loop a b l =
    match b with
    | 0.0<_> -> l
    | _ -> loop (a + 1.0<_>) (b - 1.0<_>) (l @ [a])
  loop a b []

(* Constructs a vector2D list made up of random float values.
Takes the upper limit of the float values (boundary)
and number of items in the list (n) as arguments. *)
let randomVectorList2D boundary n =
  let rand = Random()
  let rec loop n l =
    match n with
    | 0 -> l
    | _ -> loop (n - 1) (l @ [(rand.NextDouble() * boundary, rand.NextDouble() * boundary) ||> newVector2D])
  loop n []

let randomVectorList3D boundary n =
  let rand = Random()
  let rec loop n l =
    match n with
    | 0 -> l
    | _ -> loop (n - 1) (l @ [(rand.NextDouble() * boundary, rand.NextDouble() * boundary, rand.NextDouble() * boundary) |||> newVector3D])
  loop n []
