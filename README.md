https://github.com/alfredo1995/unity-infinite-reusable-scroll-view/assets/71193893/b714be7e-6b97-457c-8e19-f0c72ca3e869

<h3> Implementação do ScrollView infinito e reciclável para aplicações WebGL móveis e desktop </h3>

ScrollRectPool.cs

 	Gerencia um pool de objetos (representados por GameObjects) em uma ScrollRect, permitindo ativar objetos conforme necessário para evitar a criação e destruição frequente de objetos, o que pode ser mais eficiente em termos de desempenho.

Item.cs

	Controla o comportamento de um item na cena, permitindo que ele seja ativado, desativado e tenha seu texto atualizado conforme necessário. Mantém controle sobre se o item está visível ou invisível, para gerenciamento do sistema de pool de objetos.
   
ItemList.cs

	Uso do ScriptableObject para criar um tipo de dado customizado chamado ItemList que esta sendo usado para armazenar uma lista de strings. 

InfiniteScroll.cs

	Lógica de rolagem infinita p/ uma lista de itens em um ScrollRect, movendo os itens p/ cima ou p/ baixo, e atualizando os itens visíveis com novos dados da lista de itens.

CheckVisibility.cs

	Gerenciando a visibilidade dos itens em uma lista dentro de um ScrollRect, ativando e desativando (Object Pooling) os itens conforme eles entram e saem da área visível da lista (interage com o componente InfiniteScroll para lidar com a rolagem infinita da lista). 

<br>
<h3> Arquitetura de Projeto (Design Baseado em Componentes) Responsabilidade Única </h3>
	
        Cada componente ou classe tem uma única responsabilidade bem definida. Isso ajuda a manter o código mais organizado, fácil de entender, modificar e testar.
    
<br>
<h3> Técnicas de otimização aplicadas e resultados obtidos. </h3>

	Técnica de otimização:  Pooling de Objetos para reciclar elementos existentes em vez de instanciar novos objetos sempre que necessário.
        Resultados obtidos:     Evitando a alocação e desalocação frequente de memória, reduzindo a sobrecarga do coletor de lixo (garbage collector) e melhorando o desempenho geral da aplicação	

	Técnica de otimização: Singleton para Gerenciamento de Instância Única no script CheckVisibility para gerenciar uma instância única é uma prática eficiente, especialmente quando há necessidade de acesso global a uma única instância de um objeto. 
        Resultados obtidos   : Evitando múltiplas alocações desnecessárias de memória para o mesmo objeto e simplifica o gerenciamento de estado global.

	Técnica de otimização: Modularidade e Reutilização de Componentes UI. (Utilizando componentes pré-fabricados na criação dinâmica de itens com base em uma lista).
	Resultados obtidos   : Otimização do conjunto de objetos e a garantia de que os elementos não sejam usados são desabilitados quando eles estão fora da tela para reduzir o uso de recursos.
 
	Técnica de otimização:  Reciclagem de Itens para listas longas com Scroll Infinito para itens visíveis, em vez de criar e destruir novos objetos conforme o usuário rola pela lista. 
        Resultados obtidos   :  Reduzindo a sobrecarga de criação e destruição de objetos, melhorando o desempenho e evitando picos de uso de memória.

 	Técnica de otimização:  RectTransforms em Vez de Transforms para elementos de interface do usuário
        Resultados obtidos   :  Mais eficiente no uso de RectTransforms em termos de desempenho para elementos da UI, especialmente quando se trata de posicionamento e dimensionamento dentro de um layout de UI.

	Técnica de otimização:  Métodos Eficientes para Verificar Visibilidade (O método OnScrollRectValueChanged no script CheckVisibility usa métodos eficientes para verificar se um item está visível ou não, como calcular a posição do item e dos cantos visíveis da lista). 
        Resultados obtidos   :  Evitando cálculos desnecessários ou complexos que possam impactar negativamente o desempenho.                                
    
    
<br>
<h3> Execução do Projeto </h3>

Instalação do Editor Unity

     instale o Unity Editor na versão 2022:3.27

Clone o repositório:

     Encontre e selecione o método de clonagem desejado, como HTTPS ou SSH (Copy Clone URL)
 
<br>
<h3> Execução do aplicativo: </h3>

     Acesse a URL abaixo para baixar e executar o arquivo APK (Android) ou IPA (iOS) em seu dispositivo.
> https://abre.ai/apk-scroll
