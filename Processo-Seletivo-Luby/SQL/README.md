# SQL
 Tudo relativo ao processo sobre o teste referente a SQL.

---
## Preparando o ambiente.
Antes de começarmos, é importante preparar o ambiente no qual iremos trabalhar. Abaixo está um pequeno guia sobre como criar e inserir tabelas:
```SQL
CREATE TABLE tabela_pessoa (
  id INTEGER PRIMARY KEY,
  nome VARCHAR(50) NOT NULL
);

CREATE TABLE tabela_evento (
  id INTEGER PRIMARY KEY,
  evento VARCHAR(50) NOT NULL,
  id_pessoa INTEGER,
  FOREIGN KEY(id_pessoa) REFERENCES tabela_pessoa(id)
);
```
## Populando nossa database:
```SQL
INSERT INTO tabela_pessoa VALUES (1, 'John Doe');
INSERT INTO tabela_pessoa VALUES (2, 'Jane Doe');
INSERT INTO tabela_pessoa VALUES (3, 'Alice Jones');
INSERT INTO tabela_pessoa VALUES (4, 'Bobby Louis');
INSERT INTO tabela_pessoa VALUES (5, 'Lisa Romero');

INSERT INTO tabela_evento VALUES (1, 'Evento A', 2);
INSERT INTO tabela_evento VALUES (2, 'Evento B', 3);
INSERT INTO tabela_evento VALUES (3, 'Evento C', 2);
INSERT INTO tabela_evento VALUES (4, 'Evento D', NULL);
```

Pronto. Agora sim podemos começar.

## Abaixo estão as respostas, como solicitado em cada questão:
• [Questão 01](#questão01)   

• [Questão 02](#questão02)  

• [Questão 03](#questão03) 

• [Questão 04](#questão04)  

• [Questão 05](#questão05) 

• [Questão 06](#questão06)

• [Questão 07](#questão07)

• [Questão 08](#questão08)

• [Questão 09](#questão09)

• [Questão 10](#questão10)

---

## Questão01:
```SQL
SELECT p.nome AS pessoa, e.evento AS evento
FROM tabela_pessoa p, tabela_evento e
WHERE p.id = e.id_pessoa;
```

## Questão02:
```SQL
SELECT p.nome
FROM tabela_pessoa p
WHERE p.nome LIKE "%Doe%";
```

## Questão03:
```SQL
INSERT INTO tabela_evento VALUES(5, 'Evento E', 5);
```

## Questão04:
```SQL
UPDATE tabela_evento
SET id_pessoa = 1
WHERE evento = 'Evento D';
```

## Questão05:
```SQL
DELETE FROM tabela_evento
WHERE evento = "Evento B";
```

## Questão06:
```SQL
DELETE FROM tabela_pessoa
WHERE id NOT IN (SELECT id_pessoa FROM tabela_evento WHERE id_pessoa IS NOT NULL);
```

## Questão07:
```SQL
ALTER TABLE tabela_pessoa
ADD COLUMN idade INTEGER;
```

## Questão08:
```SQL
CREATE TABLE tabela_telefone (
  id INTEGER PRIMARY KEY,
  telefone VARCHAR(200),
  id_pessoa INTEGER NOT NULL,
  FOREIGN KEY(id_pessoa) REFERENCES tabela_pessoa(id)
);
```

## Questão09:
```SQL
ALTER TABLE tabela_telefone
ADD UNIQUE INDEX idx_telefone(telefone);
```

## Questão10:
```SQL
DROP TABLE tabela_telefone;
```

---

Isso é tudo!
