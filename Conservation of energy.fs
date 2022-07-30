module conservationOfEnergy
(* The relation used for these functions is: 0.5 * m * v^2 = m * g * h
Which is the equation for conversation of energy,
and only applies in situations where there is a conservative force like gravity,
and where the gravitational acceleration can be considered constant (Near the surface of Earth). *)

open FSharp.Data.UnitSystems.SI.UnitSymbols
open vectors

// All of these functions take a velocity vector and acceleration vector as arguments.

let getVelocityFromHeight (v1 : vector2D<'u>) (a : vector2D<'a>) =
  2.0 * a.y * v1.y |> sqrt

let getHeightFromVelocity (v1 : vector2D<'u>) (a : vector2D<'a>) =
  v1.y * v1.y / (2.0 * a.y)

let getTimeFromHeight (v1 : vector2D<'u>) (a : vector2D<'a>) =
  // The equation used here is actually: h = ½ * a * t^2
  2.0 * v1.y / a.y |> sqrt
