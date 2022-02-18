using Cysharp.Threading.Tasks;

namespace State {
  public interface Reducer<T> {
    public AsyncReactiveProperty<T> value { get; }
  }
}
