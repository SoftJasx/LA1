namespace wit.comp3350


// TODO: Complete the attribution lines:
// ATTR:

module la1 = 
    /// TODO: Document this
    let xy_sqpl x y = x * x + y * y
        0

    /// TODO: Document this
    let isPositive x = x > 0
        false

    /// TODO: Document this
    let isNonZero x = x <> 0
        false

    /// TODO: Document this
    let bothNonZero x y = x <> 0 && y <> 0
        false

    /// TODO: Document this
    let feelsLike f =
        match f with
        | f when f < 20 -> "Cold"
        | f when f < 50 -> "Mild"
        | f when f < 80 -> "Warm"
        | _ -> "Hot"

    /// TODO: Document this
    let numTotal r s =
    if r < 0 || s < 0 then
        0
    else
        (r * 8) + (s * 3)