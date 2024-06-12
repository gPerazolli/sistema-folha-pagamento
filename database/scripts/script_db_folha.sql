use db_folha;

CREATE TABLE funcionarios(
id_funcionario INT NOT NULL PRIMARY KEY,
nome VARCHAR(50) NOT NULL,
cpf VARCHAR(13) NOT NULL,
cargo VARCHAR(50) NOT NULL,
data_admissao DATE NOT NULL,
ctps VARCHAR(30) NOT NULL,
situacao BIT
);

CREATE TABLE folha(
mes_ano VARCHAR(7) NOT NULL,
id_funcionario INT NOT NULL,
salario DECIMAL(10,2) NOT NULL DEFAULT 0,
percentual_inss FLOAT NOT NULL,
hora_extra INT,
salario_hora_extra decimal(10,2),
descontos_totais  DECIMAL(10,2) NOT NULL,
salario_liquido DECIMAL(10,2) NOT NULL,
salario_13 DECIMAL(10,2) NOT NULL DEFAULT 0,
fgts FLOAT NOT NULL,
PRIMARY KEY(mes_ano,id_funcionario),
FOREIGN KEY(id_funcionario) REFERENCES funcionarios(id_funcionario)
);

CREATE TABLE usuarios(
id_usu int not null primary key,
nome_usu varchar(50) not null,
login_usu varchar(10) not null,
senha_usu varchar(10) not null
);



select * from funcionarios;
select * from folha;

select (id_funcionario) from funcionarios

