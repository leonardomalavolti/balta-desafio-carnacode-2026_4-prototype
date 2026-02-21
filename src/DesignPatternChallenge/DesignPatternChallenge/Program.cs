using DesignPatternChallenge.Domain.Enums;
using DesignPatternChallenge.Prototypes;
using DesignPatternChallenge.Services;

Console.WriteLine("=== Sistema de Templates de Documentos ===\n");

var service = new DocumentService();
var registry = new TemplateRegistry();

// Criamos os modelos base UMA VEZ
registry.Register(EDocumentTemplateType.ServiceContract, service.CreateServiceContractTemplate());
registry.Register(EDocumentTemplateType.ConsultingContract, service.CreateConsultingContractTemplate());

Console.WriteLine("Criando 5 contratos de serviço...");
var startTime = DateTime.Now;

for (int i = 1; i <= 5; i++)
{
    var contract = registry.Create(EDocumentTemplateType.ServiceContract);
    contract.Title = $"Contrato #{i} - Cliente {i}";
    service.DisplayTemplate(contract);
}

var elapsed = (DateTime.Now - startTime).TotalMilliseconds;
Console.WriteLine($"Tempo total: {elapsed}ms\n");

var consultingContract = registry.Create(EDocumentTemplateType.ConsultingContract);
service.DisplayTemplate(consultingContract);

Console.ReadKey();