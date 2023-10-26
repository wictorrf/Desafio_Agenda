# Desafio_Agenda

Projeto de uma agenda completa utilizando .Net CORE 6 utilizando o EntityFramework no backend e VueJs no frontend. Fiz a instalação do _Microsoft.EntityFrameworkCore.SqlServer_ para utilizaro sqlServer como banco de dados, e para as validações das entities cadastradas eu utilizei a FluentValidation, e tratei para que viesse a resposta de erro desejada, alem das 
validações eu tambem usei o automapper para que no metodo POST e PUT, O usuário não precise visualizar o id na requisição, ja que ele é gerado automaticamente. O crud 
completo voce pode testar as requisições no swagger rodando o comando **dotnet watch run**. 

Utilizei o XUNIT para fazer um teste simples de retorno 200 do meu controller utilizando mocks. 

No frontend com VueJs Utilizei o Boostrap framework para me dar praticidade no design, e instalei o toastify para trazer as responses das validações de cada input de maneira visualmente
mais agradavel.

## OBS:
Eu criei o Dockerfile na minha api, mas eu não pude gerar a imagem e rodar por que minha máquina só tem 4 gb ram apenas, e com os programas abertos não foi capaz de gerar as imagens. Mas eu criei a configuração no arquivo e dps de fazer a build da image, eu iria rodar _docker run -d -p 72:90 my-dotnet-app:1.0_ para inicial a imagem na porta determinada.



