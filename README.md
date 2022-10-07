Aprendendo os fundamentos para criação de Jogo em C# na unity através da plataforma learn.unity

Jogo publicado: https://alfredo1995.github.io/simulador-direcao-unity

<br>

    Empyty GameObjects p/ organizar os objetos;
    GameObjetos p/ representar os personagens, adereços e cenários;
    Componente Script C# p/ transformar os GameObjetos em algo;
    Progamando o Script p/ ser posivel dirigir o veiculo pela estrada;
    InputManager p/ obter as teclas de entrada do veiculo;
    Componente Transform, para determina suas Posição, Rotação e Escala do Veiculo;
    Componente Translate, para definir a posição ou mover um objeto;
    Componente Rotate, para girar o veiculo;

<br>

Primeiro passo, faça o downloado do prototype 1

    https://connect-prd-cdn.unity.com/20210923/c709e76b-3e93-4140-8675-f694b9f04399/Prototype%201%20-%20Starter%20Files.zip
    
Iniciando Projeto
    
    1) No desktop > criar uma nova pasta, em seguida, "nomeie-o a pasta";

    2) Crie um novo projeto Unity usando o modelo 3D;

    3) Selecione Criar e, em seguida, aguarde que a Unity abra seu novo projeto;


Importar ativos contendo os personagens e adereços

    https://assetstore.unity.com/packages/3d/vehicles/land/arcade-free-racing-car-161085  
    
Protótipo 1

    1) Extraia a pasta compactada dos arquivos importados > clique para abrir o arquivo;

    3) Na janela do Projeto, em  Assets > Scenes > Clique duplo na cena do Protótipo 1 para abri-lo;

    4) Assets > Scenes > seleecione a cena > prototype 1;
  

Adicione seu veículo à cena

    1) Na Janela do Projeto, abra os ativos > Biblioteca de Cursos > Veículos e arraste um veículo para a Hierarquia;      
    
    2) Com o veículo selecionado e seu mouse na vista da cena, pressione F para se concentrar nele;
    

Adicione um obstáculo e reposicione-o

    1) Vá para a Biblioteca de Cursos > Obstáculos e arraste um obstáculo diretamente para a vista da cena;

    2) No Inspetor para o seu obstáculo, no canto superior direito do componente Transformar, clique no botão mais opções > Redefinir a posição;    

    3) No Inspetor, altere o Local XYZ para x=0, y=0, z=25;

    4) Na hierarquia, clique com o botão direito do mouse > renomeie seus dois objetos como "Veículo" e "Obstáculo";

Localize sua câmera e execute o jogo

    1) Selecione a câmera na hierarquia e pressione F para se concentrar nela;    

    2) Mova a câmera para trás do veículo;

    3) Use as  ferramentas Move and Rotate para mover a câmera atrás do veículo olhando para baixo sobre ele;   
    
Crie e aplique o primeiro script
 
    0) Todos os GameObject são composto por componentes;
    
    1) Na janela Do projeto, criei uma pasta chamada "Scripts"
    
    2) Na pasta "Scripts", clique com o botão direito do mouse > Criar >C# Script chamado "PlayerController" 
    
    3) Arraste o novo script para o objeto Do veículo;
    
    4) Clique no objeto do veículo p/ ter certeza de que foi adicionado como um componente no Inspetor
    
Dê ao veículo um movimento para a frente

    1) clique duplo no script > Metodo update do objeto veiculo, alterar o componente de trasformação;    

    void Update()
    {
        transform.Translate(0, 0, 1);
    } 


Debugando o codigo acima p/ alterar o componente de trasnformação
    
    1) um "T" minusculo signigica que estamos recebendo um componente de trasformação / veiculo transform;
    
    2) Utilizando o metodo Translate para mudar a posição. Movimentar o veiculo na direção z;
    
    3) Acessando a propriedade do metodo Translate, para mudar a posição pelo eixos X, Y e Z;
    
    4) Adicionado 0 no eixo X para que o veiculo não movar para direita ou esquerda;
    
    5) Adicionado 0 no eixo Y para que o veiculo não movar para cima ou abaixo;
    
    6) Adicionado 1 no eixo Z para que o veiculo mova na direção Z;

Use um Vector3 para seguir em frente, alterando o codigo do componente de trasnformação

    1) Excluir o 0, 0, 1 para substituí-lo por Vector3.forward;
    
    
        void Update()
    {
        transform.Translate(Vector3.forward);
    }
    
Debugando alteração no codigo do componente de trasnformação

    1) Vector3 é um tipo de variável composto por 3 componentes "(x,y,z)";
    
    2) basicamente serve para guardar 3 valores, um valor para cada um de seus componentes; 
    
    3) Um Vector3 é comumente usado para guardar ou setar posições dos objetos no espaço 3D;
    
    4) .forward é o pra frente do objeto no script;

