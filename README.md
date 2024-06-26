# AluraTamagotchiPokemon

AluraTamagotchiPokemon é um projeto de aplicação console em C#, utilizando a arquitetura MVC .NET. Este projeto integra-se com a PokeAPI para permitir a seleção e interação com um Pokémon (Squirtle, Charizard, Bulbasaur ou Pikachu) como seu pet virtual. Você poderá alimentar e brincar com seu pet, proporcionando uma experiência divertida e interativa.

## Estrutura do Projeto

O projeto segue a arquitetura MVC (Model-View-Controller), onde cada camada tem uma responsabilidade específica:

- **Models**: Contém os modelos de dados, incluindo o modelo do pet adotado e os modelos de comunicação com a PokeAPI (Pokemon, Ability, Type).
- **Views**: Responsável pela interface do usuário, apresentando menus e opções de interação.
- **Controllers**: Gerencia a lógica da aplicação, controlando o fluxo de dados entre as Views e os Models.

## Funcionalidades

### Menu Principal

O menu principal apresenta as seguintes opções:
1. Adotar um Pokémon
2. Ver seus mascotes
3. Sair

### Adotar um Pokémon

Ao selecionar a opção de adotar um Pokémon, serão apresentadas as espécies disponíveis (Squirtle, Charizard, Bulbasaur ou Pikachu). Após selecionar uma espécie, um novo menu será exibido com as opções:
- Saber mais sobre a espécie
- Efetivar a adoção
- Voltar ao menu principal

### Ver Seus Mascotes

No menu de ver seus mascotes, é possível:
- Visualizar o status do pet
- Brincar com o pet
- Alimentar o pet

## Modelos

### Pet

Representa o Pokémon adotado pelo usuário, contendo informações como nome, espécie, nível de fome, felicidade, entre outras.

### Pokemon

Modelo utilizado para comunicar com a PokeAPI, contendo informações básicas sobre o Pokémon.

### Ability

Modelo representando as habilidades do Pokémon.

### Type

Modelo representando os tipos do Pokémon.

## Tecnologias Utilizadas
- C#
- API do Pokémon
- JSON

## Configuração do Projeto

### Pré-requisitos

- .NET SDK instalado
- Acesso à internet para consumir a PokeAPI

### Instalação

1. Clone o repositório:
   ```bash
   git clone https://github.com/ThiegoGagliardi/AluraTamagotchiPokemon.git
   ```
2. Navegue até o diretório do projeto:
   ```bash
   cd AluraTamagotchiPokemon
   ```
3. Restaure as dependências do projeto:
   ```bash
   dotnet restore
   ```

### Execução

Para executar a aplicação, utilize o comando:
```bash
dotnet run
```

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.

---

Desfrute de seu AluraTamagotchiPokemon e divirta-se com seu novo pet virtual!