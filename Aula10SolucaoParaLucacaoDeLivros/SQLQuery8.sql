﻿insert into Usuarios  -- informamos a tabela que vamos registrar o valor
(Nome) --as colunas que vamos carregar as informações
Values --informamos que os valores estarão logo a seguir
('Daniel') --nossas informações na ordem das colunas
GO
select * from Usuarios
GO
insert into Usuarios
(Nome, Login, Senha)
values
('Rosbervaldo','pulsao','123456')
GO
select * from Usuarios