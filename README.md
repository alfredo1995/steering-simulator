Jogo publicado: https://alfredo1995.github.io/simulador-direcao-unity

<br>

Aprendendo os fundamentos para criação de Jogo em C# na unity através da plataforma learn.unity    
    
    GameObjetos p/ representar os personagens, adereços e cenários;
    Empyty GameObjects p/ organizar os objetos;
    Progamando o componente Script p/ ser posivel dirigir o veiculo pela estrada;
    Gerenciador de entrada "InputManager" p/ obter as teclas de entrada;
    Acessando o componente Transform do Veiculo, p/ determina suas Posição, Rotação e Escala;
    Acessando o componente Translate, p/ definir a posição ou mover um objeto;
    Acessando o cmponente Rotate, p/ girar o veiculo;


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
           Quando for preciosado as setas, você recebe um valor de entrada de (+1) ou (-1) depedendo da direção;           
                
    1) No topo do PlayerController.cs, adicione uma variável pública TurnSpeed para contralamos a movimentação do veiculo;
           
                public class PlayerController : MonoBehaviour


                {
                    public float speed = 10.0f;
                    public float turnSpeed;

            
    2) vamos acessar o componete de transformação do player para conseguimos obter a movimentação no metodo update;
         
    3) transform > acessar a posição; tranlate > modificar a moviementação; Vector3 > composto por 3 componentes "(x,y,z)"; e .righ para move; 
         
    4) * Time.deltaTime > para atualizar essa posição ao longo do tempo em vez a cada frame(quadro);
         
    5) * turnSpeed > multiplicando pela variavel criada para acessar a movimentação; 
         
                void Update()
                {
                    transform.Translate(Vector3.forward * Time.deltaTime * speed);
                    transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
                }
         
Movimento base esquerda/direita na entrada

    1) No menu superior, clique em Editar > Configurações do Projeto, input manager >  fold-out dos Eixos para explorar as entradas;
    
    2) No PlayerController.cs, adicione uma nova  variável de flutuação pública "horizontalInput" p/ pegar o valor de entrada;
    
            public class PlayerController : MonoBehaviour

            {
                public float speed = 10.0f;
                public float turnSpeed;
                public float horizontalInput;
    
    3) Definir essa vaiavel no metodo Update, atribuir o valor usando o gerenciado de entrada Input. > acessando o metodo de eixo GetAxis();    
    
    4) em Unity, em nosso input manager, o nome do nosso eixto é "Horizontal";
    
           void Update()
            {
                horizontalInput = Input.GetAxis("Horizontal");
    
    5) Adicionar a variável horizontalInput ao método translate para obter o controle do veículo multiplicado pelo speedTurn;
    
           void Update()
            {
                horizontalInput = Input.GetAxis("Horizontal");

                transform.Translate(Vector3.forward * Time.deltaTime * speed);
                transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    
    6) No Unity, No Veiculo Inspetor, edite os valores das variáveis turnSpeed e speed para ajustar a sensação de velocidade;
    
Assuma o controle da velocidade do veículo

    1) Metodo Update > forwardInput atribuindo ao gerente de entrada input. acessando o metodo GetAxis() informando o eixo que será usado;
    
            void Update()
            {
                horizontalInput = Input.GetAxis("Horizontal");
                forwardnInput = Input.GetAxis("Vertical");
    
    4) Adicione a variável forwardInput ao método translate para a frente multiplicado com o speed;
    
            void Update()
            {                
                forwardnInput = Input.GetAxis("Vertical");
                horizontalInput = Input.GetAxis("Horizontal");

                transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardnInput);
                transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
                
Faça o veículo girar em vez de deslizar

    1) metodo Update, chamar trasform acessando o metodo de rotação > transform.Rotate > e acessar Vector3. up pegando o calculo do angulo(turnSpeed);
    
    2) O angula ja foi calculado em: transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    
    3) vamos recotar esse trecho de codigo: Time.deltaTime * turnSpeed * horizontalInput
    
    4) Adicionar ao transform.Rotate(Vector3.up, > 

            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    
Exclua o código q estava caluclundo o angulo com turnSpeed > transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
            
            void Update()
            {
                horizontalInput = Input.GetAxis("Horizontal");
                forwardnInput = Input.GetAxis("Vertical");

                transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardnInput);
                transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    

Inicialize variáveis com valores no PlayerController > public float turnSpeed = 50.0f;
    
    
    
    
    
    
<br> <br>





O caráter, o plano de fundo e o obstáculo de sua escolha serão configurados. O jogador será capaz de pressionar a barra espacial e fazer o personagem saltar, à medida que os obstáculos desovam na borda da tela e bloqueiam o caminho do jogador.


Abrir protótipo e alterar fundo

        1) Abra o Unity Hub e crie um projeto vazio de "Protótipo 3" em seu diretório de curso na versão unity correta.
        
        2) Clique para baixar o Protótipo 3 Starter Files, extrair a pasta compactada e, em seguida, importar o .unitypackage em seu projeto. 
        
        3) Abra a cena do Protótipo 3 e exclua a Cena da Amostra sem salvar
        
        4) Selecione o objeto De fundo na hierarquia e, em seguida, no  componente Sprite Renderer > Sprite, selecione a imagem _City, _Nature ou _Town

