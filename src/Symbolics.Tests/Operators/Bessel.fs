﻿namespace MathNet.Symbolics.Tests.Operators.Bessel

open NUnit.Framework
open MathNet.Symbolics

open Operators
open VariableSets.Alphabet

module AiryAi =

    [<Test>]
    let ``Calculus`` () =
        Calculus.differentiate x (airyai (sqrt x)) ==> "airyaiprime(sqrt(x))/(2*sqrt(x))"

    [<Test>]
    let ``Latex Format`` () =
        LaTeX.format (airyai x) --> "Ai{x}"


module AiryAiPrime =

    [<Test>]
    let ``Calculus`` () =
        Calculus.differentiate x (airyaiprime (sqrt x)) ==> "airyai(sqrt(x))/2"

    [<Test>]
    let ``Latex Format`` () =
        LaTeX.format (airyaiprime x) --> "Ai^\\prime{x}"


module AiryBi =

    [<Test>]
    let ``Calculus`` () =
        Calculus.differentiate x (airybi (sqrt x)) ==> "airybiprime(sqrt(x))/(2*sqrt(x))"

    [<Test>]
    let ``Latex Format`` () =
        LaTeX.format (airybi x) --> "Bi{x}"


module AiryBiPrime =

    [<Test>]
    let ``Calculus`` () =
        Calculus.differentiate x (airybiprime (sqrt x)) ==> "airybi(sqrt(x))/2"

    [<Test>]
    let ``Latex Format`` () =
        LaTeX.format (airybiprime x) --> "Bi^\\prime{x}"


module BesselJ =

    [<Test>]
    let ``Special Value`` () =
        besselj 0Q 0Q ==> "1"
        besselj 1Q 0Q ==> "0"
        besselj -1Q 0Q ==> "0"
        besselj n PositiveInfinity ==> "0"
        besselj n NegativeInfinity ==> "0"

    [<Test>]
    let ``Connection Formulas`` () =
        besselj -n x ==> "(-1)^(n)*besselj(n,x)"

    [<Test>]
    let ``Calculus`` () =
        Calculus.differentiate x (besselj n (sqrt x)) ==> "(besselj(-1 + n,sqrt(x)) - besselj(1 + n,sqrt(x)))/(4*sqrt(x))"

    [<Test>]
    let ``Latex Format`` () =
        LaTeX.format (besselj n x) --> "J_{n}{x}"


module BesselY =

    [<Test>]
    let ``Special Value`` () =
        bessely 0Q 0Q ==> "-∞"
        bessely 1Q 0Q ==> "⧝"
        bessely -1Q 0Q ==> "⧝"
        bessely n PositiveInfinity ==> "0"
        bessely n NegativeInfinity ==> "0"

    [<Test>]
    let ``Connection Formulas`` () =
        bessely -n x ==> "(-1)^(n)*bessely(n,x)"

    [<Test>]
    let ``Calculus`` () =
        Calculus.differentiate x (bessely n (sqrt x)) ==> "(bessely(-1 + n,sqrt(x)) - bessely(1 + n,sqrt(x)))/(4*sqrt(x))"

    [<Test>]
    let ``Latex Format`` () =
        LaTeX.format (bessely n x) --> "Y_{n}{x}"


module BesselI =

    [<Test>]
    let ``Special Value`` () =
        besseli 0Q 0Q ==> "1"
        besseli 1Q 0Q ==> "0"
        besseli -1Q 0Q ==> "0"

    [<Test>]
    let ``Connection Formulas`` () =
        besseli -n x ==> "besseli(n,x)"

    [<Test>]
    let ``Calculus`` () =
        Calculus.differentiate x (besseli n (sqrt x)) ==> "(besseli(-1 + n,sqrt(x)) + besseli(1 + n,sqrt(x)))/(4*sqrt(x))"

    [<Test>]
    let ``Latex Format`` () =
        LaTeX.format (besseli n x) --> "I_{n}{x}"


