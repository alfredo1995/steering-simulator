Aprendendo os fundamentos para criação de Jogos com C# na unity através da plataforma learn.unity

Jogo publicado: https://alfredo1995.github.io/simulador-direcao-unity

<br>

    Usei o Empyty GameObjects para organizar os objectos;
    Criei GameObjetos p/ representa os personagens, adereços e cenários;
    Adicionei componente aos gameobjetos p/ eles se transformaren em algo;
    Programei o script para ser posivel dirigir o veiculo pela estrada;
    Usei o inputManager para obter a entrada do veiculo, assim usaremo as teclas do teclado;
    Criei o componente Transform, para determina a Posição, Rotação e Escala do veiculo;
    Criei o componente Translate, para definir a posição ou mover um objeto;
    Criei o componente Rotate, para girar o veiculo;

<br>

Primeiro passo, faça o downloado do prototype 

    https://connect-prd-cdn.unity.com/20210923/c709e76b-3e93-4140-8675-f694b9f04399/Prototype%201%20-%20Starter%20Files.zip
    
Iniciando Projeto
    
    1) No desktop, clique com o botão direito do mouse > criar uma nova pasta, em seguida,  "nomeie-o a pasta";

    2) Crie um novo projeto Unity usando o modelo 3D - lembre-se de usar uma das versões suportadas do Unity;

    3) Nomeie o projeto baixado "Protótipo 1" e defina o local do arquivo para a nova pasta criada;

    4) Selecione Criar e, em seguida, aguarde que a Unity abra seu novo projeto;


Importar ativos contendo as cenas (Protótipo 1)

    https://learn.unity.com/tutorial/project-setup-processes#60ed7a91edbc2a002096b762
    
Protótipo 1

    1) Clique para baixar os arquivos do Protótipo 1, extraia a pasta compactada. > clique para abrir o arquivo;

    3) Na janela do Projeto, em  Ativos > Cenas > clique duplo na cena do Protótipo 1 para abri-lo;

    4) Assets > Scenes > seleecione a cena > prototype 1 / Exclua a cena padrao q ja não será mais usada;

    5) Clique com o botão direito + arraste para olhar ao redor no início da estrada;
    

Adicione seu veículo à cena

    1) Na Janela do Projeto, abra os ativos > Biblioteca de Cursos > Veículos e arraste um veículo para a Hierarquia;    
    
    2) Segure o botão direito do mouse + WASD para voar até o veículo, em seguida, tente girar em torno dele;  
    
    3) Com o veículo selecionado e seu mouse na vista da cena, pressione F para se concentrar nele;
    
    4) em seguida, use a roda de rolagem para ampliar e para fora e segurar a roda de rolagem para a panela
    Segure alt+left-click para girar ao redor do ponto focal ou mantenha alt+right-click para ampliar e sair;
    
    5) Se algo der errado, pressione Ctrl/Cmd+Z para desfazer até que seja corrigido;
    

Adicione um obstáculo e reposicione-o

    1) Vá para a Biblioteca de Cursos > Obstáculos e arraste um obstáculo diretamente para a vista da cena;

    2) No Inspetor para o seu obstáculo, no canto superior direito do componente Transformar, clique no botão mais opções > Redefinir a posição;: 

    3) No Inspetor, altere o Local XYZ para x=0, y=0, z=25;

    4) Na hierarquia, clique com o botão direito do mouse > renomeie seus dois objetos como "Veículo" e "Obstáculo";

Localize sua câmera e execute o jogo

    1) Selecione a câmera na hierarquia e pressione F para se concentrar nela;
    
    2) Pressione o botão Jogar para executar o seu jogo e pressione Play novamente para  pará-lo;
    
    3) Mova a câmera para trás do veículo;

    4) Use as  ferramentas Move and Rotate para mover a câmera atrás do veículo olhando para baixo sobre ele;    
 
Personalize o layout da interface

    1) No canto superior direito, altere o layout de "Padrão" para "Alto"; 
    
    2) Mova a visão do jogo abaixo da vista da cena;
    
    3) Na  janela Do Projeto, clique no menu suspenso no canto superior direito e escolha "Layout de uma coluna";
    
    4) No layout Dropdown, salve um novo Layout e chame de "Meu Layout";
    
Crie e aplique meu primeiro script
 
    0) Todos os GameObject são composto por componentes
    
    1) Na janela Do projeto, clique  com o botão > criar > pasta chamada "Scripts"
    
    2) Na pasta "Scripts", clique com o botão direito do mouse > Criar >C# Script chamado "PlayerController" 
    
    3) Arraste o novo script para o objeto Do veículo
    
    4) Clique no objeto do veículo para ter certeza de que foi adicionado como um componente no Inspetor
    
