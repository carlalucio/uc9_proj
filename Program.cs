using uc9_prj.classes;

PessoaJuridica metodoPj = new PessoaJuridica();
PessoaJuridica novaPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();

novaPj.nome = "NomePj";
novaPj.cnpj = "00.000.000/0001-00";
novaPj.razaoSocial = "Razao Social Pj";
novaPj.rendimento = 8000.5f;
novoEndPj.logradouro = "Avenida Capuava";
novoEndPj.numero = 565;
novoEndPj.complemento = "Comercial";
novoEndPj.endComercial = true;
novaPj.endereco = novoEndPj;

Console.WriteLine(@$"
    Nome: {novaPj.nome}
    Razão Social: {novaPj.razaoSocial}
    CNPJ: {novaPj.cnpj}
    CNPJ é válido: {metodoPj.ValidarCnpj(novaPj.cnpj)}");







// PessoaFisica novaPf = new PessoaFisica();
// Endereco novoEnd = new Endereco();

// PessoaFisica metodoPf = new PessoaFisica();


// novaPf.nome = "Carla";
// novaPf.dataNascimento = "15/10/1988";
// novaPf.cpf = "23212345674";
// novaPf.rendimento = 600.0f;
// novoEnd.logradouro = "Avenida Capuava";
// novoEnd.numero = 565;
// novoEnd.complemento = "Casa";
// novoEnd.endComercial = false;

// novaPf.endereco = novoEnd;

// Console.WriteLine(@$"
// Nome: {novaPf.nome}
// Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
// Maior de Idade: {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}
// ");


// novaPf.nome = "Carla";
// Console.WriteLine("Nome: " + novaPf.nome);
// Console.WriteLine($"Nome: {novaPf.nome}");



// Console.WriteLine(novaPf.ValidarDataNascimento(new DateTime(2000,01,01)));


// Console.WriteLine(novaPf.ValidarDataNascimento("15/10/2020"));
// ;
