using DesignPatternChallenge.Domain.Entities;

namespace DesignPatternChallenge.Services;

public class DocumentService
{
    #region Templates Base
    public DocumentTemplate CreateServiceContractTemplate()
    {
        Console.WriteLine("Criando TEMPLATE BASE - Contrato de Serviço do zero...");
        SimulateHeavyInitialization();

        var template = CreateBaseContractTemplate();
        template.Title = "Contrato de Prestação de Serviços";

        template.Sections.Add(new Section
        {
            Name = "Cláusula 1 - Objeto",
            Content = "O presente contrato tem por objeto...",
            IsEditable = true
        });

        template.Sections.Add(new Section
        {
            Name = "Cláusula 2 - Prazo",
            Content = "O prazo de vigência será de...",
            IsEditable = true
        });

        template.Sections.Add(new Section
        {
            Name = "Cláusula 3 - Valor",
            Content = "O valor total do contrato é de...",
            IsEditable = true
        });

        template.Tags.Add("servicos");

        return template;
    }

    public DocumentTemplate CreateConsultingContractTemplate()
    {
        Console.WriteLine("Criando TEMPLATE BASE - Contrato de Consultoria do zero...");
        SimulateHeavyInitialization();

        var template = CreateBaseContractTemplate();
        template.Title = "Contrato de Consultoria";

        template.Sections.Add(new Section
        {
            Name = "Cláusula 1 - Objeto",
            Content = "O presente contrato de consultoria tem por objeto...",
            IsEditable = true
        });

        template.Sections.Add(new Section
        {
            Name = "Cláusula 2 - Prazo",
            Content = "O prazo de vigência será de...",
            IsEditable = true
        });

        template.Tags.Add("consultoria");

        return template;
    }
    #endregion

    #region Métodos Privados de Apoio
    private DocumentTemplate CreateBaseContractTemplate()
    {
        var template = new DocumentTemplate
        {
            Category = "Contratos",
            Style = CreateDefaultStyle(),
            Workflow = CreateDefaultWorkflow()
        };

        template.RequiredFields.Add("NomeCliente");
        template.RequiredFields.Add("CPF");
        template.RequiredFields.Add("Endereco");

        template.Tags.Add("contrato");

        template.Metadata["Versao"] = "1.0";
        template.Metadata["Departamento"] = "Comercial";
        template.Metadata["UltimaRevisao"] = DateTime.Now.ToString();

        return template;
    }

    private DocumentStyle CreateDefaultStyle()
    {
        return new DocumentStyle
        {
            FontFamily = "Arial",
            FontSize = 12,
            HeaderColor = "#003366",
            LogoUrl = "https://company.com/logo.png",
            PageMargins = new Margins
            {
                Top = 2,
                Bottom = 2,
                Left = 3,
                Right = 3
            }
        };
    }

    private ApprovalWorkflow CreateDefaultWorkflow()
    {
        var workflow = new ApprovalWorkflow
        {
            RequiredApprovals = 2,
            TimeoutDays = 5
        };

        workflow.Approvers.Add("gerente@empresa.com");
        workflow.Approvers.Add("juridico@empresa.com");

        return workflow;
    }

    private void SimulateHeavyInitialization() => Thread.Sleep(100);
    #endregion

    public void DisplayTemplate(DocumentTemplate template)
    {
        Console.WriteLine($"\n=== {template.Title} ===");
        Console.WriteLine($"Categoria: {template.Category}");
        Console.WriteLine($"Seções: {template.Sections.Count}");
        Console.WriteLine($"Campos obrigatórios: {string.Join(", ", template.RequiredFields)}");
        Console.WriteLine($"Aprovadores: {string.Join(", ", template.Workflow.Approvers)}");
    }
}
