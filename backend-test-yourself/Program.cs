using backend_test_yourself;
using Newtonsoft.Json;

var exampleValues = new[] { 1, 2, 3, 4 };

var result1 = exampleValues.Map(i => i.ToString());

Console.WriteLine($"Map result: {JsonConvert.SerializeObject(result1)}");


var result2 = exampleValues.Fold("", (str, x) => str + x);

Console.WriteLine($"Fols result: {JsonConvert.SerializeObject(result2)}");


var result3 = exampleValues.Map2(i => i.ToString());

Console.WriteLine($"Map2 result: {JsonConvert.SerializeObject(result3)}");