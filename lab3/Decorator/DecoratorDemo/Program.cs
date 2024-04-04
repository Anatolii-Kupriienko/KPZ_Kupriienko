
using DecoratorClassLib;
using DecoratorClassLib.Artifacts;
using DecoratorClassLib.Artifacts.Decorators;

Mage mage = new Mage("Merlin", 100, 5, 100, null);
Staff staff = new Staff("Staff of Power", 10);
var lightStaff = new LightWeapon(staff);
var blessedStaff = new BlessedWeapon(lightStaff);
mage.Weapon = blessedStaff;
Console.WriteLine(mage.Weapon.Attack());
Orb orb = new Orb("Orb of Destruction", "Spawns kittens", TimeSpan.FromDays(1), 10, 10);
var legendaryOrb = new LegendaryArtifact(orb);
var ancientOrb = new AncientArtifact(legendaryOrb);
var holyOrb = new HolyArtifact(ancientOrb);
mage.Artifacts.Add(holyOrb);
Console.WriteLine(mage.Artifacts.First().Use());

Warrior warrior = new Warrior("Conan", 100, 10, 100, null);
Sword sword = new Sword("Sword of Might", 20);
var HeavySword = new HeavyWeapon(sword);
var cursedSword = new CursedWeapon(HeavySword);
warrior.Weapon = cursedSword;
Console.WriteLine(warrior.Weapon.Attack());
Cloak cloak = new Cloak("Cloak of Shadows", "Makes you invisible", TimeSpan.FromDays(1), 10, "Green");
var shadowCloak = new ShadowArtifact(cloak);
var legendaryCloak = new LegendaryArtifact(shadowCloak);
warrior.Artifacts.Add(legendaryCloak);
Console.WriteLine(warrior.Artifacts.First().Use());

Paladin paladin = new Paladin("Arthur", 100, 7, 100, null);
var hammer = new Hammer("Hammer of Justice");
var holyHammer = new BlessedWeapon(hammer);
var heavyHammer = new HeavyWeapon(holyHammer);
paladin.Weapon = heavyHammer;
Console.WriteLine(paladin.Weapon.Attack());
var amulet = new Amulet("Amulet of Protection", "Protects you from harm", TimeSpan.FromDays(1), 10, "Silver");
var holyAmulet = new HolyArtifact(amulet);
var legendaryAmulet = new LegendaryArtifact(holyAmulet);
paladin.Artifacts.Add(legendaryAmulet);
Console.WriteLine(paladin.Artifacts.First().Use());