Dê ao veículo um movimento para a frente

    1) clique duplo no script > alterar o componente de trasformação
    
    2) Digite (adicionar 0, 0, 1 entre os parênteses e complete a linha com um ponto e vírgula (;)
    
    3) Pressione Ctrl/Cmd + S para salvar seu script e execute seu jogo para testá-lo

Codigo para alterar o componente de trasnformação

    void Update()
    {
        transform.Translate(0, 0, 1);
    }
    
Debugando o codigo para alter o componente de trasnformação
    
    1) um "T" minusculo signigica que estamos recebendo um componente de trasformação / veiculo transform
    
    2) Agora vamos movimentar o veiculo na direção z / Utilizando o metodo Translate para mudar a posição
    
    3) Acessando a propriedade do metodo Translate, para mudar a posição pelo X, Y e Z;
    
    4) Adicionado 0 no eixo X para que o veiculo não movar para direita ou esquerda;
    
    5) Adicionado 0 no eixo Y para que o veiculo não movar para cima ou abaixo;
    
    6) Adicionado 1 no eixo Z para que o veiculo mova na direção Z;

Use um Vector3 para seguir em frente

    1) Exclua o 0, 0, 1 digitado e use auto-completo para substituí-lo  por Vector3.forward;
    
    
Alteração no codigo do componente de trasnformação

        void Update()
    {
        transform.Translate(Vector3.forward);
    }
    
Debugando alteração no codigo do componente de trasnformação

    1) Vector3 é um tipo de variável composto por 3 componentes "(x,y,z)";
    
    2) basicamente serve para guardar 3 valores, um valor para cada um de seus componentes; 
    
    3) Você pode usar um Vector3 é comumente usado para guardar ou setar posições dos objetos no espaço 3D;
    
    4) .forward é o pra frente do objeto em que o script do código está

Personalize a velocidade do veículo

    1) Mudar a maneira com que movemos o veiculo;
    
    2) usar o simbolo * para multiplicamos algo;
    
    3) Time. para manter o controle do nosso tempo;
    
    4) . deltaTime para obter a mudança no tempo e assim saber quanto tempo se passou;
    
    5) Adicione * 20 para aumentar a velocidade do veiculo no jogo;

Debugando codigo para manipular a velocidade de movimentação do objeto

        void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 20);

    }
    
observação 

    Essa pequena equação, Vector3.forward esta armazendo 0, 0 e 1;
    Sendo multiplicada pelo tempo e por 20;
    Fazendo assim a multiplicação de cada um dos valores do Vector3;
    
Adicione componentes rigidbody aos objetos
    
    0) RigidBody é um componente que, quando adicionado a um objeto, habilita forças físicas a atuarem sobre ele;

    1) Selecione o Veículo e, em seguida, na hierarquia clique em Adicionar componente e selecione RigidBody;
    
    2) Selecione o Obstáculo e, em seguida, na hierarquia clique em Adicionar componente e selecione RigidBody;
    
    3) Nas propriedades do componente RigidBody, aumente a massa de veículos 100 e obstáculos 2 para ser sobre o que eles estariam em quilogramas;
    
    4) Mesh Collider sao os nossos caminho como o que esses objetos podem ser colididos;
    
    
Duplicar e posicionar os obstáculos

    1) Clique e arraste seu obstáculo para a parte inferior da lista na hierarquia
    
    2) Pressione Ctrl/Cmd+D para duplicar o obstáculo e movê-lo para baixo do eixo Z 
    
    3) Repita isso mais algumas vezes para criar mais obstáculos
    
    4) Depois de fazer algumas duplicatas, selecione uma na hierarquia e segure ctrl + clique para selecionar vários obstáculos e, em seguida, duplique-as 

Adicione uma variável de velocidade para o seu veículo

    0) vamos criar uma nova variavel "speed" para o veiculoPosition e defini o camePositon com base nessa variavel
    
    1) essa variavel vai ser capaz de alterar o * 20 que esta sendo multiplicado pelo tempo;
    
    1) No PlayerController.cs, adicione velocidade de flutuação pública  = 5,0f;  no topo da classe
    
    2) atribuir valor a nossa variavel de velocidade 
    
                Public class PlayController : Monobehaviour {

                float speed = 5.0f;
        
    2.1) assim onde tem o 20 no nosso metodo update onde estamos transformando nosso objeto
        
    2.2) vamos substuir o valor da velocidade de 20 pela nossa variavel "speed" para alterar a velocidade do veiculo; 
        
                void Update()
                {
                transform.Translate(Vector3.forward * Time.deltaTime * speed);

                }        
            
    2.3) Agora nossa variavel de velocidade esta no scopo global pertencendo assim a todas as class
                    

