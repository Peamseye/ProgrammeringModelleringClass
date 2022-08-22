using System;


public class PaintGun {

    public int PaintAmmo = 20;
    
    public string WeaponFire = false;
    public if (WeaponFire == true && PaintAmmo > 0){
        Console.WriteLine("Pew! Pew!");
    }

    public string EnemyHit = false;
    public if (EnemyHit == true){
        Console.WriteLine("Enemy hit!");
    }
    else{
        Console.WriteLine("Miss!");
    }
}