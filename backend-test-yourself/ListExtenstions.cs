
namespace backend_test_yourself;
public static class IEnumberableExtenstions
{
    public static IEnumerable<G> Map<T, G>(this IEnumerable<T> source, Func<T, G> func)
    {
        var newList = new List<G>();
        foreach (var item in source)
        {
            newList.Add(func(item));
        }
        return newList;
    }

    public static G Fold<T, G>(this IEnumerable<T> source, G initialState, Func<G, T, G> func)
    {
        var currentState = initialState;
        foreach (var item in source)
        {
            currentState = func(currentState, item);
        }
        return currentState;
    }

    public static IEnumerable<G> Map2<T, G>(this IEnumerable<T> source, Func<T, G> func)
        => source.Fold(
            new List<G>(),
            (accum, item) =>
            {
                accum.Add(func(item));
                return accum;
            });
}
