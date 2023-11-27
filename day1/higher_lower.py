from game_data import data
import random
from art import logo, vs


'''
1. display art 
2. gen random account from the game data 
3. format account data 
4. ask user for a guess
5. check if user is correct
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



print(logo)

account_a = random.choice(data)
account_b = random.choice(data)
if account_a == account_b: 
    account_b = random.choice(data)

print(f"Compare A: {format_data(account_a)}")
print(f"Compare B: {format_data(account_b)}")

