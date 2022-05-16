#The Great Quest Program
#This program is an interactive quest that allows users to discover treasure
#Programmer: Emmaleigh Stone
#Date: 12/6/21

#import the randomizer needed for lucky number variable
import random

#set the lucky number variable
LuckyNumber = random.randint(1, 5)

#Welcome the user
print("\tWelcome to the Great Quest, where you shall find either great treasure or great sorrow.")

#Ask for the user's character name
CharacterName = str(input("\nAnd what shall I call you, quester? "))

#State the user's character name and lucky number
print("\nWell, " + str(CharacterName) + ", your lucky number is " + str(LuckyNumber) + ", so keep that in mind for later!")

#Prompt user to begin quest
input("\nPress Enter when you are ready to begin your quest.")

#Begin describing what the user sees in each direction
print("\nYou are standing at the fork of a path, a chill nipping the back of your neck and a twig snapping under your feet.")
print("The path you are on branches off towards the east, where you can see a glittering city full of bustling people,")
print("and to the west, where you can just faintly hear the sound of a babbling brook that is somehow still flowing despite the cold winter.")
print("However, to the north, into the forest, you can make out a crumbling structure that might have once been a mighty castle maybe an hour's journey away.")
print("Behind you, to the south, is the dreary pub in which you left, hoping to seek an adventure in great unknown, that is willing to offer both warmth and solace.")

#Ask which direction the user wants to go in
Direction = str(input("North, South, East, or West: which way will you go? "))

#Validate the user's direction
while Direction != "North" and Direction != "N" and Direction != "South" and Direction != "S" and Direction != "East" and Direction != "E" and Direction != "West" and Direction != "W":
    print("I'm sorry, you didn't enter a valid direction for which to begin your quest.")
    Direction = str(input("Please choose a direction - North, South, East, or West, to go. "))


#Describe what happens when the user goes north
if Direction == "North" or Direction == "N":
    print("\nAfter stumbling through the woods near blindly, naked trees offering little in the way of comfort, skylight slowly fading as the Giant Light took its leave, you come upon the castle.")
    print("When you reach its decaying door, you knock once - to be polite of course - but understandably receive no answer.")
    print("Satisfied in being alone, you push inside the deteriorating foyer and look around.")
    print("Full of cobwebs, and smelling heavily of mold, you see nothing truly exciting about the castle.")
    print("You only know that a rat scampers on the ground in front of you when you hear a clang as it races away.")
    print("You walk over to where you heard the sound, guiding your way with one hand on a dusty, rock wall, before leaning down and gingerly running your hand across the spaces near your feet.")
    print("When you fingers brush against cool metal, you can hardly believe your luck.")
    print("You race out into the moonlight to examine your treasure.")

#Prompt user to see their treasure in the north
    input("\nPress Enter to study your treasure.")

#Show and describe their treasure in the north
    print("\tThe Three-Starred Chalice")
    print(" _________")
    print("(         )")
    print(" \   *   /")
    print("  \  *  /")
    print("   \ * /")
    print("    | |")
    print("   /___\ ")
    print("\nThought to be long gone, the Three-Starred Chalice belonged to the Ranchor monarchy many moons ago. Won in battle, a was highly regarded as a beacon, drawing in powerful conquers.")
    print("It hasn't been seen since the last of the Ranchors died of the Terrible Sickness, and it was thought to have travelled with him to the afterlife.")
    print("You can't contain your grin as you rub a thumb into the chiseled stars, wondering where you might go from here.")
    
#Describe what happens when the user goes south
if Direction == "South" or Direction == "S":
    print("\nNever one for being brave, you turn your back from the unexplored and return to old habits.")
    print("Your stool is still warm from where you sat all afternoon, and you place your arms across the bar, sinking into their protection.")
    print("With your head ducked down, you can't see the barmaid stare at you, not in surprise, but in disappointment, as she slides a glass of mead across the counter.")
    print("When the sweaty glass jars your elbow, you glance up and flush in embarrassment. On the plate beside you, there is a dish every patron of the Red Hook's Pub is familiar with.")

#Prompt user to see their treasure in the south
    input("\nPress Enter to study your treasure.")

#Show and describe their treasure in the south
    print("\tThe Pea Plate of Despair")
    print(" _______________  ")
    print("|   ^       ^   | ")
    print("|   0       0   | ")
    print("|      ooo      |")
    print("|    o    o     |")
    print("|   o      o    |")
    print("|_______________|")
    print("\nA long-standing tradition at the eatery, every person who comes in looking miserable is treated to a plate with seven peas, two small potatoes, and two green beans formed in a frowny face.")
    print("While the premise might not necessarily be to mock, you still feel flustered and disheartened as you eat your overcooked veggies in sullen silence, trying not to picture if you'll be stuck here forever.")

