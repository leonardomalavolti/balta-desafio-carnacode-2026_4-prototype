using DesignPatternChallenge.Domain.Entities;
using DesignPatternChallenge.Domain.Enums;

namespace DesignPatternChallenge.Prototypes;

public class TemplateRegistry
{
    private readonly Dictionary<EDocumentTemplateType, DocumentTemplate> _templates = new();

    public void Register(EDocumentTemplateType type, DocumentTemplate template)
    {
        _templates[type] = template;
    }

    public DocumentTemplate Create(EDocumentTemplateType type)
    {
        if (!_templates.ContainsKey(type))
            throw new ArgumentException("Template não encontrado");

        return _templates[type].Clone();
    }
}