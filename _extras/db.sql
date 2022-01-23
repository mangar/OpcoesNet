create table IF NOT EXISTS acoes (
	id int not null auto_increment,
    ticker varchar(50) not null,
    quantidade int not null default 0,
    preco_medio decimal(10,2) not null default 0.0,
    primary key(id)
);

insert into acoes (ticker, quantidade, preco_medio)
values ('MGLU3', 1000, 10.00);

select * from acoes;

create table IF NOT EXISTS acoes_movimentacoes (
	id int not null auto_increment,
    acoes_id int not null,
    ticker varchar(50) not null,
    quantidade int not null default 0,
    preco decimal(10,2) not null default 0.0,
    primary key(id),
    FOREIGN KEY (acoes_id) REFERENCES Acoes(ID)
    
)