#Describe what happens when the user goes east
if Direction == "East" or Direction == "E":
    print("\nThe city isn't too far, and you acknowledge that you've made good time as you pass through the city gates.")
    print("You hear people passing by discussing a market, and you follow in their footsteps as you observe them.")
    print("The people have bright colored frocks and jewels in their hair that boast of wealth and frivolity.")
    print("Their steps are light and unhurried, and they seem to have never wanted in their entire life for entertainment.")
    print("Once you step in the town square, you can smell the fresh fruits and rich linens lining the street.")
    print("You slow your stride, taking in all the wonders around you, before finally stopping at a modest woodworking stall with an old, crotchety man inside.")
    print("His designs, while simple, are beautiful, and you know in that instant you would do anything to have one.")
    print("After assuring him you can handle the payment, he begins to craft for you something he says you cannot see until it's done.")
    print("He keeps his word despite your attempts, going so far as to shoo you away from his spot when you attempt to peek one too many times.")
    print("When he finally calls you back, his face both haggard and annoyed as he hands you your purchase.")

#Prompt user to see their treasure in the east
    input("\nPress Enter to study your treasure.")

#Show and describe their treasure in the east
    print("\tThe Plaque of the Prideful")
    print(" _______________  ")
    print("/               \ ")
    print("|               |")
    print(str(CharacterName))
    print("|               |")
    print("\_______________/")
    print("Upon laying eyes on the plaque, you feign a smile as dissatisfaction floods you. The woodworker's shelves are filled with magnificent and meticulous figurines.")
    print("Each object on display drew your attention: the steady battle horse, waiting for his rider; a siren whose tail hides half her face mischievously; a merry chipmunk with full cheeks.")
    print("You, though, you have gotten a measly plaque with your name across it, looking both rushed and crude, and you wonder what you did to offend the artist.")
    print("Nevertheless, the man did a job, so you pay him and head on your way. You quickly race to make it out of the city before nightfall. This place, while pretty, has nothing more to give you.")
    print("You hope your next stop on your journey is more pleasurable than this.")

#Describe what happens when the user goes west
if Direction == "West" or Direction == "W":
    print("\nThe closer you get to the brook, the chillier the air feels, as if the water is not only on the ground, but clinging to the air around you.")
    print("Your eyes scan the meadow, keeping watch for anything that might mean danger, while wishing you had brought some sort of snack on this ill-thought-out adventure.")
    print("You haven't seen any berries since you made the decision to go west, but your hoping that quenching your thirst with a drink from the running water will tide you over.")
    print("When you finally reach the body of water, it is less of a brook and more of a spring: small, but with a quick current that could definitely make trouble for some small woodland creatures.")
    print("You squat down by water's edge and cup your fingers together in a makeshift bowl.")
    print("You are so thirsty, taking greedy gulps of the fresh, freezing liquid, it takes you a few minutes before you recognize something shimmering an arm's length away.")
    print("You make peace with the fact that your entire arm will now be an icicle before rolling up your sleeve and plunging your hand below the water's surface, grasping onto the shiny object swiftly.")
    print("The edges are sharper than you imagined, and you cut the pad of your fingertip against the thing.")

#Prompt user to see their treasure in the west
    input("\nPress Enter to study your treasure.")

#Show and describe their treasure in the west
    print("\tThe Glittering Gem")
    print("    /\ ")
    print("   / +\ ")
    print("  /+   \ ")
    print("  \  + /")
    print("   \+ /")
    print("    \/")
    print("It becomes clear as you turn the rock over in your hand that it is some sort of diamond or jewel, nearly crystal clear with a slight blush tint to it.")
    print("You imagine what life it has lived to end up where it did: maybe a witch used it in hex gone wrong and ended up cursing herself;")
    print("maybe a man wanted to propose to a woman but then lost his nerve; or maybe a kid played with their grandmother's brooch and lost it trying to see if it would skip across the surface of the spring.")
    print("You suppose when it comes down to it, it doesn't truly matter. All that matters is this pretty gem is now yours to do with as you wish.")
    print("You tear off a piece of your cloak to wrap the stone in and store it safely in your bag.")
    print("You pray to the gods that this gift will be prophetic of glad tidings for the rest of your quest.")

#Tell user how the rest of their quest will be based off their lucky number
print("\nNow, " + str(CharacterName) + ", with your lucky number, I can now predict how the rest of your quest will go.")

#Prompt user to reveal their quest's ending
input("\nPress Enter to reveal how your quest ends.")

#Dedicate lucky numbers to different endings
if LuckyNumber == 1:
    print("\nBecause your lucky number is " + str(LuckyNumber) + ", your quest ends with you chock-full of riches and stories but always insatiable with the need to keep searching for more.")
if LuckyNumber == 2:
    print("\nBecause your lucky number is " + str(LuckyNumber) + ", your quest ends with you alone, in the cold, shivering and unable to walk another step.")
if LuckyNumber == 3:
    print("\nBecause your lucky number is " + str(LuckyNumber) + ", your quest ends with you meeting the best partner you could ever have in life that stays with you until you breathe your last breath.")
if LuckyNumber == 4:
    print("\nBecause your lucky number is " + str(LuckyNumber) + ", your quest ends with you back where you started, at the fork in the path, wondering if you've made any progress at all.")
if LuckyNumber == 5:
    print("\nBecause your lucky number is " + str(LuckyNumber) + ", your quest ends with you feeling full, warm, and satisfied with both your travels and with yourself.")

#Say goodbye to the user
print("\nGoodbye, fair " + str(CharacterName) + ", and please come again and see what may happen if you choose to go another way!")

#Prompt user to exit program
input("\nPress Enter to exit the program.")