Crie um novo script para a câmera

    1) Crie um novo script C# chamado FollowPlayer e conecte-o à câmera;
    
    2) Clique como botao esquerdo no script FollowPlayer e arraste para dentro da hieraquia "Main Camera";
    
    3) Clique duplo no script FollowPlayer para ser aberto no visual studio;
    
    4) vamos criar um variavel publica do tipo GameObject que sirva de referencia para nosso veiculo(player) com a Main Camera
    
            public class FollowPlayer : MonoBehaviour
            {
            public GameObject player;
            }
        
    5) No unity selecione a "Main Camera" > no componente de script > vai visualizar a variavel Player contendo > None(GameObject)
    
    6) Vamos refernciar o nosso veiculo, clicando na pasta "Veiculo" arrastando pra dentro do componente da "Main Camera" > Nome(GameObject);
    
    7) Agora a variavel player esta referenciado o veiculo;
    
    8) Vamos obter a transformação da posição da camera no metodo update atribuindo a referencia player
    
    9) vamos acersar o compornente de trasnformação do player player.transform e obter a posição player.transform.position    
    
           void Update()
            {
                transform.position = player.transform.position;
            }
    
    10) Então agora a posição da câmera será definido para posição atual do player(veiculo)        
    
Adicione um deslocamento à posição da câmera
    
    0) Vamos compensar a câmera atrás do player, adicionado a posição do player;

    1) No script FollowPlayer.cs no metodo update onde estamos definindo a posição da nossa camera a posição acima e atras do player;
    
    2) Vamos adicionar para a posição do player, para que possamos compensar nossa câmera;
    
    3) Na linha no método 'criar' um novo Vector3(0, 5, -7), será criado um novo Vector3 apenas para essa linha de codigo;
    
    4) o novo Vector3 tera nas respectivas posições ( X = 0, Y = 5 e Z = -7);
    
            void Update()
            {
                transform.position = player.transform.position + new Vector3(0, 5, -7);
            }

    5) Na posição da sua câmera ( transform.position ) onde e definido como a posição do jogador (player.transform.position) e adicionado
       um novo Vector3 com os valores ( X = 0, Y = 5 e Z = -7);
       
       
Faça o deslocamento em uma variável Vector3

    1) Vamos criar uma variavel para Vector3 e assim remover os valores codificado ( X = 0, Y = 5 e Z = -7);
    
    2) No topo do FollowPlayer.cs, declare deslocamento privado do Vector3; 
    
    3) Vamos declarar uma variavel do tipo Vector3 e chama-la de "offset";
    
    4) vamos definir esta variavel para ser o valor codificado ( X = 0, Y = 5 e Z = -7);
    
    5) vamos remover os valores codificado new Vector3(0, 5, -7); referente ao> transform.position = player.transform.position + new Vector3(0, 5, -7);
    
    6) e defini na variavel offset >  private Vector3 offset = new Vector3(0, 5, -7);

            public class FollowPlayer : MonoBehaviour
            {
                public GameObject player;
                private Vector3 offset = new Vector3(0, 5, -7);
            }
            
    7) agora nossa variavel vetorial esta sendo definida para o novo vector3 com nossa posição de deslocamento adicionada a ele
    
    8) Agora no metodo Update, substitua o código original pela variável do tipo vector "offset";   
    
            void Update()
            {
                transform.position = player.transform.position + offset;
            }
            
    9) foi criado uma variavel do tipo vector3 chamada "offset", atribuindo o novo vector3 que sera responsavel pela inicialização  
    
Suavizar a câmera com LateUpdate
        
    1) vamos fazer uma mundaça no script FollowPlayer.cs para fazer o veiculo se move suavemente;
        
    2) No metodo Update nosso veiculo e nossa câmera estão se movendo ao mesmo tempo
        
    3) Vamos alterar o metodo  de atualização "Update" por "LateUpdate";
        
Edite a cor da tonalidade do playmode 

    1) No menu superior, vá para Editar preferências de > (Windows) ou Unity > Preferences (Mac) 
        
    2) No menu esquerdo, escolha Cores e edite a cor "Playmode tint" para ter uma cor leve 
        
    3) Em nosso FollowPlayer.cs apredendo a usar nossa primeira variavel publica para poder anexar uma referencia ao nosso player(veiculo) em unity
       
