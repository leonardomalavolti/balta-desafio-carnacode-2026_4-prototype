![CR-4](https://github.com/user-attachments/assets/d96fdc78-1ca6-4bc0-afc6-eee0d583c796)

# 🥁 CarnaCode 2026 - Desafio 04 - Prototype

Olá! Eu sou **Leonardo Malavolti Monteiro** 👋\
Este projeto faz parte da minha jornada no **CarnaCode 2026**, promovido
pelo balta.io.

Neste desafio implementei o **Prototype Pattern** para resolver um
problema real relacionado à criação de documentos complexos.

------------------------------------------------------------------------

## 📌 Sobre este desafio

O sistema precisava gerar diversos documentos baseados em templates
complexos (contratos, propostas, relatórios).

O problema da implementação original:

-   ❌ Recriação constante de objetos complexos
-   ❌ Inicializações custosas repetidas
-   ❌ Código duplicado
-   ❌ Baixa performance
-   ❌ Alto acoplamento

------------------------------------------------------------------------

## 🛠️ Solução Aplicada

Implementei o **Prototype Pattern** para:

-   ✅ Criar templates base apenas uma vez
-   ✅ Clonar objetos já configurados
-   ✅ Implementar Deep Copy para evitar referências compartilhadas
-   ✅ Melhorar performance
-   ✅ Reduzir duplicação de código
-   ✅ Permitir personalização após clonagem

### Estrutura aplicada

-   IPrototype`<T>`{=html} → Interface para clonagem
-   DocumentTemplate → Implementação de Clone com Deep Copy
-   TemplateRegistry → Registro central de templates base
-   Enum DocumentTemplateType → Segurança de tipo
-   DocumentService → Responsável apenas por criar modelos base

------------------------------------------------------------------------

## 📚 Aprendizados

Durante este desafio aprimorei:

-   Aplicação prática do Prototype Pattern
-   Diferença entre Shallow Copy e Deep Copy
-   Manipulação segura de listas e objetos com referência
-   Redução de duplicação de código
-   Melhoria de performance através de reutilização de instâncias
-   Organização arquitetural utilizando Registry
-   Uso de Enum para maior segurança de tipos

------------------------------------------------------------------------

## 🚀 Resultado

Antes: - Cada documento era criado do zero - Processos pesados eram
repetidos - Código duplicado

Depois: - Templates criados uma única vez - Clonagem rápida e segura -
Código mais limpo e escalável - Melhor separação de responsabilidades

------------------------------------------------------------------------

## 🎭 Sobre o CarnaCode 2026

O CarnaCode 2026 consiste na implementação prática dos 23 Design
Patterns em cenários reais, com foco em arquitetura e escalabilidade.

Cada desafio reforça o pensamento arquitetural e a identificação de
problemas reais de software.

------------------------------------------------------------------------

## 📘 Fonte de Estudo

Fundamentos dos Design Patterns (balta.io)

------------------------------------------------------------------------

## 📌 Veja meu progresso no desafio

Repositório central da jornada CarnaCode 2026:\
\[Adicionar link aqui\]

------------------------------------------------------------------------

💡 Seguimos evoluindo na jornada dos Design Patterns!
