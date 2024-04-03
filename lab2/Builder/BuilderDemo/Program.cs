

using BuilderClassLib;

HeroBuilder heroBuilder = new HeroBuilder();
Character hero = heroBuilder.SetName("John")
    .SetClass("Warrior")
    .SetHealth(100)
    .SetLevel(1)
    .SetNickname("The Brave")
    .Build();
Console.WriteLine("Created hero with builder: " + hero.ToString());
hero.DoStuff("Attack");

EnemyBuilder enemyBuilder = new EnemyBuilder();
Character enemy = enemyBuilder.SetName("Orc")
    .SetClass("Berserker")
    .SetHealth(200)
    .SetLevel(5)
    .SetNickname("The Savage")
    .Build();
Console.WriteLine("Created enemy with builder: " + enemy.ToString());
enemy.DoStuff("Attack");

Director heroDirector = new Director(new HeroBuilder());
heroDirector.Create("John", "Warrior","The Brave", 1, 100);
Character hero2 = heroDirector.Builder.Build();
Console.WriteLine("Created hero with director: " + hero2.ToString());
hero2.DoStuff("some bad stuff");

Director enemyDirector = new Director(new EnemyBuilder());
enemyDirector.Create("Orc", "Berserker", "The Savage", 5, 200);
Character enemy2 = enemyDirector.Builder.Build();
Console.WriteLine("Created enemy with director: " + enemy2.ToString());
enemy2.DoStuff("some good stuff");
