namespace BabelBot.Shared;

public interface ITranslator
{
    public Task<TranslationResult> TranslateAsync(
        string text,
        TranslationContext context,
        CancellationToken cancellationToken);

    public Task<TranslationResult> TranslateAsync(string text, CancellationToken cancellationToken);
}