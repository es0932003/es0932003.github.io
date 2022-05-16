#2-Player Golf Game
#Program to allow two players to play 18 holes of a golf game
#Programmer: Emmaleigh Stone
#Date: 12/12/21

#Import random and declare variables
import random
Array1 = [0] * 19
Array1[18] = int
Array2 = [0] * 19
Array2[18] = int
Swings = int(0)
FinalScore1 = int
FinalScore2 = int
Winner = str

#Greet the users
print("\tWelcome to the 2-Player Golf Game, where you can play an eighteen-hole golf game.")

#Prompt users for their names
print("\nLet's start by you giving me your names.")

#Input user names
PlayerName1 = str(input("\nEnter first player's name: "))
PlayerName2 = str(input("\nEnter second player's name: "))

#Generate loop to gain swing values for both arrays
while Swings < 18:
    for Swings in range(0, 18, 1):
        Array1[Swings] = random.randint(1, 4)
        Array2[Swings] = random.randint(1, 4)
        Swings = Swings + 1
    
    #Calculate final scores for both users
    FinalScore1 = 0 + Array1[0] + Array1[1] + Array1[2] + Array1[3] + Array1[4] + Array1[5] + Array1[6] + Array1[7] + Array1[8] + Array1[9] + Array1[10] + Array1[11] + Array1[12] + Array1[13] + Array1[14] + Array1[15] + Array1[16] + Array1[17]
    FinalScore2 = 0 + Array2[0] + Array2[1] + Array2[2] + Array2[3] + Array2[4] + Array2[5] + Array2[6] + Array2[7] + Array2[8] + Array2[9] + Array2[10] + Array2[11] + Array2[12] + Array2[13] + Array2[14] + Array2[15] + Array2[16] + Array2[17]

#Prompt users to press the enter key to find out who won the game
input("\nPress Enter to find out your final scores and who won the game.")

#Write final scores for each user
print("\nPlayer " + PlayerName1 + "'s final score: " + str(FinalScore1))
print("\nPlayer " + PlayerName2 + "'s final score: " + str(FinalScore2))

#Write which user is the winner
if FinalScore1 < FinalScore2:
    print("\n" + PlayerName1 + " is the winner!")
    Winner = PlayerName1
if FinalScore1 > FinalScore2:
    print("\n" + PlayerName2 + " is the winner!")
    Winner = PlayerName2
if FinalScore1 == FinalScore2:
    print("\n" +PlayerName1 + " and " + PlayerName2 + " tied!")
    
#Prompt users to press enter to find out user one's swings per hole
input("\nPress Enter to get " + PlayerName1 + "'s swings per hole.")

#Write user one's swings per hole
print("\n" + PlayerName1 + "'s swings per hole:")
print("Hole 01: " + str(Array1[0]))
print("Hole 02: " + str(Array1[1]))
print("Hole 03: " + str(Array1[2]))
print("Hole 04: " + str(Array1[3]))
print("Hole 05: " + str(Array1[4]))
print("Hole 06: " + str(Array1[5]))
print("Hole 07: " + str(Array1[6]))
print("Hole 08: " + str(Array1[7]))
print("Hole 09: " + str(Array1[8]))
print("Hole 10: " + str(Array1[9]))
print("Hole 11: " + str(Array1[10]))
print("Hole 12: " + str(Array1[11]))
print("Hole 13: " + str(Array1[12]))
print("Hole 14: " + str(Array1[13]))
print("Hole 15: " + str(Array1[14]))
print("Hole 16: " + str(Array1[15]))
print("Hole 17: " + str(Array1[16]))
print("Hole 18: " + str(Array1[17]))

#Prompt users to press enter to find out user two's swings per hole
input("\nPress Enter to get " + PlayerName2 + "'s swings per hole.")

#Write user two's swings per hole
print("\n" + PlayerName2 + "'s swings per hole:")
print("Hole 01: " + str(Array2[0]))
print("Hole 02: " + str(Array2[1]))
print("Hole 03: " + str(Array2[2]))
print("Hole 04: " + str(Array2[3]))
print("Hole 05: " + str(Array2[4]))
print("Hole 06: " + str(Array2[5]))
print("Hole 07: " + str(Array2[6]))
print("Hole 08: " + str(Array2[7]))
print("Hole 09: " + str(Array2[8]))
print("Hole 10: " + str(Array2[9]))
print("Hole 11: " + str(Array2[10]))
print("Hole 12: " + str(Array2[11]))
print("Hole 13: " + str(Array2[12]))
print("Hole 14: " + str(Array2[13]))
print("Hole 15: " + str(Array2[14]))
print("Hole 16: " + str(Array2[15]))
print("Hole 17: " + str(Array2[16]))
print("Hole 18: " + str(Array2[17]))

#Bid farewell to the users
if FinalScore1 != FinalScore2:
    print("\nCongratulations, " + Winner + ", on a fabulous game! Thank you, " + PlayerName1 + " and " + PlayerName2 + ", both for playing! Come back soon!")
else:
    print("\nCongratulations, " + PlayerName1 + " and " + PlayerName2 + ", on a wonderful game and thank you both for playing! Come back soon!")

#Prompt users to exit program
input("\nPress Enter to exit the game.")
