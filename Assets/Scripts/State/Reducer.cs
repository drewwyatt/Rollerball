using System;
namespace State {
  public interface Reducer<T> {
    public T value { get; }
  }
}
