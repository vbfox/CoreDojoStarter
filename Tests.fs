module Tests

open Expecto

open Dojo

[<Tests>]
let tests =
  testList "All tests for the Dojo" [
    test "This is a passing test" {
      Expect.isTrue (isThisReallyTrue true) "True should be true"
    }
    test "This is a failing test" {
      Expect.isFalse (isThisReallyTrue false) "False should be false"
    }
  ]