Escolha e configure um personagem do jogador

        1) Da Biblioteca de Curso > Personagens, Arraste um personagem para a hierarquia, renomeie-o  "Jogador", 
           em seguida, gire-o no eixo Y para enfrentar à direita
           
        2) Adicione um  componente do corpo RigBody     
        
        3) Adicione um colisor de caixa e, em seguida, edite os limites do colisor
        
        4) Crie uma nova pasta "Scripts" em Ativos, crie um script "PlayerController" dentro e conecte-o ao jogador
        
Faça o jogador saltar no início

        1) No PlayerController.cs, declare um novo playerrb rígido privado;  variável
        
        2) Em Start(), inicialize playerRb = GetComponent<Rigidbody>();
        
        3) Em Start(), use o método AddForce para fazer o jogador saltar no início do jogo
        
                public class PlayerController : MonoBehaviour
                {
                    private Rigidbody PlayerRb;
                    void Start()
                    {
                        PlayerRb = GetComponent<Rigidbody>();
                        PlayerRb.AddForce(Vector3.up * 500);
                    }

Faça o jogador saltar se a barra espacial pressionar

        1) Em Atualização() adicione uma instrução if-then verificando se a barra de espaço está pressionada
        
        2) Corte e cole o código AddForce do Start() na instrução if
        
        3) Adicione o  parâmetro ForceMode.Impulse à  chamada AddForce e, em seguida, reduza  o valor do multiplicador de força
        
                    void Update()
                    {
                        if (Input.GetKeyUp(KeyCode.Space))
                        {
                            PlayerRb.AddForce(Vector3.up * 10, ForceMode.Impulse);
                        }
                    }
                }
                
Ajuste a força de salto e a gravidade

        1) Substitua o valor codificado por uma nova  variável pública de salto flutuante

        2) Adicione uma nova  variável de gravidade flutuante públicaModifier e em Start(), 
           adicione Física.gravidade *= gravityModifier; 
        
        3) No inspetor, ajuste os valores de massa gravityModifier, jumpForce e Rigibody 
        
                public class PlayerController : MonoBehaviour
                {
                    public float jumpForce = 10.0f;
                    public float gravityModifier;
                    void Start()
                    {
                        PlayerRb = GetComponent<Rigidbody>();
                        Physics.gravity *= gravityModifier;
                    }

                    void Update()
                    {
                        if (Input.GetKeyUp(KeyCode.Space))
                        {
                            PlayerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                        }
                    }
                }

Evite que o jogador pule duas vezes

        1) Adicione uma nova variável  de bool isOnGround público e defina-a igual a verdade
        
        2) Na declaração se fazendo o jogador saltar, definir isOnGround = false,
        
        3) Adicione uma condição && isOnGround à declaração if ( && = e , para que haja mais uma afirmação)
        
        4) Adicione um novo metodo vazio OnCollisionEnter, definir isOnGround = verdadeiro nesse método
        
        5) quando o player estiver no chao = true , quando nao tiver = false
        
                public class PlayerController : MonoBehaviour
                {
                    public bool isOnGround = true;
                    
                    void Update()
                    {
                        if (Input.GetKeyUp(KeyCode.Space) && isOnGround)
                        {
                            PlayerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                            isOnGround = false; 
                        }
                    }

                    private void OnCollisionEnter(Collision collision)
                    {
                        isOnGround = true;

                    }
                }
                
Faça um obstáculo e mova-o para a esquerda

            1) Da Biblioteca de Curso > Obstáculos, adicione um obstáculo, renomeie-o como "Obstáculo", e  posicione-o onde deve desovar
            
            2) Aplique um  componente rígido do colisor de corpo e caixa e, em seguida, edite os limites do colisor para se encaixar no obstáculo
            
            3) Crie uma nova pasta "Prefabs" e arraste-a para criar um novo Prefab original
            
            4) Crie um novo script "MoveLeft",  aplique-o ao obstáculo e  abra-o para dar o efeito "parallax"
            
            5) Em MoveLeft.cs, escreva o código para traduzi-lo para a esquerda de acordo com a 
               variável de velocidade. Aplique o script MoveLeft ao fundo(background)
               
                    public class MoveLeft : MonoBehaviour
                    {
                        public float speed = 10.0f;
                        void Start()
                        {

                        }

                        void Update()
                        {
                            transform.Translate(Vector3.left * Time.deltaTime * speed);  
                        }
                    }
                    
