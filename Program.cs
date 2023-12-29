using projeto_estacionamento.model;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);