module BesselK =

    [<Test>]
    let ``Special Value`` () =
        besselk 0Q 0Q ==> "∞"
        besselk 1Q 0Q ==> "⧝"
        besselk -1Q 0Q ==> "⧝"

    [<Test>]
    let ``Connection Formulas`` () =
        besselk -n x ==> "besselk(n,x)"

    [<Test>]
    let ``Calculus`` () =
        Calculus.differentiate x (besselk n (sqrt x)) ==> "(-besselk(-1 + n,sqrt(x)) - besselk(1 + n,sqrt(x)))/(4*sqrt(x))"

    [<Test>]
    let ``Latex Format`` () =
        LaTeX.format (besselk n x) --> "K_{n}{x}"


module BesselIRatio =

    [<Test>]
    let ``Special Value`` () =
        besseliratio 0Q 0Q ==> "0"
        besseliratio (1Q/2Q) x ==> "-1/x + coth(x)"
        besseliratio (-1Q/2Q) x ==> "tanh(x)"

    [<Test>]
    let ``Calculus`` () =
        Calculus.differentiate x (besseliratio n (sqrt x)) ==> "((besseli(n,sqrt(x)))^2 - besseli(-1 + n,sqrt(x))*besseli(1 + n,sqrt(x)) - (besseli(1 + n,sqrt(x)))^2 + besseli(n,sqrt(x))*besseli(2 + n,sqrt(x)))/(4*sqrt(x)*(besseli(n,sqrt(x)))^2)"

    [<Test>]
    let ``Latex Format`` () =
        LaTeX.format (besseliratio n x) --> "\\frac{I_{n + 1}{x}}{I_{n}{x}}"


module BesselKRatio =

    [<Test>]
    let ``Special Value`` () =
        besselkratio 0Q 0Q ==> "Undefined"
        besselkratio (1Q/2Q) x ==> "1 + 1/x"
        besselkratio (-1Q/2Q) x ==> "1"

    [<Test>]
    let ``Calculus`` () =
        Calculus.differentiate x (besselkratio n (sqrt x)) ==> "-((besselk(n,sqrt(x)))^2 - besselk(-1 + n,sqrt(x))*besselk(1 + n,sqrt(x)) - (besselk(1 + n,sqrt(x)))^2 + besselk(n,sqrt(x))*besselk(2 + n,sqrt(x)))/(4*sqrt(x)*(besselk(n,sqrt(x)))^2)"

    [<Test>]
    let ``Latex Format`` () =
        LaTeX.format (besselkratio n x) --> "\\frac{K_{n + 1}{x}}{K_{n}{x}}"


module HankelH1 =

    [<Test>]
    let ``Special Value`` () =
        hankelh1 0Q 0Q ==> "⧝"
        hankelh1 1Q 0Q ==> "⧝"
        hankelh1 -1Q 0Q ==> "⧝"

    [<Test>]
    let ``Connection Formulas`` () =
        hankelh1 -n x ==> "(-1)^(n)*hankelh1(n,x)"

    [<Test>]
    let ``Calculus`` () =
        Calculus.differentiate x (hankelh1 n (sqrt x)) ==> "(hankelh1(-1 + n,sqrt(x)) - hankelh1(1 + n,sqrt(x)))/(4*sqrt(x))"

    [<Test>]
    let ``Latex Format`` () =
        LaTeX.format (hankelh1 n x) --> "H^{(1)}_{n}{x}"


module HankelH2 =

    [<Test>]
    let ``Special Value`` () =
        hankelh2 0Q 0Q ==> "⧝"
        hankelh2 1Q 0Q ==> "⧝"
        hankelh2 -1Q 0Q ==> "⧝"

    [<Test>]
    let ``Connection Formulas`` () =
        hankelh2 -n x ==> "(-1)^(n)*hankelh2(n,x)"

    [<Test>]
    let ``Calculus`` () =
        Calculus.differentiate x (hankelh2 n (sqrt x)) ==> "(hankelh2(-1 + n,sqrt(x)) - hankelh2(1 + n,sqrt(x)))/(4*sqrt(x))"

    [<Test>]
    let ``Latex Format`` () =
        LaTeX.format (hankelh2 n x) --> "H^{(2)}_{n}{x}"
