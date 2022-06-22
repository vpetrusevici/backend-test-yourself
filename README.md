# Coding test

### Implement these three methods the way, you consider to be the right one

> #### Instructions:
>
> 1. Fork the repo
> 2. Fulfill your implementation 
> 3. Create a PullRequest and push your implementation

// Problem 1: Implement the following method Map without using library methods
// (ie no Linq).
//
// Map applies a function to each element of a list and returns the
// resulting list.
//
// Map([1,2,3], x => x + 1) = [2,3,4]
// Map([1,2,3], x => x.ToString()) = ["1","2","3"]
// Map([], ...) == []

List<B> Map<A, B>(List<A> list, Func<A, B> f)
// Problem 2: Implement the following method Fold
//
// Fold applies a function to each element of a list and propagates a state
// through calls to this function, starting with the initial state.
//
// Fold([1,2,3], 0, (sum,x) => sum + x) == 6
// Fold([1,2,3], "", (str,x) => str + x.ToString()) == "123"
// Fold([], init, ...) == init

B Fold<A, B>(List<A> list, B initial, Func<B, A, B> folder)
// Problem 3: implement Map in terms of Fold. Rather than implementing Map
// directly like the first exercise, implement Map by finding a way to call
// Fold so that it achieves the desired result.

List<B> Map2<A, B>(List<A> list, Func<A, B> f)
