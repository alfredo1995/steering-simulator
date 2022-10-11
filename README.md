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
    

        
 <br>
 
 ------------------------------
 
 <br>
        
Desenvolvimento do jogo alimentando animais


Primeiro passo, faça o downloado do prototype 2

    https://connect-prd-cdn.unity.com/20210507/bfd26de3-a68a-4a16-8cf6-8eacf2bb7f75/Prototype%202%20-%20Starter%20Files.zip
    
Iniciando o projeto

        1) No desktop > criar uma nova pasta, em seguida, "nomeie-o a pasta";

        2) Crie um novo projeto Unity usando o modelo 3D;

        3) Selecione Criar e, em seguida, aguarde que a Unity abra seu novo projeto;
        
Importar ativos contendo os personagens e adereços
    
        1) Extraia a pasta compactada dos arquivos importados > clique para abrir o arquivo;

        3) Na janela do Projeto, em  Assets > Scenes > Clique duplo na cena do Protótipo 1 para abri-lo;

        4) Assets > Scenes > seleecione a cena > prototype 2;
    
Adicione objetos à cena
    
        1) Na Janela do Projeto, abra os ativos > Biblioteca de Cursos > Humans e arraste um personagem para a Hierarquia;      

        2) faça o mesmo adicioanando 3 animais e 3 frutas na Hierarquia;
    
Posicioando os objetos

        1) Selecione o Humans;

        2) No Inspetor do Humans, no canto superior direito do componente Transformar, clique na opções > Redefinir a posição;    

        3) No Inspetor, altere o Local XYZ para x=0, y=0, z=25;
        
        4) Nomeie o Human para Player
        
        
        1) Selecione o Animals 1;

        2) No Inspetor do Animals 1, no canto superior direito do componente Transformar, clique na opções > Redefinir a posição;    

        3) No Inspetor, altere o Local XYZ para x=0, y=0, z=12;  
    
    
        1) Selecione o Animals 2;

        2) No Inspetor do Animals 2, no canto superior direito do componente Transformar, clique na opções > Redefinir a posição;    

        3) No Inspetor, altere o Local XYZ para x=12, y=0, z=12;          
        
        
        1) Selecione o Animals 3;

        2) No Inspetor do Animals 3, no canto superior direito do componente Transformar, clique na opções > Redefinir a posição;    

        3) No Inspetor, altere o Local XYZ para x=-12, y=0, z=12;  
        
        
        1) Selecione o Fruta 1;

        2) No Inspetor do Fruta 1, no canto superior direito do componente Transformar, clique na opções > Redefinir a posição;    

        3) No Inspetor, altere o Local XYZ para x=0, y=0, z=6;  
        
        
        1) Selecione o fruta 2;

        2) No Inspetor do fruta 2, no canto superior direito do componente Transformar, clique na opções > Redefinir a posição;    

        3) No Inspetor, altere o Local XYZ para x=6, y=0, z=6;  
        
        
        1) Selecione o fruta 3;

        2) No Inspetor do fruta 3, no canto superior direito do componente Transformar, clique na opções > Redefinir a posição;    

        3) No Inspetor, altere o Local XYZ para x=-6, y=0, z=6;  
        
        
Obtenha a entrada horizontal do usuário

        1) Na janela Do projeto, criei uma pasta chamada "Scripts"

        2) Na pasta "Scripts", clique com o botão direito do mouse > Criar >C# Script chamado "PlayerController" 

        3) Arraste o novo script para o objeto Player;
        
        4) clique duplo no script > No topo da class, declare um novo flutuador público horizontalInput;  
        
        5) Em Update(), defina horizontalInput = Input.GetAxis("Horizontal")
        
            public class PlayerController : MonoBehaviour
            {
                private float horizontalInput;
                
            void Update()
            {
                horizontalInput = Input.GetAxis("Horizontal");
            }


         6) horizontalInput recebendo o gerenciado de entrada, acessando os metodos de entrada getaxis("Horizontal");
        
Mova o jogador da esquerda para a direita

        1) Declarar uma nova velocidade de flutuação pública = 10,0f; 
        
        2) Em Update(), transform > acessando o componente transforme 
           .Translate > mundando o a posição
           Verctor3.right representando os eixo x, y e z;
           multiplicado pelo horizontalInput para sabe a direção
           multiplicado pelo Time.deltaTime para se calculado por tempo e nao frame
           multiplicado pela varivavel responsavel por determinar a velocidade
        
            void Update()
            {
                transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
            }
            
