namespace Redplcs.ChadAI;

public interface IChadModel
{
	ValueTask<ChadGenerateResult> GenerateAsync(ChadGenerateOptions options, CancellationToken cancellationToken = default);
}

public static class ChadModelExtensions
{
	public static async ValueTask<string> GenerateAsync(this IChadModel model, string prompt, CancellationToken cancellationToken = default)
	{
		var options = new ChadGenerateOptions
		{
			Message = prompt,
		};

		var result = await model.GenerateAsync(options, cancellationToken).ConfigureAwait(false);
		return result.Response;
	}
}
