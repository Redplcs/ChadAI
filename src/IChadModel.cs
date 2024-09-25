namespace Redplcs.ChadAI;

public interface IChadModel
{
	ValueTask<string> GenerateAsync(string prompt, CancellationToken cancellationToken = default);
}
