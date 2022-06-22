# Coding test

### Implement these three methods the way, you consider to be the right one 

> #### Instructions:
>
> 1. Fork the repo
> 2. Fulfill your implementation 
> 3. Create a PullRequest and push your implementation
>


// Problem 1: Implement the following method Map without using library methods <br />
// (ie no Linq). <br />
// <br />
// Map applies a function to each element of a list and returns the <br />
// resulting list. <br>
// <br>
// **_Map([1,2,3], x => x + 1) = [2,3,4]_** <br>
// **_Map([1,2,3], x => x.ToString()) = ["1","2","3"]_** <br>
// **_Map([], ...) == []_** <br>

```
List<B> Map<A, B>(List<A> list, Func<A, B> f)
```

// Problem 2: Implement the following method Fold <br>
// <br>
// Fold applies a function to each element of a list and propagates a state <br>
// through calls to this function, starting with the initial state. <br>
// <br>
// _**Fold([1,2,3], 0, (sum,x) => sum + x) == 6**_ <br>
// _***Fold([1,2,3], "", (str,x) => str + x.ToString()) == "123"***_ <br>
// **_Fold([], init, ...) == init_** <br>

```
B Fold<A, B>(List<A> list, B initial, Func<B, A, B> folder)
```


// Problem 3: implement Map in terms of Fold. Rather than implementing Map <br>
// directly like the first exercise, implement Map by finding a way to call <br>
// Fold so that it achieves the desired result. <br>

```
List<B> Map2<A, B>(List<A> list, Func<A, B> f)
```
