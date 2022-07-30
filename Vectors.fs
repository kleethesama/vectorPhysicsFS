module vectors

open System

type vector2D<[<Measure>]'u> = {x : float<'u>; y : float<'u>}
type vector3D<[<Measure>]'u> = {x : float<'u>; y : float<'u>; z : float<'u>}
[<Measure>] type degrees

let degreesToRad (θ : float<degrees>) =
  Math.PI * θ / 180.0 / 1.0<degrees>

let newVector2D (x1 : float<'u>) (y1 : float<'u>) =
  let object : vector2D<'u> = {x = x1; y = y1}
  object

let addVectors2D (v1 : vector2D<'u>) (v2 : vector2D<'u>) =
  (v1.x + v2.x, v1.y + v2.y) ||> newVector2D

let subtractVectors2D (v1 : vector2D<'u>) (v2 : vector2D<'u>) =
  (v1.x - v2.x, v1.y - v2.y) ||> newVector2D

let magnitudeOfVector2D (v1 : vector2D<'u>) =
  v1.x * v1.x + v1.y * v1.y |> sqrt

let rotateVector2D (v1 : vector2D<'u>) (θ : float) =
  let D = v1 |> magnitudeOfVector2D
  (D * Math.Cos(θ), D * Math.Sin(θ)) ||> newVector2D

let ortogonalVector2D (v1 : vector2D<'u>) =
  (-v1.y, v1.x) ||> newVector2D

let newVector3D (x1 : float<'u>) (y1 : float<'u>) (z1 : float<'u>) =
  let object : vector3D<'u> = {x = x1; y = y1; z = z1}
  object

let addVectors3D (v1 : vector3D<'u>) (v2 : vector3D<'u>) =
  (v1.x + v2.x, v1.y + v2.y, v1.z + v2.z) |||> newVector3D

let subtractVectors3D (v1 : vector3D<'u>) (v2 : vector3D<'u>) =
  (v1.x - v2.x, v1.y - v2.y, v1.z - v2.z) |||> newVector3D

let magnitudeOfVector3D (v1 : vector3D<'u>) =
  v1.x * v1.x + v1.y * v1.y + v1.z * v1.z |> sqrt
