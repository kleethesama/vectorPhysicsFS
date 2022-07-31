module vectors

open System

type vector2D<[<Measure>]'u> = {x : float<'u>; y : float<'u>}
type vector3D<[<Measure>]'u> = {x : float<'u>; y : float<'u>; z : float<'u>}

let degreesToRad (θ : float) =
  Math.PI * θ / 180.0

let newVector2D (x1 : float<'u>) (y1 : float<'u>) =
  let object : vector2D<'u> = {x = x1; y = y1}
  object

let addVectors2D (data : vector2D<'u> list) =
  let rec loop (data : vector2D<'u> list) acc1 acc2 =
    match data with
    | [] -> (acc1, acc2)
    | vec::vecs -> loop vecs (acc1 + vec.x) (acc2 + vec.y)
  loop data 0.0<_> 0.0<_> ||> newVector2D

let subtractVectors2D (data : vector2D<'u> list) =
  let rec loop (data : vector2D<'u> list) acc1 acc2 =
    match data with
    | [] -> (acc1, acc2)
    | vec::vecs -> loop vecs (acc1 - vec.x) (acc2 - vec.y)
  loop data 0.0<_> 0.0<_> ||> newVector2D

let magnitudeOfVector2D (vec1 : vector2D<'u>) =
  vec1.x * vec1.x + vec1.y * vec1.y |> sqrt

let rotateVector2D (vec1 : vector2D<'u>) (θ : float) =
  let D = vec1 |> magnitudeOfVector2D
  (D * Math.Cos(θ), D * Math.Sin(θ)) ||> newVector2D

let ortogonalVector2D (vec1 : vector2D<'u>) =
  (-vec1.y, vec1.x) ||> newVector2D

let newVector3D (x1 : float<'u>) (y1 : float<'u>) (z1 : float<'u>) =
  let object : vector3D<'u> = {x = x1; y = y1; z = z1}
  object

let addVectors3D (data : vector3D<'u> list) =
  let rec loop (data : vector3D<'u> list) acc1 acc2 acc3 =
    match data with
    | [] -> (acc1, acc2, acc3)
    | vec::vecs -> loop vecs (acc1 + vec.x) (acc2 + vec.y) (acc3 + vec.z)
  loop data 0.0<_> 0.0<_> 0.0<_> |||> newVector3D

let subtractVectors3D (data : vector3D<'u> list) =
  let rec loop (data : vector3D<'u> list) acc1 acc2 acc3 =
    match data with
    | [] -> (acc1, acc2, acc3)
    | vec::vecs -> loop vecs (acc1 - vec.x) (acc2 - vec.y) (acc3 - vec.z)
  loop data 0.0<_> 0.0<_> 0.0<_> |||> newVector3D

let magnitudeOfVector3D (vec1 : vector3D<'u>) =
  vec1.x * vec1.x + vec1.y * vec1.y + vec1.z * vec1.z |> sqrt
