https://github.com/alfredo1995/recyclable-scroll-view/assets/71193893/a8eeb87b-7a91-49e0-b19a-96e2ca49db6d

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
<h3> Técnicas de otimização aplicadas e resultados obtidos. </h3>

	Pooling de Objetos para reciclar elementos existentes em vez de instanciar novos objetos sempre que necessário.
        Evitando a alocação e desalocação frequente de memória, reduzindo a sobrecarga do coletor de lixo (garbage collector) e melhorando o desempenho geral da aplicação	

	Singleton para Gerenciamento de Instância Única no script CheckVisibility, especialmente quando há necessidade de acesso global a uma única instância de um objeto. 
        Evitando múltiplas alocações desnecessárias de memória para o mesmo objeto e simplifica o gerenciamento de estado global.

	Técnica de otimização: Modularidade e Reutilização de Componentes UI. (Utilizando componentes pré-fabricados na criação dinâmica de itens com base em uma lista).
	Resultados obtidos   : Otimização do conjunto de objetos e a garantia de que os elementos não sejam usados são desabilitados quando eles estão fora da tela para reduzir o uso de recursos.
 
 	No RectTransforms em Vez de Transforms para elementos de interface do usuário
        Mais eficiente no uso de RectTransforms em termos de desempenho para elementos da UI, especialmente quando se trata de posicionamento e dimensionamento dentro de um layout de UI.

	OnScrollRectValueChanged no script CheckVisibility verifcando se um item está visível ou não, como calcular a posição do item e dos cantos visíveis da lista. 
        Evitando cálculos desnecessários ou complexos que possam impactar negativamente o desempenho.                                
    
    
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
