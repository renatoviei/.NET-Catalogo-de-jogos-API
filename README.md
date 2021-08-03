# Catalogo-de-jogos
<h2>Criando um catálogo de jogos usando boas práticas de arquitetura com .NET e SQL Server</h2>

Neste projeto foi desenvolvido um pequeno sistema para o gerenciamento de um catálogo de jogos através de uma API REST, criada com o .NET.

Foram desenvolvidos e abordados os seguintes tópicos:

* Setup inicial de projeto com o Visual Studio 2019;
* Criação de modelo de dados para o mapeamento de entidades em bancos de dados;
* Criação de classes de abstração e contratos (Controllers, Interfcaces, Services e Repositórios);
* Criação do banco de dados SQL Server utilizando o Microsoft SQL Server Management Studio 18 e realização da conexão com a aplicação;
* Desenvolvimento de operações de gerenciamento de jogos (Cadastro, leitura, atualização e remoção de jogos de um sistema);
* Utilização do o Swagger/OpenAPI para realização de testes dos serviços e também como forma de documentar as informações da aplicação.

<h2>Script de criação e utilização do banco de dados CatalogoJogos e da tabela Jogos</h2>

```
use CatalogoJogos
```

```
CREATE TABLE jogos(
    Id uniqueidentifier PRIMARY KEY,
    Nome varchar(255),
    Produtora varchar(255),
    Preco float
);
```
```
INSERT INTO jogos (Id, Nome, Produtora, Preco)
VALUES ('0f5e5d99-c4b6-471d-a51b-fe526c91c105', 'Grand Chase', 'KOG', 200);

INSERT INTO jogos (Id, Nome, Produtora, Preco)
VALUES ('3392f1ea-5cf9-43a4-b5f4-91dbdb8b003c', 'Mortal Kombat', 'NetherRealm Studios', 80);

INSERT INTO jogos (Id, Nome, Produtora, Preco)
VALUES ('5a9b1849-57b8-489d-a988-4910b1e2bbc3', 'Injustice', 'NetherRealm Studios', 150);

INSERT INTO jogos (Id, Nome, Produtora, Preco)
VALUES ('2d91a70e-3303-4d71-9f70-c5adc6e20feb', 'Need For Speed', 'EA', 120);

INSERT INTO jogos (Id, Nome, Produtora, Preco)
VALUES ('e1b97fcd-5008-494e-b89e-47a53eb2717b', 'FIFA 2021', 'EA', 145);

INSERT INTO jogos (Id, Nome, Produtora, Preco)
VALUES ('f0d4cb89-03b5-4e0b-8757-aaddbf77514f', 'League of Legends', 'Riot', 115);
```
```
select * from jogos
```




