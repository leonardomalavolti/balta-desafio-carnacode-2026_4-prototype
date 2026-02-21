using DesignPatternChallenge.Interfaces;

namespace DesignPatternChallenge.Domain.Entities;
public class DocumentTemplate : IPrototype<DocumentTemplate>
{
    public string Title { get; set; }
    public string Category { get; set; }
    public List<Section> Sections { get; set; }
    public DocumentStyle Style { get; set; }
    public List<string> RequiredFields { get; set; }
    public Dictionary<string, string> Metadata { get; set; }
    public ApprovalWorkflow Workflow { get; set; }
    public List<string> Tags { get; set; }

    public DocumentTemplate()
    {
        Sections = new List<Section>();
        RequiredFields = new List<string>();
        Metadata = new Dictionary<string, string>();
        Tags = new List<string>();
    }

    public DocumentTemplate Clone()
    {
        return new DocumentTemplate
        {
            Title = Title,
            Category = Category,
            Sections = Sections.Select(s => new Section
            {
                Name = s.Name,
                Content = s.Content,
                IsEditable = s.IsEditable,
                Placeholders = new List<string>(s.Placeholders)
            }).ToList(),

            Style = new DocumentStyle
            {
                FontFamily = Style.FontFamily,
                FontSize = Style.FontSize,
                HeaderColor = Style.HeaderColor,
                LogoUrl = Style.LogoUrl,
                PageMargins = new Margins
                {
                    Top = Style.PageMargins.Top,
                    Bottom = Style.PageMargins.Bottom,
                    Left = Style.PageMargins.Left,
                    Right = Style.PageMargins.Right
                }
            },

            RequiredFields = new List<string>(RequiredFields),
            Metadata = new Dictionary<string, string>(Metadata),

            Workflow = new ApprovalWorkflow
            {
                RequiredApprovals = Workflow.RequiredApprovals,
                TimeoutDays = Workflow.TimeoutDays,
                Approvers = new List<string>(Workflow.Approvers)
            },

            Tags = new List<string>(Tags)
        };
    }
}