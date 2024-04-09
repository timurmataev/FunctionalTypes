open System

let isBoolNo = true
let isBoolYes: bool = true
//
let isByteNo = 12uy
let isByteYes: byte = 54uy
printfn "ByteNo: %d" isByteNo  
printfn "ByteYes: %d" isByteYes  
//
let isSbyteNo = -12y
let isSbyteYes: sbyte = 22y
printfn "SbyteNo: %d" isSbyteNo
printfn "SbyteYes: %d" isSbyteYes
//
let isInt16No = 15s
let isInt16Yes: int16 = 34s
printfn "Int16No: %d" isInt16No
printfn "Int16Yes: %d" isInt16Yes
//
let isIntNo = 23
let isIntYes: int = 12
printfn "IntNo: %d" isIntNo 
printfn "IntYes: %d" isIntYes 
//
let isUintNo = 56u
let isUintYes: uint = 14u
printfn "UintNo: %d" isUintNo
printfn "UintYes: %d" isUintYes
//
let isInt64No = 32L
let isInt64Yes: int64 = 26L
printfn "Int64No: %d" isInt64No
printfn "Int64Yes: %d" isInt64Yes
//
let isUint64No = 62UL
let isUint64Yes: uint64 = 66UL
printfn "Uint64No: %d" isUint64No
printfn "Uint64Yes: %d" isUint64Yes
//
let isMinusNo = nativeint 11
let isMinusYes: nativeint = nativeint 13
printfn "MinusNo: %d" isMinusNo
printfn "MinusYes: %d" isMinusYes
//
let isPlusNo = unativeint 33
let isPlusYes: unativeint = unativeint 44
printfn "PlusNo: %d" isPlusNo
printfn "PlusYes: %d" isPlusYes
//
let isFloatNo = 12.2
let isFloatYes: float = 14.5
printfn "FloatNo: %f" isFloatNo
printfn "FloatYes: %f" isFloatYes
//
let isDoubleYes: double = 56.7
printfn "DoubleYes: %f" isDoubleYes
//
let isFloat32No = 12.4f
let isFloat32Yes: float32 = 23.7f
printfn "Float32No: %f" isFloat32No
printfn "Float32Yes: %f" isFloat32Yes
//
let isSingleYes: single = 65.7f
printfn "SingleYes: %f" isSingleYes
//
let isDecimalNo = 12m
let isDecimalYes: decimal = 15m
printfn "DecimalNo: %f" isDecimalNo
printfn "DecimalYes: %f" isDecimalYes
//
let isCharNo = 'a'
let isCharYes: char = 'b'
printfn "CharNo: %c" isCharNo
printfn "CharYes: %c" isCharYes
//
let isStringNo = "a"
let isStringYes: string = "b"
printfn "StringNo: %s" isStringNo
printfn "StringYes: %s" isStringYes
//
