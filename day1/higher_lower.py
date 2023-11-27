from game_data import data
import random
from art import logo, vs



'''
1. display art -- done
2. gen random account from the game data  -- done 
3. format account data  -- done 
4. ask user for a guess -- done 
5. check if user is correct --done 
6. get follow count, if statement if user is correct
7. give user feedback on guess 
8. score keeping 
9. make game repeatable
10. make b become the next a
11. clear the screen between rounds 
'''



def format_data(account):
    """Takes the account data and returns the printable format."""
    account_name = account["name"]
    account_descr = account["description"]
    account_country = account["country"]
    return f"{account_name}, a {account_descr}, from {account_country}"


def check_answer(guess, a_followers, b_followers):
    """Take the user guess and follower counts and returns if they got it right. """
    if a_followers > b_followers:
        return guess == 'a'
    else:
        return guess == 'b'
            
    

print(logo)
score = 0
game_should_continue = True 
account_b = random.choice(data)

while game_should_continue: 
    account_a = account_b
    account_b = random.choice(data)

    while account_a == account_b: 
        account_b = random.choice(data)

    print(f"Compare A: {format_data(account_a)}")
    print(vs)
    print(f"Against B: {format_data(account_b)}")


    # ask user for a guess
    guess = input("Who has more followers? Type 'A' or 'B': ").lower()

    a_follower_count = account_a['follower_count']
    b_follower_count = account_b['follower_count']
    is_correct = check_answer(guess, a_follower_count, b_follower_count)

    if is_correct: 
        score += 1
        print(f"You're right! Current score: {score}")
    else:
        game_should_continue = False
        print(f"Sorry, that's wrong. Final score: {score}")