Deixe o veículo mover-se para a esquerda/direita

    0) Input e o sistema de entrada do unity, quando for precionado a seta para cima, você recebe um valor de entrada(+1);
           Quando for preciosado a seta para baixo, você recebe um valor de entrada(-1);
           Definimos o veiculo com a velocidade 10, entao vamos multiplicar a velocidade de entrada (speed # input);
           A telca Up vai fazer o (speed * (+1)) dando + 10 = forwand ( move esse veiculo na direção positiva para frent);
           A telca Down vai fazer o (speed * (-1)) dando - 10 = backwand ( move esse veiculo na direção negativa para trás);

           Para girar o veiculo vamos mutilplicar a rotação * (+1)
           Quando for preciosado a seta para direita, rotation * (+1) = move para direita;
           Quando for preciosado a seta para esquerda, rotation * (-1) = move para esquerda;
           
                
    1) No topo do PlayerController.cs, adicionar uma variável pública TurnSpeed para contralamos a movimentação do veiculo;
           
                public class PlayerController : MonoBehaviour


                {
                    public float speed = 10.0f;
                    public float turnSpeed;
                }
            
            
    2.1) vamos acessar o componete de transformação do player para conseguimos obter a movimentação no metodo update;
         
    2.2) transform > acessar a posição; tranlate > modificar a moviementação; Vector3 > composto por 3 componentes "(x,y,z)"; .righ > move para direita; 
         
    2.3) * Time.deltaTime > para atualizar essa posição ao longo do tempo em vez a cada frame(quadro);
         
    2.4) * turnSpeed > multiplicando pela variavel criada para acessar a movimentação; 
         
                void Update()
                {
                    transform.Translate(Vector3.forward * Time.deltaTime * speed);
                    transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
                }
         
Movimento base esquerda/direita na entrada

    1) No menu superior, clique em Editar > Configurações do Projeto, input manager >  fold-out dos Eixos para explorar as entradas;
    
    2) No PlayerController.cs, adicione uma nova  variável de flutuação de flutuação pública horizontalInput para pegar o valor de entrada;
    
            public class PlayerController : MonoBehaviour

            {
                public float speed = 10.0f;
                public float turnSpeed;
                public float horizontalInput;
    
    3) Definir essa vaiavel no nosso projeto m Update, atribua horizontalInput = Input.GetAxis("Horizontal");
    
    3.1) vamos usar nossa variavel horizontalInput = atribuir o valor usando o gerenciado de entrada Input. > acessando o metodo de eixo GetAxis();
    
    3.2) GetAxis(nesse metodo informamos o eixo que sera usada)  GetAxis("Horizontal")  string literal;
    
    3.3) em Unity, em nosso input manager, o nome do nosso eixto é "Horizontal";
    
           void Update()
            {
                horizontalInput = Input.GetAxis("Horizontal");
    
    3.4) Adicionar a  variável horizontalInput ao método de translate para obter o controle do veículo multiplicado pelo speedTurn;
    
           void Update()
            {
                horizontalInput = Input.GetAxis("Horizontal");

                transform.Translate(Vector3.forward * Time.deltaTime * speed);
                transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    
    3.5) No Unity, No Veiculo Inspetor, edite as  variáveis turnSpeed e speed para ajustar a sensação de velocidade;
    
Assuma o controle da velocidade do veículo

    1) Em PlayerController.cs Declare uma nova variável pública chamada forwardnInput;
    
    2) Em Update, atribua forwardInput = Input.GetAxis ("Vertical");
    
    3) forwardInput atribuindo ao gerente de entrada input. acessando o metodo GetAxis() informando o eixo que será usado;
    
            void Update()
            {
                horizontalInput = Input.GetAxis("Horizontal");
                forwardnInput = Input.GetAxis("Vertical");
    
    4) Adicione a variável forwardInput ao método translate para a frente multiplicado com o speed;
    
            void Update()
            {
                horizontalInput = Input.GetAxis("Horizontal");
                forwardnInput = Input.GetAxis("Vertical");

                transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardnInput);
                transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
                
Faça o veículo girar em vez de deslizar

    1) No metodo Update, vamos chamar o trasform usando o metodo de rotação de angulo >  transform.Rotate  > acessando o Vector3. up para pegar um angulo
    
            transform.Rotate(Vector3.up,
    
    2) O angula ja foi calculado por conta do turnSpeed (Time.deltaTime * turnSpeed * horizontalInput)
    
    3) podemos recotar esse trecho de codigo ( Time.deltaTime * turnSpeed * horizontalInput) no transform do turnSpeed;
    
    4) Adicionar no nosso transform.Rotate > 

           transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    
    5) Exclua a linha de código que traduz o turnSpeed  no metodo Update>
            
            void Update()
            {
                horizontalInput = Input.GetAxis("Horizontal");
                forwardnInput = Input.GetAxis("Vertical");

                transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardnInput);
                transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

Limpe seu código e hierarquia

    Na hierarquia, clique com o botão > criar uma pasta vazio e renomeá-lo como "Obstáculos", em seguida, arraste todos os obstáculos para ele
    
    Inicialize variáveis com valores no PlayerController > public float turnSpeed = 50.0f;
    
