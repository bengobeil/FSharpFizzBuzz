open FizzBuzz

#load "Library.fs"

Parser.tryParse "2"
Parser.tryParse "Tomato"

open Validator

ValidNumber.isValidNumber 5
ValidNumber.isValidNumber 0
ValidNumber.isValidNumber 4500

ValidNumber.isValidNumber 20
|> Option.map FizzBuzz.getFizzBuzzString