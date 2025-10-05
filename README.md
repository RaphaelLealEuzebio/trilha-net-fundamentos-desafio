# DIO - Trilha .NET - Fundamentos
www.dio.me

# 🚗 Estacionamento Inteligente

Bem-vindo ao **Estacionamento Inteligente** – um sistema simples e funcional para gerenciamento de veículos em um estacionamento, desenvolvido em **C#**.  
Este projeto foi criado para o desafio de fundamentos, mas possui um design extensível e organizado que facilita sua manutenção e evolução.

---

## 📋 Descrição

O **Estacionamento Inteligente** permite:

- 🅿️ Adicionar veículos ao estacionamento.
- 📜 Listar todos os veículos atualmente estacionados.
- 💳 Remover veículos com cálculo automático do valor a ser pago.
- 💰 Suporte a múltiplos métodos de pagamento:
  - **Cartão (Débito ou Crédito)**
  - **PIX (Chave ou QR Code)**

O objetivo do projeto é treinar conceitos fundamentais de **POO (Programação Orientada a Objetos)**, como:
- Uso de classes e métodos.
- Manipulação de listas (`List<string>`).
- Estruturas de controle (`if`, `switch`, `while`).
- Entrada e saída de dados via console.
- Encapsulamento e boas práticas de código.

---

## 🏗️ Estrutura do Projeto

```
DesafioFundamentos/
│
├── Models/
│ └── Estacionamento.cs # Classe principal com as funcionalidades do estacionamento
│
├── Program.cs # Ponto de entrada da aplicação (Main)
│
└── README.md # Documentação do projeto
```
---

## ⚙️ Funcionalidades da Classe `Estacionamento`

### 🔑 Propriedades
- `precoInicial`: Valor fixo cobrado pela entrada no estacionamento.
- `precoPorHora`: Valor adicional cobrado por cada hora de permanência.
- `veiculos`: Lista que armazena as placas dos veículos estacionados.

---

### 📦 Métodos

| Método                    | Descrição                                                                 |
|---------------------------|---------------------------------------------------------------------------|
| `AdicionarVeiculo()`      | Solicita a placa do veículo e adiciona à lista de veículos estacionados. |
| `ListarVeiculos()`        | Exibe todos os veículos atualmente estacionados.                         |
| `RemoverVeiculo()`        | Remove um veículo após cálculo do pagamento (suporte a Cartão ou PIX).   |
| `CartaoOuDebito(int horas)` | Realiza o pagamento via cartão (débito ou crédito).                     |
| `PixChaveOuQRCode(int horas)` | Permite pagamento via PIX usando chave ou QR Code.                    |

---

## 💳 Métodos de Pagamento

### 1. Cartão (Débito ou Crédito)
- Solicita os dados do cartão (função, número, bandeira, CVV e nome do titular).
- Exibe um resumo das informações para confirmação.
- Calcula automaticamente o valor com base no **preço inicial + preço por hora × horas**.

### 2. PIX (Chave ou QR Code)
- Exibe uma chave PIX ou QR Code ASCII para pagamento.
- Solicita nome e CPF do pagante.
- Confirma as informações e calcula o valor final.

---

## ⚡ Exemplo de Uso

```csharp
using DesafioFundamentos.Models;

class Program
{
    static void Main()
    {
        // Configuração inicial do estacionamento
        decimal precoInicial = 5.00m;
        decimal precoPorHora = 2.00m;

        Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

        // Exemplo de operações
        estacionamento.AdicionarVeiculo();  // Adiciona um veículo
        estacionamento.ListarVeiculos();    // Lista todos os veículos
        estacionamento.RemoverVeiculo();    // Remove um veículo e calcula o pagamento
    }
}

🖥️ Demonstração (Fluxo Simples)
Digite a placa do veículo para estacionar:
> ABC-1234
Veículo adicionado com sucesso!

Escolha um método de pagamento:
1 - Cartão
2 - PIX
> 2

Sua Chave Pix:
askdjf16546asdf65468asGOV_SP.BRas2d1va5BRD_ESTACIONAMENTOS_qrCODE54

██ ██ ████ █
█ ██ ████ █
█ ████ █ █ █
█ █ ███ ████
████ ██ ██ █ 

Informe seu nome:
> João da Silva
Informe seu CPF:
> 123.456.789-00
Prosseguir [S/n] ?
> S

O veículo ABC-1234 foi removido e o preço total foi de: R$ 15,00

```
## 🔧 Pré-Requisitos

### .NET SDK 6.0 ou superior

IDE de sua preferência (por exemplo: Visual Studio
 ou Visual Studio Code
)

## 🚀 Como Executar

### 1. Clone este repositório:
```
git clone https://github.com/seu-usuario/estacionamento-inteligente.git

```
## 2. Acesse a pasta do projeto:
```
cd estacionamento-inteligente

```
## 3. Compile e execute:
```
dotnet run

```
## 🏆 Boas Práticas Adotadas

 ### Código limpo e organizado.
  
 ### Nomes de métodos e variáveis descritivos.
  
 ### Validação básica de entradas do usuário.
  
 ### Uso de Console.Clear() para melhorar a experiência no terminal.
  
 ### Simulação visual de QR Code para um toque de realismo.

## 📜 Licença

 ### Este projeto é licenciado sob a MIT License.
  
 ### Sinta-se livre para usar, modificar e compartilhar.

## 👨‍💻 Autor

## Raphael Leal Euzebio (Mage </> 🧙‍♂️)
  ### 💼 Desenvolvedor | 🚀 Entusiasta de .NET | 📚 Aprendiz constante

# Se gostou deste projeto, ⭐ deixe uma estrela no repositório!
