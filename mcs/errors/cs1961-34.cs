// CS1961: The contravariant type parameter `T' must be invariantly valid on `A<T>.B(ref T)'
// Line: 4

interface A<in T>
{
	void B(ref T t);
}
