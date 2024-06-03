Console.WriteLine("Conectando ao MongoDB...");

// Movendo os dados
mongoConnectionString repositorio = new mongoConnectionString();
repositorio.TransferirDadosParaMongo();

Console.WriteLine("Dados salvos com sucesso!");
