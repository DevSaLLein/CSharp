public class EnemyIA : MonoBehavior{
    int speed;
    float health;
    string enemyName;

    // Coleções de variáveis:
    //ARRAY:
    int[] intArray = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};

    //List-> Mais versátel:
    List<int> intList = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9};

    //Estamos dando um nome para a Classe EnemyWeapon
    EnemyWeapon weapon;


    //A estrutura a function é a seguinte: [retorno] [nome([parâmentro])(){}];
    void Movement(){

        intList.Remove(9);
        intList.Add(9);

        foreach( int intNumbers in intArray){

        }

        for(int i = 0 ; i < intArray.Length ; i++){
            int currentNumber = intArray[i];

        }

        for(int i = 0 ; i < intList.Count ; i++){
            int currentNumber = intList[i];
            
        }
        


        if(speed > 0 && health > 0){


        }else{

        }
    }

    void Attack(){

        //Estamos acessando o método chamado Shoot que se encontra no weapon(EnemyWeapon);
        weapon.Shoot();
        weapon.damage = 30;
        weapon.fireRate = 4.5;
    }

    void Dead(){

        if(health <= 0){

        }else{

        }
    }
}

public class EnemyWeapon{
    public float damage;
    public float fireRate;
    
    public void Shoot(){

    }
}