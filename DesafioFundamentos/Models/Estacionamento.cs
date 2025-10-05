using System.Security.Cryptography.X509Certificates;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:"); 
            veiculos.Add(Console.ReadLine()); //Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
        }
        //Metodo para Pagamento de Cartão
        public decimal CartaoOuDebito(int horas)
        {

            string DebitoOuCredito = string.Empty;
            Console.WriteLine("Debito ou Credito : "); 
            DebitoOuCredito = Console.ReadLine();

            string numeroCartao = string.Empty;
            Console.WriteLine("Informe o numero do seu cartão: ");
            numeroCartao = Console.ReadLine();

            string bandeiraCartao = string.Empty;
            Console.WriteLine("Informe a Bandeira do seu Cartão: ");
            bandeiraCartao = Console.ReadLine();

            string codigoVerificacaoCartao = string.Empty;
            Console.WriteLine("Informe o Codigo de Verificação de 3 digitos (123): ");
            codigoVerificacaoCartao = Console.ReadLine();

            string nomeTitular = string.Empty;
            Console.WriteLine("Informe o Nome do Titular: ");
            nomeTitular = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Confira as Informações do seu Cartão:\n" +
            $"Função: {DebitoOuCredito}\n" +
            $"Numero do Cartão: {numeroCartao}\n" +
            $"Bandeira do Cartão: {bandeiraCartao}\n" +
            $"Codigo De Verificação: {codigoVerificacaoCartao}\n" +
            $"Nome Do Titular: {nomeTitular}\n" +
            "Prosseguir [S/n] ?: ");

            string resposta = string.Empty;
            resposta = Console.ReadLine().ToUpper();

            if (resposta == "S")
            {
                decimal valorTotal = (precoInicial + precoPorHora) * horas; //valor total que foi pago
                return valorTotal;
            }
            return 0;
        }

        //Metodo para Pagamento de com Pix
        public decimal PixChaveOuQRCode(int horas)
        {
            Console.Clear();
            //Chave aleatoria
            Console.WriteLine("Sua Chave Pix:\naskdjf16546asdf65468asGOV_SP.BRas2d1va5BRD_ESTACIONAMENTOS_qrCODE54");

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string[] linhas = {
            "██  ██  ████  ██  ",
            "██      ██    ████",
            "  ██  ████  ██    ",
            "██  ████    ████  ",
            "  ████  ██      ██",
            "██    ██    ████  "
            };

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }

            string nome = string.Empty;
            Console.WriteLine("Informe seu nome: ");
            nome = Console.ReadLine();

            string CPF = string.Empty;
            Console.WriteLine("Informe o CPF: ");
            CPF = Console.ReadLine();

            Console.WriteLine("Confirme as informação para efetuar o pagamento\n" +
            $"Nome: {nome}\n" +
            $"CPF: {CPF}\n" +
            "Prosseguir [S/n] ? ");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "S")
            {
                decimal valorTotal = (precoInicial + precoPorHora) * horas; //valor total que foi pago
                return valorTotal;
            }
            return 0;
        }



        public void RemoverVeiculo() 
        {
            string placa = "";
            decimal valorTotal = 0;

            Console.WriteLine("Digite a placa do veículo para remover:");
            placa = Console.ReadLine(); // Pedir para o usuário digitar a placa e armazenar na variável placa
            
            
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = 0;
                horas = Convert.ToInt32(Console.ReadLine()); // Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,

            Console.Clear();
            Console.WriteLine("Escolha um metodo de Pagamento: ");

            bool menuPagamento = true;

                while (menuPagamento) // Metodos de pagamento adicionado
                {
                    Console.WriteLine("1 - Cartão (Debito ou Credito): ");
                    Console.WriteLine("2 - Pix (Chave ou QR code): ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            valorTotal = CartaoOuDebito(horas); // cartão debito ou credito
                            menuPagamento = false;
                            break;
                        case "2":
                            valorTotal= PixChaveOuQRCode(horas); // Pix 
                            menuPagamento = false;
                            break;
                        default:
                            Console.WriteLine("Você nao pode sair sem pagar !");
                            break;
                    }
                }

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                veiculos.Remove(placa); // Remover a placa digitada da lista de veículos
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }

        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                    foreach (string carro in veiculos) { // Laço de repetição, exibindo os veículos estacionados
                    Console.WriteLine(carro);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
