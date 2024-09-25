namespace Redplcs.ChadAI;

public interface IChadClient
{
	IChadGpt4oMiniModel Gpt4oMini { get; }
	IChadGpt4oModel Gpt4o { get; }
	IChadClaude3HaikuModel Claude3Haiku { get; }
	IChadClaude3OpusModel Claude3Opus { get; }
	IChadClaude3p5SonnetModel Claude3p5Sonnet { get; }
}
