using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class locale : MonoBehaviour {

	enum SUPPORTEDLANGUAGES {
		ENGLISH=0,
		SPANISH=1,
		CHINESE=2,
		JAPANESE=3,
		KOREAN=4,
		FINNISH=5
	}

	static Dictionary<string, string[]> gameTexts;
	static SUPPORTEDLANGUAGES currentLanguage;

	void Awake() {
		currentLanguage=SUPPORTEDLANGUAGES.FINNISH;
		gameTexts=new Dictionary<string, string[]>();
		gameTexts.Add( "hunt",new string[] {
				"Hunt",
				"Hunt",
				"Hunt",
				"狩る",
				"Hunt",
				"Metsästä"
			} );
		gameTexts.Add( "exit",new string[] {
				"Exit",
				"Exit",
				"Exit",
				"Exit",
				"Exit",
				"Poistu"
			} );
		gameTexts.Add( 
			"encounter",
			new string[] {
				"You encounter",
				"You encounter",
				"You encounter",
				"You encounter",
				"You encounter",
				"Vastaasi tulee"
			} );
		gameTexts.Add( "win",new string[] {
				"Victory",
				"Victory",
				"Victory",
				"Victory",
				"Victory",
				"Voitto"
			} );
		gameTexts.Add( "lose",new string[] {
				"Defeat",
				"Defeat",
				"Defeat",
				"Defeat",
				"Defeat",
				"Tappio"
			} );
		gameTexts.Add( "wolf",new string[] {
				"Wolf",
				"Wolf",
				"Wolf",
				"Wolf",
				"Wolf",
				"Susi"
			} );
		gameTexts.Add( "bat",new string[] {
				"Bat",
				"Bat",
				"Bat",
				"Bat",
				"Bat",
				"Lepakko"
			} );
		gameTexts.Add( "rat",new string[] {
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Rotta"
			} );
		gameTexts.Add( "basilisk",new string[] {
				"Basilisk",
				"Wolf",
				"Wolf",
				"Wolf",
				"Wolf",
				"Basiliski"
			} );
		gameTexts.Add( "bear",new string[] {
				"Bear",
				"Bat",
				"Bat",
				"Bat",
				"Bat",
				"Karhu"
			} );
		gameTexts.Add( "bird",new string[] {
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Rotta"
			} );
		gameTexts.Add( "boar",new string[] {
				"Boar",
				"Wolf",
				"Wolf",
				"Wolf",
				"Wolf",
				"Villisika"
			} );
		gameTexts.Add( "boneray",new string[] {
				"Boneray",
				"Bat",
				"Bat",
				"Bat",
				"Bat",
				"Luukala"
			} );
		gameTexts.Add( "clam",new string[] {
				"Clam",
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Simpukka"
			} );
		gameTexts.Add( "croc",new string[] {
				"Croc",
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Krokotiili"
			} );
		gameTexts.Add( "crub",new string[] {
				"Carrion Crub",
				"Wolf",
				"Wolf",
				"Wolf",
				"Wolf",
				"Jättiäistoukka"
			} );
		gameTexts.Add( "demon",new string[] {
				"Demon",
				"Bat",
				"Bat",
				"Bat",
				"Bat",
				"Demoni"
			} );
		gameTexts.Add( "demonbear",new string[] {
				"Demon Bear",
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Paholaiskarhu"
			} );
		gameTexts.Add( "demonboar",new string[] {
				"Demon Boar",
				"Wolf",
				"Wolf",
				"Wolf",
				"Wolf",
				"Paholaissika"
			} );
		gameTexts.Add( "demonbull",new string[] {
				"Demon Bull",
				"Bat",
				"Bat",
				"Bat",
				"Bat",
				"Paholaishärkä"
			} );
		gameTexts.Add( "demonfrog",new string[] {
				"Demon Frog",
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Paholaissammakko"
			} );
		gameTexts.Add( "demonspider",new string[] {
				"Demon Spider",
				"Wolf",
				"Wolf",
				"Wolf",
				"Wolf",
				"Paholaishämähäkki"
			} );
		gameTexts.Add( "demonwolf",new string[] {
				"Demon Wolf",
				"Bat",
				"Bat",
				"Bat",
				"Bat",
				"Paholaissusi"
			} );
		gameTexts.Add( "demonshark",new string[] {
				"Demon Shark",
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Paholaishai"
			} );
		gameTexts.Add( "devilsaur",new string[] {
				"Devilsaur",
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Paholaissauri"
			} );
		gameTexts.Add( "elephant",new string[] {
				"Elephant",
				"Wolf",
				"Wolf",
				"Wolf",
				"Wolf",
				"Elefantti"
			} );
		gameTexts.Add( "firedragon",new string[] {
				"Fire Dragon",
				"Bat",
				"Bat",
				"Bat",
				"Bat",
				"Tulilohikäärme"
			} );
		gameTexts.Add( "fishman",new string[] {
				"Fishman",
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Kalamies"
			} );
		gameTexts.Add( "forestdragon",new string[] {
				"Forest Dragon",
				"Wolf",
				"Wolf",
				"Wolf",
				"Wolf",
				"Metsälohikäärme"
			} );
		gameTexts.Add( "gargoyle",new string[] {
				"Gargoyle",
				"Bat",
				"Bat",
				"Bat",
				"Bat",
				"Gargolli"
			} );
		gameTexts.Add( "gator",new string[] {
				"Gator",
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Alligaattori"
			} );
		gameTexts.Add( "ghostship",new string[] {
				"Ghostship",
				"Wolf",
				"Wolf",
				"Wolf",
				"Wolf",
				"Aavelaiva"
			} );
		gameTexts.Add( "ghoul",new string[] {
				"Ghoul",
				"Bat",
				"Bat",
				"Bat",
				"Bat",
				"Haahuilija"
			} );
		gameTexts.Add( "golem",new string[] {
				"Golem",
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Golemi"
			} );
		gameTexts.Add( "grasshopper",new string[] {
				"Grasshopper",
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Heinäsirkka"
			} );
		gameTexts.Add( "graver",new string[] {
				"Graver",
				"Wolf",
				"Wolf",
				"Wolf",
				"Wolf",
				"Haudankaivaja"
			} );
		gameTexts.Add( "griffon",new string[] {
				"Griffon",
				"Bat",
				"Bat",
				"Bat",
				"Bat",
				"Aarnikotka"
			} );
		gameTexts.Add( "harpy",new string[] {
				"Harpy",
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Harpyija"
			} );
		gameTexts.Add( "jellyfish",new string[] {
				"Jellyfish",
				"Wolf",
				"Wolf",
				"Wolf",
				"Wolf",
				"Meduusa"
			} );
		gameTexts.Add( "jester",new string[] {
				"Jester",
				"Bat",
				"Bat",
				"Bat",
				"Bat",
				"Narri"
			} );
		gameTexts.Add( "maggot",new string[] {
				"Maggot",
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Toukka"
			} );
		gameTexts.Add( "medusa",new string[] {
				"Medusa",
				"Wolf",
				"Wolf",
				"Wolf",
				"Wolf",
				"Meduusa"
			} );
		gameTexts.Add( "miniman",new string[] {
				"Miniman",
				"Bat",
				"Bat",
				"Bat",
				"Bat",
				"Minimies"
			} );
		gameTexts.Add( "molerat",new string[] {
				"Molerat",
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Myyrä"
			} );
		gameTexts.Add( "naga",new string[] {
				"Naga",
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Naga"
			} );
		gameTexts.Add( "ogre",new string[] {
				"Ogre",
				"Wolf",
				"Wolf",
				"Wolf",
				"Wolf",
				"Jätti"
			} );
		gameTexts.Add( "peacock",new string[] {
				"Peacock",
				"Bat",
				"Bat",
				"Bat",
				"Bat",
				"Riikinkukko"
			} );
		gameTexts.Add( "phoenix",new string[] {
				"Phoenix",
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Feenix"
			} );
		gameTexts.Add( "scorpion",new string[] {
				"Scorpion",
				"Wolf",
				"Wolf",
				"Wolf",
				"Wolf",
				"Skorpiooni"
			} );
		gameTexts.Add( "shark",new string[] {
				"Shark",
				"Bat",
				"Bat",
				"Bat",
				"Bat",
				"Hai"
			} );
		gameTexts.Add( "skullray",new string[] {
				"Skullray",
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Kallokala"
			} );
		gameTexts.Add( "snake",new string[] {
				"Snake",
				"Wolf",
				"Wolf",
				"Wolf",
				"Wolf",
				"Käärme"
			} );
		gameTexts.Add( "spider",new string[] {
				"Spider",
				"Bat",
				"Bat",
				"Bat",
				"Bat",
				"Hämähäkki"
			} );
		gameTexts.Add( "spiderqueen",new string[] {
				"Spider Queen",
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Hämähäkkikuningatar"
			} );
		gameTexts.Add( "spirit",new string[] {
				"Spirit",
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Henki"
			} );
		gameTexts.Add( "spiritship",new string[] {
				"Spirit Ship",
				"Wolf",
				"Wolf",
				"Wolf",
				"Wolf",
				"Haamulaiva"
			} );
		gameTexts.Add( "stingray",new string[] {
				"Stingray",
				"Bat",
				"Bat",
				"Bat",
				"Bat",
				"Manta"
			} );
		gameTexts.Add( "tortoise",new string[] {
				"Tortoise",
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Kilpikonna"
			} );
		gameTexts.Add( "troll",new string[] {
				"Troll",
				"Wolf",
				"Wolf",
				"Wolf",
				"Wolf",
				"Trolli"
			} );
		gameTexts.Add( "warlock",new string[] {
				"Warlock",
				"Bat",
				"Bat",
				"Bat",
				"Bat",
				"Velho"
			} );
		gameTexts.Add( "werebat",new string[] {
				"Werebat",
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Ihmislepakko"
			} );
		gameTexts.Add( "werewolf",new string[] {
				"Werewolf",
				"Wolf",
				"Wolf",
				"Wolf",
				"Wolf",
				"Ihmissusi"
			} );
		gameTexts.Add( "witch",new string[] {
				"Witch",
				"Bat",
				"Bat",
				"Bat",
				"Bat",
				"Noita"
			} );
		gameTexts.Add( "worm",new string[] {
				"Worm",
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Mato"
			} );
		gameTexts.Add( "zombie",new string[] {
				"Zombie",
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Zombi"
			} );
		gameTexts.Add( "toad",new string[] {
				"Toad",
				"Rat",
				"Rat",
				"Rat",
				"Rat",
				"Sammakko"
			} );
	}

	public static string getLocalizedText( string originalText ) {
		if( !gameTexts.ContainsKey( originalText ) )
			return "UNKNOWN";

		return gameTexts[ originalText ][ ( int )currentLanguage ];
	}
}