Crie um gerenciador de desova

        1) Crie um novo objeto vazio "Spawn Manager" e aplique um novo  script .cs SpawnManager a ele

        2) Em SpawnManager.cs, declare um novo obstáculo público do GameObjectPrefab; , em seguida, 
           atribua seu pré-fabricado à nova variável no inspetor

        3) Declare um novo vetor3 privado spawnPos em seu local de desova
        
        4) In Start(), Instanciar um novo pré-fabricado de obstáculos 
        
        
                public class SpawnManager : MonoBehaviour
                {
                    public GameObject obstaclePrefabs;
                    private Vector3 spawnPosition = new Vector3(25, 0, 0);
                    void Start()
                    {
                        Instantiate(obstaclePrefabs, spawnPosition, obstaclePrefabs.transform.rotation);
                    }
                    
Gerar obstáculos em intervalos

        1) Crie um novo  método de desobstaculo de vazio e, em seguida, mova a  chamada Instantiate dentro dele

        2) Crie novas variáveis flutuantes para iniciarDelay e repetirRate

        3) Que seus obstáculos desovam em intervalos usando o  método InvokeRepeating()

        4) No componente Do corpo rígido do jogador, expanda as restrições e congele  tudo, menos a posição Y
        
                public class SpawnManager : MonoBehaviour
                {
                    public GameObject obstaclePrefabs;
                    private Vector3 spawnPosition = new Vector3(25, 0, 0);
                    private float startDelay = 2.0f;
                    private float repeatRate = 2.0f;
                    void Start()
                    {
                        InvokeRepeating("spawObstacle", startDelay, repeatRate);
                    }

                    void spawObstacle()
                    {
                        Instantiate(obstaclePrefabs, spawnPosition, obstaclePrefabs.transform.rotation);

                    }
                }


Crie um script para repetir o plano de fundo
    
        Crie um novo script chamado RepeatBackground.cs e conecte-o ao objeto de fundo
        
Redefinir posição de fundo

        1) Declarar uma nova variável private Vector3 startPos;

        2) Em Start(), defina a  variável startPos à sua posição inicial real atribuindo-a  = transform.position;

        3) Em Update(), escreva uma posição if-statement para redefinir se ela mover uma certa distância

                public class RepeatBackground : MonoBehaviour
                {
                    private Vector3 startPos;
                    void Start()
                    {
                        startPos = transform.position;
                    }

                    void Update()
                    {
                        if(transform.position.x < startPos.x -50)
                        {
                            transform.position = startPos;
                        }
                    }
                }

Corrigir repetição de fundo com colisor

        1) Adicione um  componente collider de  caixa ao fundo

        2) Declare uma nova  variável de repetição de flutuação privada

        3) Em Start(), obtenha a largura do colisor de caixa, dividido por 2

        4) Incorpore a  variável repetiçãoWidth na função repetição

                public class RepeatBackground : MonoBehaviour
                {
                    private Vector3 startPos;
                    private float reapetWidth;
                    void Start()
                    {
                        startPos = transform.position;
                        reapetWidth = GetComponent<BoxCollider>().size.x / 2;
                    }

                    void Update()
                    {
                        if(transform.position.x < startPos.x - reapetWidth)
                        {
                            transform.position = startPos;
                        }
                    }
                }


Adicione um novo jogo sobre o gatilho

        1) No inspetor, adicione uma tag "Ground" ao chão e uma tag "Obstáculo" ao pré-fio de obstáculo

        2) No PlayerController, declare um novo jogo público boolOver;

        3) Em OnCollisionEnter, adicione a instrução if-else para testar se o jogador colidiu com o "Ground" ou um "Obstáculo"

        4) Se eles colidiram com o "Ground", set isOnGround = verdadeiro, e se colidirem com um "Obstáculo", definir gameOver = verdadeiro        
        
                public class PlayerController : MonoBehaviour
                {
                    public bool gameOver = false;
                    
                    private void OnCollisionEnter(Collision collision)
                    {
                        if (collision.gameObject.CompareTag("Ground"))
                        {
                            isOnGround = true;
                        }
                        else if (collision.gameObject.CompareTag("Obstacle"))
                        {
                            gameOver = true;
                            Debug.Log("Game Over");
                        }

                    }
                }
                
Stop MoveLeft no gameOver

        1) Em MoveLeft.cs, declare um novo player privado PlayerControllerScript;

        2) In Start(), inicialize-o encontrando o Jogador e recebendo o componente PlayerController

        3) Enrole o método de tradução em uma verificação se o jogo não acabou
        
                public class MoveLeft : MonoBehaviour
                {
                    private float speed = 10.0f;
                    private PlayerController playControllerScript;
                    
                    void Start()
                    {
                        playControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
                    }

                    void Update()
                    {
                        if(playControllerScript.gameOver == false)
                        {
                            transform.Translate(Vector3.left * Time.deltaTime * speed);

                        }
                    }
                }


Principais Conceitos e Habilidades

        GetComponent
        ForceMode.Impulse
        Física.Gravidade
        Restrições rígidas do corpo
        Variáveis rigidbody
        Booleanos
        Multiplicar/Atribuir ("*) Operador
        E (&&) Operador
        OnCollisionEnter()

        Repetir o plano de fundo
        Obter largura collider
        Comunicação de script
        Igual a (==) operador
        Tags
        CompareTag()