Personalize a velocidade do veículo

    1) mudar a maneira com que movemos o veiculo;
    
    2) usar o simbolo * para multiplicamos;  
    
    2) usar o Time. para manter o controle do nosso tempo em vez de frame;    
    
    4) usar .deltaTime para obter a mudança no tempo e assim saber quanto tempo se passou;
    
    5) multiplicar * 20 para aumentar a velocidade do veiculo no jogo;
  
  
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 20);

    }
    
Adicione componentes rigidbody aos objetos
    
    0) RigidBody é um componente que, quando adicionado a um objeto, habilita forças físicas a atuarem sobre ele;

    1) Selecione o Veículo e, em seguida, na hierarquia clique em Adicionar componente e selecione RigidBody;
    
    2) Selecione o Obstáculo e, em seguida, na hierarquia clique em Adicionar componente e selecione RigidBody;
    
    3) Nas propriedades do componente RigidBody, aumente a massa de veículos p/ 100 e obstáculos p/ 2 assim eles estão em quilogramas;
    
    4) Mesh Collider sao os nossos caminho como o que esses objetos podem ser colididos;
    
    
Duplicar e posicionar os obstáculos

    1) Clique e em seu obstáculo a janela de hierarquia;
    
    2) Pressione Ctrl/Cmd+D para duplicar o obstáculo e movê-lo para baixo do eixo Z;     

Adicione uma variável de velocidade para o seu veículo

    0) vamos criar uma nova variavel "speed" para definimos a velocidade do veiculo nessa variavel;
    
    1) essa variavel vai ser capaz de alterar o * 20 que esta sendo multiplicado pelo tempo;
    
    2) No PlayerController.cs, atribua a velocidade de flutuação pública  = 5,0f;  no topo da classe
    
   
        Public class PlayController : Monobehaviour {

        float speed = 5.0f;
        
        
    3) assim onde tem o 20 que esta sendo multiplicado pelo tempo;
        
    4) vamos substuir o valor da velocidade de 20 pela nossa variavel "speed" para alterar a velocidade do veiculo; 
        
        void Update()
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        }        
                             

Crie um novo script para a câmera

    1) Crie um novo script C# chamado FollowPlayer e conecte-o à câmera;
    
    2) Clique no script FollowPlayer e arraste para dentro da hieraquia "Main Camera";
    
    3) Clique duplo no script FollowPlayer para ser aberto no visual studio;
    
    4) vamos criar um variavel publica do tipo GameObject que sirva de referencia para nosso player(veiculo) com a Main Camera
    
        public class FollowPlayer : MonoBehaviour
        {
            public GameObject player;        
        
    5) No unity selecione a "Main Camera" > no componente de script > vai visualizar a variavel Player contendo > None(GameObject)
    
    6) Vamos refernciar o nosso veiculo, clicando na pasta "Veiculo" arrastando pra dentro do componente da "Main Camera" > Nome(GameObject);
    
    7) Agora a variavel player esta referenciado o veiculo;
    
    8) Vamos obter a transformação da posição da camera no metodo update atribuindo a referencia player
    
    9) vamos acersar o compornente de trasnformação do player player.transform e obter a posição
    
           void Update()
            {
                transform.position = player.transform.position;
            }
    
    10) Agora a posição da câmera será definido para posição atual do player(veiculo)        
    
Adicione um deslocamento à posição da câmera
    
    0) Vamos compensar a câmera atrás do player, adicionado a posição do player;

    1) Script FollowPlayer.cs no metodo update onde estamos definindo a posição da nossa camera(transform.position);    
    
    2) Na linha no método 'criar' um novo Vector3(0, 5, -7), será criado um novo Vector3 apenas para essa linha de codigo;
    
    3) o novo Vector3 tera nas respectivas posições ( X = 0, Y = 5 e Z = -7);
    
            void Update()
            {
                transform.position = player.transform.position + new Vector3(0, 5, -7);
            }
       
       
Faça o deslocamento em uma variável Vector3

    1) Vamos criar uma variavel Vector3 e assim remover os valores codificado ( X = 0, Y = 5 e Z = -7);
    
    2) No topo do FollowPlayer.cs, declare deslocamento privado do Vector3; 
    
    3) Vamos declarar uma variavel do tipo Vector3 e chama-la de "offset";
    
    4) vamos definir esta variavel para ser o valor codificado ( X = 0, Y = 5 e Z = -7);
    
    5) vamos remover os valores codificado new Vector3(0, 5, -7);
    
    6) defini uma variavel do tipo vector3 chamada "offset", atribuindo o novo vector3 que sera responsavel pela inicialização  


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
    
