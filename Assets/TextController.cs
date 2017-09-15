using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	public Text text;
	
	private enum States {
						start,
						cell, 
						paper_0,
						walkie, 
						lock_0, 
						walkie_helper, 
						paper_1, 
						lock_1, 
						freedom, 
						corridor_0, 
						stairup_0,
						stairdown_0,
						door_0,
						run_0,
						fight_0,
						pretend_0,
						evade_0,
						counterAttack_0,
						flee,
						chair,
						punch,
						kick,
						keys,
						door_1,
						stairup_1,
						stairdown_1,
						weaponsRoom,
						door_2,
						shoot,
						OpenSpace,
						Free,
						caged,
						goBack
						};
	private States myState;
	private enum Tools {none, masterKey, eletricGun};
	private Tools myTool;
	private enum Languages {english, portugues, francais}
	private Languages myLanguage;	
	// Use this for initialization
	void Start () {
		myState = States.start;
	}
	
	// Update is called once per frame
	void Update () {
		switch(myState) {
			case States.start:
				state_start();
				break;
			case States.cell:
				state_cell();
				break;
			case States.paper_0:
				state_paper_0();
				break;
			case States.walkie:
				state_walkie();
				break;
			case States.lock_0:
				state_lock_0();
				break;
			case States.walkie_helper:
				state_walkie_helper();
				break;
			case States.paper_1:
				state_paper_1();
				break;
			case States.lock_1:
				state_lock_1();
				break;
			case States.freedom:
				state_freedom();
				break;
			case States.corridor_0:
				corridor_0();
				break;
			case States.stairup_0:
				stairup_0();
				break;
			case States.door_0:
				door_0();
				break;
			case States.stairdown_0:
				stairdown_0();
				break;
			case States.run_0:
				run_0();
				break;
			case States.fight_0:
				fight_0();
				break;
			case States.pretend_0:
				pretend_0();
				break;
			case States.evade_0:
				evade_0();
				break;
			case States.counterAttack_0:
				counter_0();
				break;
			case States.flee:
				flee_0();
				break;
			case States.chair:
				chair();
				break;
			case States.punch:
				punch();
				break;
			case States.kick:
				kick();
				break;
			case States.door_1:
				door_1();
				break;
			case States.stairup_1:
				stairup_1();
				break;
			case States.stairdown_1:
				stairdown_1();
				break;
			case States.weaponsRoom:
				weaponsRoom();
				break;
			case States.OpenSpace:
				openSpace();
				break;
			case States.shoot:
				shoot();
				break;
			case States.Free:
				free();
				break;
			case States.caged:
				caged();
				break;
			case States.door_2:
				door_2();
				break;
			case States.goBack:
				goBack();
				break;
		}
	}
	
	void state_start () {
		switch(myLanguage){
			case Languages.english:
				text.text = "This is the prison game! Choose your language or press C to continue.\n\n" + 
							"Press E to english, P para portugues, F pour francais";
				break;
			case Languages.francais:
				text.text = "Voici le jeux de la prison! Choissisez votre langue ou cliquez sur C pour continuer.\n\n" +
							"Press E to english, P para portugues, F pour francais";
				break;
			case Languages.portugues:
				text.text = "Este e o jogo da prisao! Escolha seu idioma ou aperte C para continuar.\n\n" +
							"Press E to english, P para portugues, F pour francais";
				break;
		}
		if (Input.GetKeyDown(KeyCode.E)) {
			myLanguage = Languages.english;
		} else if (Input.GetKeyDown(KeyCode.P)) {
			myLanguage = Languages.portugues;
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myLanguage = Languages.francais;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.cell;
		}
	}

	void state_cell () {
		switch(myLanguage) {
			case Languages.english:
				text.text = "You are locked on a prison cell. You want to scape, but to achieve that you'll" + 
							" need to go through some challenges and you'll need to discover the right way out." + 
							" You can see an walkie-talkie, a bed where you're at and the door is closed" + 
							" and locked. There is also a little piece of paper with a pen next to the door.\n\n" + 
							"Press W to use the walkie-talkie, P to see the paper or L to view door lock";
				break;
			case Languages.portugues:
				text.text = "Voce esta trancado em uma cela. Voce precisa escapar, mas pra conseguir isso" + 
							" voce precisara passar por alguns desafios e voce vai precisar descobrir a forma" + 
							" correta de escapar. Voce ve um walkie-talkie, a cama onde voce esta e a porta da cela" + 
							" esta fechada e trancada. Voce ve tambem uma folha de papel e uma caneta perto da porta.\n\n" + 
							"Aperte W pra usar o walkie-talkie, P pra ver o papel ou L pra olhar pela fechadura";				
				break;
			case Languages.francais:
				text.text = "Vous etes dans une cellule de prison. Vous voulez s'echapper, mais pour reussir vous devez" + 
							" passer pour quelques defis et aussi decouvrir la correcte maniere de s'echapper." + 
							" Vou voyez un walkie-talkie, le lit ou vos etes et la porte de la chambre est ferme" + 
							" et lockee. Vous voyez aussi une feuille de papier et un stylo tout proche de la porte.\n" + 
							"Cliquez sur W pour utiliser le walkie-talkie, P pour voir le papier ou L pour regarder la fermeture de la porte.";				
				break;
		}
		if (Input.GetKeyDown(KeyCode.P)) {
			myState = States.paper_0;
		} else if (Input.GetKeyDown(KeyCode.W)) {
			myState = States.walkie;
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_0;
		}
	}
	
	void state_paper_0 () {
		switch(myLanguage) {
			case Languages.english:
				text.text = "Not quite a pleasant place to sleep, don't you think?" + 
							" It seems like you've been caught by mistake. Anyway," + 
							" nobody believes you're that innocent! You need to figure" + 
							" out how to scape and proove you're inocent. Hurry up!\n\n" +
							"Press R to return to your cell";
				break;
			case Languages.francais:
				text.text = "Ce n'est pas un emplacement tres cool pour dormir, n'est-ce pas?" + 
							" Apparament vous aviez ete pris par erreur. De toute facon," + 
							" personne ne crois pas a votre inocence! Vous avez besoin de decouvrir" + 
							" une maniere de s'echapper et prouver que vous etes inocent. Depeche toi!\n\n" +
							"Cliquez sur le R pour retourner a votre cellule";
				break;
			case Languages.portugues:
				text.text = "Esse nao e um lugar muito bom pra dormir, nao e?" + 
							" Aparentemente voce foi preso por engano. De qualquer forma," + 
							" ninguem parece acreditar que voce e inocente! Voce precisa descobrir" + 
							" uma maneira de escapar e provar que voce e inocente. Corra, corra!\n\n" +
							"Aperte R pra retornar pra sua cela";
				break;
		}
					
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		}
	}
	
	void state_walkie () {
		text.text = "You get the walkie-talkie and hear that it is working fine.\n\n" +
					"Press T to talk or R to return to your cell";
		
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		} else if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.walkie_helper;
		}
	}
	
	void state_lock_0 () {
		text.text = "You look through the lock, but for some reason you can't see anything." +
					" It looks like there is something on the lock.\n\n" +
					"Press R to return to your cell";
		
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		}
	}
		
	void state_walkie_helper () {
		text.text = "Yeah, the walkie-talkie is really working. That's great! It's too" + 
					" risky but you have no choice but to try it: \"Anybody copy?\"" + 
					" Imediately you hear a voice that tells you that the key is on the" + 
					" outside of the door and you can use the piece of paper and pen to get it.\n\n" +
					"Which one you'll use first? Press P to get the paper or L to use the pen on the lock";
		
		if (Input.GetKeyDown(KeyCode.P)) {
			myState = States.paper_1;
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_1;
		}
	}
	
	void state_lock_1 () {
		text.text = "You get the pen and goes to the door to try to get the key." +
					" While you walk, you receive a call from the walkie-talkie." +
					" You hear the person in the other side say: Do not let the" +
					" key to fall before putting something on the ground to get it!\n\n" +
					"Press R to return to your mission";
		
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.walkie_helper;
		}
	}
	
	void state_paper_1 () {
		text.text = "Now you got it right! You put the paper down the door and then uses" +
					" the pen to push the key on the locker. The key falls right over" +
					" the paper so you can get it to finally open the door and be free!" +
					" Well.... that's what you thought...!\n\n" +
					"Press U to unlock the door";
		
		if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.freedom;
		}
	}
	
	void state_freedom () {
		text.text = "You open the door and now you're out of your cell. You still need to" +
					" scape from the prison. It will not be easy, but you realized you" +
					" have a hidden friend: the person on the walkie-talkie. You return to the cell" +
					" and get the walkie-talkie to continue your scape!\n\n" +
					"Press C to continue";
		
		if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.corridor_0;
		}
	}
	
	void corridor_0 () {
		text.text = "You find yourself now in a corridor and behind you, there is an upstairs" +
					" and a downstairs. In front of you, there is an open door to a room.\n\n" +
					"Press U to go upstairs, D to go downstairs and E to enter the open door";

		if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.stairup_0;
				} else if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairdown_0;
				} else if (Input.GetKeyDown(KeyCode.E)) {
			myState = States.door_0;
				}
	}

	void stairup_0 () {
		text.text = "You walk upstairs and you see a locked door on the top of the stair." +
					" You get closer and then you can hear voices on the other side. It seems" +
					" like some cops are having a happy conversation. You stay silent and goes" +
					" back to the corridor on the under floor.\n\n" +
					"Press C to continue";
		
		if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.corridor_0;
		}
	}

	void stairdown_0 () {
		text.text = "you decide to go down the stairs. There are no locked doors here," +
					" but you realize that this place is only where the solitaries are" +
					" placed. Everything is silent, and you can hear only the rats running" +
					" from side to side. \n\n" +
					"Press B to get up to the corridor again";
		
		if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.corridor_0;
		}
	}

	void door_0 () {
		text.text = "You look carefully through the door. Unfortunatelly there is a cop" +
					" sitting on a chair. He's kind of sleepy and do not nottest you're around." +
					" As a very bad luck, you let your foot to touch something on the ground, and the" +
					" noise calls the attention of the cop. He sees you!\n\n" +
					"Press R to run, F to fight or P to pretend you're there for a reason";
		
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.run_0;
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.fight_0;
		} else if (Input.GetKeyDown(KeyCode.P)) {
			myState = States.pretend_0;
		}

	}

	void run_0 () {
		text.text = "You try to run as fast as possible. But then you remember that there is nowhere" +
					" to go! Your only chance now is to try to fight with the cop. Prepare yourself" +
					" because he's coming, and he is furious!\n\n" +
					"Press F to fight";
		
		if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.fight_0;
		}
	}

	void fight_0 () {
		text.text = "The cop comes straight to you, with a club in his hands. You must think really" +
					" fast before he get's to you. If you do not act, he'll hit you with all he have." +
					" Dont waste time. Act!\n\n" +
					"Press E to evade, C to counter-attack or F to flee";
		
		if (Input.GetKeyDown(KeyCode.E)) {
			myState = States.evade_0;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.counterAttack_0;
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.flee;
		}
	}

	void pretend_0 () {
		text.text = "You bound a little bit showing respect. The cop do not understand why" +
					" you're there. Then he asks you: \"What are you doing here?\". You tell him" +
					" that another cop sent you a message. He's not satisfied and want to know what's" +
					" the message and who sent it. You are in a dead-end. So... fight your way out!\n\n" +
					"Press F to fight with the cop or, if you're really weak, press S to surrender";
		
		if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.fight_0;
		} else if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.caged;
		}
	}

	void evade_0 () {
		text.text = "The cop attacks you and then you evade on the last moment. The cop falls on the" +
					" ground with the force of his arms. You have to act fast!\n\n" +
					"Press C to get the chair on the cop's room, P to punch him or K ro kick him";
		
		if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.chair;
		} else if (Input.GetKeyDown(KeyCode.P)) {
			myState = States.punch;
		} else if (Input.GetKeyDown(KeyCode.K)) {
			myState = States.kick;
		}
	}

	void counter_0 () {
		text.text = "That's the spirit! You'll fight back! You don't think twice. You want to get" +
					" out of this place. You push him with the weight of your body and runs to get" +
					" the chair he was sitting before. \n\n" +
					"Press C to hit him with the chair!";
		
		if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.chair;
		}
	}

	void flee_0 () {
		text.text = "You are so afraid that even knowing that there are no exits you try to flee." +
					" The cop runs after you and hits his club on your head and you black-out.\n\n" +
					"Press C to continue";
		
		if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.caged;
		}
	}

	void chair () {
		text.text = "You hit the cop with the chair and he's knocked-out. There's a not locked door" +
					" on the cop's room. Attached to the cop there's a group of keys.\n\n" +
					"Press D to go through the door or K to get the key";
		
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.door_1;
		} else if (Input.GetKeyDown(KeyCode.K)) {
			myTool = Tools.masterKey;
			myState = States.door_1;
		}
	}

	void punch () {
		text.text = "You hit the cop on the face. He falls but you realize he's too strong" +
					" to be knocked-out by a single punch of yours. You need to knock him out!\n\n" +
					"Press C to get the chair from his room and hit him";
		
		if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.chair;
		}
	}

	void kick () {
			text.text = "You hit the cop with a strong kick! He retreats a little but you realize he's too" +
						" strong to be knocked-out by a single kick of yours. You need to knock him out!\n\n" +
						"Press C to get the chair from his room and hit him";
		
		if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.chair;
		}
	}

	void door_1 () {
		text.text = "Outside this door there are two stair, the same way you saw before. One goes up and the" +
					" other goes down.\n\n" +
					"Press U to go up or D to go down";
		
		if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.stairup_1;
		} else if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairdown_1;
		}
	}

	void stairup_1 () {
		if (myTool == Tools.masterKey) {
			text.text = "You use the keys you got from the cop's room to open a big locked door" +
						" you find upstairs. You cannot believe your eyes when you see the weapons room!\n\n" +
						"Press C to continue";

			if (Input.GetKeyDown(KeyCode.C)) {
				myState = States.weaponsRoom;
			}
			
		} else {
			text.text = "You see a big door but it is locked! You should have tried to get the keys from the cop!" +
						" Now you need to go back there, and maybe the cop is already awaken...\n\n" +
						"Press C to go back to get the keys";

			if (Input.GetKeyDown(KeyCode.C)) {
				myState = States.door_2;
			}
		}
	}

	void stairdown_1 () {
				text.text = "Damn! You're back to the solitary downstairs. \n\n" +
							"Press C to continue upstairs";
		
		if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.stairup_1;
		}
	}

	void door_2 () {
			text.text = "You look carefully through the door. Unfortunatelly the cop is awaken again.\n\n" +
						"Press R to run, F to fight or P to pretend you're there for a reason";
		
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.run_0;
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.fight_0;
		} else if (Input.GetKeyDown(KeyCode.P)) {
			myState = States.pretend_0;
		}

	}

	void weaponsRoom () {
		text.text = "There are lots of guns there. But you have no acces to them. There are gates that only" +
					" can be opened by a card. The only thing you see is an electric gun that was forgotten" +
					" by someone. And for your surprise, there's another door with a small window on it. From there" +
					" you can see the outside of the place. The door is locked.\n\n" +
					"Press G to get the gun and leave or D to leave without it.";
		
		if (Input.GetKeyDown(KeyCode.G)) {
			myState = States.OpenSpace;
			myTool = Tools.eletricGun;
		} else if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.OpenSpace;
		}
	}

	void openSpace () {
		if (myTool == Tools.eletricGun) {
			text.text = "You leave the weapons room to the outside. Now you are in an open space and only some steps from" +
						" the gate to the outside of the prison. The problem: some cops are on guard on the way!" +
						" You will need to fight your way out. Go on!\n\n" +
						"Press C to continue";

			if (Input.GetKeyDown(KeyCode.C)) {
				myState = States.shoot;
			}
		} else {
			text.text = "You leave the weapons room to the outside. Now you are in an open space and only some steps from" +
						" the gate to the outside of the prison. The problem: some cops are on guard on the way!" +
						" They see you and you have no guns to use! \n\n" +
						"Press C to continue";			

			if (Input.GetKeyDown(KeyCode.C)) {
				myState = States.caged;
			}
		}
	}

	void shoot () {
		text.text = "You go straight to the gate that leads to the outside. You use your electric gun agains everyone" +
					" on the way. The cops have no time to react. You reach the gate very fast, and the other cops are" +
					" still to far to reach you before you disappear on the forest that lies outside the prison. But" +
					" the gate is locked, and it's unlocked with the use of a card. \n\n" +
					"Press B to find a card or G to use the electric gun on the lock";
		
		if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.goBack;
			} else if (Input.GetKeyDown(KeyCode.G)) {
			myState = States.Free;
			}
	}

	void free () {
		text.text = "You finally leave the prison! No one can reach you now, and you're free!\n\n" +
					"Press R to restart the game";
		
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
			myTool = Tools.none;
		}
	}

	void goBack () {
		text.text = "You return to the cops to try to find a card to open the gate. You search the first... nothing!" +
					" You search the second, third and forth... nothing. On the fifth one you find the card you need." +
					" When you return to the gate, a dozen cops are waiting for you...\n\n" +
					"Press C to continue";
		
		if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.caged;
		}
	}

	void caged () {
		text.text = "There is you again... locked on a cage!\n\n" +
					"Press C to continue";
		
		if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.cell;
			myTool = Tools.none;
		}
	}
}