Mantenha as entradas do jogador
        
        1)Em Update(), escreva uma instrução se a posição X esquerda do jogador for menor que um determinado valor
            
        2)Na instrução if, defina a posição do jogador para sua posição atual, mas com um local X fixo
        
            void Update()
            {
                if (transforma.position.x < -12)
                {
                     transform.position = new Vector3(-12, transform.position.y, transform.position.z);
                }
                
               if (transform.position.x > 12)
                {
                    transform.position = new Vector3(12, transform.position.y, transform.position.z);
                }
        
        3) if acessando a posição, pegando um valor especifico "x", certificando q e - 12 ;
        
        4) obtendo a posição de x = configurar para a posição com um novo vecto3(definindo sua posição limite ate -12,
            mas posição x e y não muda);
  
  
Declarar variavel para controlar o valor da posição limite;

    1) Declare nova  variável xRange e substitua os valores codificados por eles

            public class PlayerController : MonoBehaviour
            {
                public float xRanger = 12.0f;
                
                
     2)substitua os valores codificados por ela   
     

                if (transform.position.x < -xRanger)
                {
                    transform.position = new Vector3(-xRanger, transform.position.y, transform.position.z);
                }
                if (transform.position.x > xRanger)
                {
                    transform.position = new Vector3(xRanger, transform.position.y, transform.position.z);
                }
                
                
Faça o projétil voar para a frente

        1) Crie um novo script "MoveForward", conecte-o ao objeto de comida e abra-o

        2) Declare uma nova  variável de velocidade de flutuação pública;

        3)Em Update(), adicione transformar. Traduzir (pegar a posicao x, y e z. direçao -> Vector3.forward 
          multiplicado pelo tempo e velocidade * Time.deltaTime * velocidade);

                public class MoveForward : MonoBehaviour
                {
                   public float speed = 10.0f;

                   void Start()
                    {

                    }

                    void Update()
                    {
                        transform.Translate(Vector3.forward * Time.deltaTime * speed);
                    }
                }

Transforme o projétil em um prefab


        1) Crie uma nova pasta "Prefabs", arraste sua comida para ela e escolha o Prefab original

fazendo com que o player tenha a referencia da comida

        1) No PlayerController.cs, declare uma nova variável public do tipo GameObjectresponsavel por armazenar objetos (GameObjectPrefab);

                public class PlayerController : MonoBehaviour
                {
                    public GameObject projectilePrefab;

        2)Selecione o Jogador na hierarquia e arraste  o objeto da pasta Prefabs para a nova caixa Pré-fabricado de projétil no inspetor

Teste para a prensa da barra espacial

        1) No PlayerController.cs, em Update(), adicione uma instrução condicional p/ verificar se foi precionado a 
           barra de espaço na função transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    //lançar um projetil do jogador
                }

Lançar projétil na prensa da barra espacial

        1) Dentro da instrução if, use o método Instantiate para gerar um novo (objeto) na localização do jogador. com a rotação do pré-fabricado

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
                }
                
Transforme animais em pré-fabricados

        1) Gire todos os animais no eixo Y em 180 graus para enfrentar
        
        2) Selecione os três animais na hierarquia e adicione componente > MoveForward.cs
        
        3) Edite seus valores de velocidade e teste para ver como ele se parece
        
        4) Arraste os três animais para a pasta Prefabs, escolhendo "Original Prefab"
        
Destruir projéteis fora da tela

        1) Crie o script "DestroyOutOfBounds" e aplique-o no projétil(comida)
        
        2)Adicione uma nova  variável de topo de flutuação privada e inicialize-a = 30;
        
        3) Escreva código para destruir se fora dos limites superiores se (transform.position.z > topBound) { Destroy(gameObject); }
        
        4) No Inspetor Substitui a queda, clique em Aplicar tudo para aplicá-lo ao pré-fabricado;
        
Destruir animais fora da tela

        1) Crie uma instrução de seleção para verificar se os objetos estão abaixo do lowerBound: caso (transform.position.z < lowerBound)
        
        2) Aplique o script a todos os animais, em seguida, anular os pré-fabricados

                public class DestroyOutBounds : MonoBehaviour
                {
                    public float topBound = 30.0f;
                    public float lowerBound = -10.0f;

                        void Update()
                    {
                        if(transform.position.z > topBound)
                        {
                            Destroy(gameObject);
                        }else if(transform.position.z < lowerBound){
                            Destroy(gameObject);
                        }
                    }
                }
                
12
