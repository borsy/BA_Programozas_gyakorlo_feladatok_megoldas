using System.Numerics;

import random

# Kártyalapok létrehozása
suits = ['treff', 'káro', 'kör', 'pikk']
values = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'D', 'K', 'A']
deck = [(suit, value) for suit in suits for value in values]

# Játékosok és kiosztott lapok számának beolvasása
num_players = int(input("Játékosok száma (legfeljebb 4): "))
num_cards_per_player = int(input("Kiosztott lapok száma (legfeljebb 20): "))

# Ellenőrzés, hogy a kiosztott lapok száma nem haladja meg a csomag lapjainak számát
if num_players * num_cards_per_player > len(deck):
    print("Hiba: Túl sok lapot próbálsz kiosztani!")
    exit()

# Lapok keverése
random.shuffle(deck)

# Kártyalapok osztása játékosok között
players = { }
for i in range(1, num_players + 1):
    player_name = input(f"Játékos {i} neve: ")
    players[player_name] = []
    for j in range(num_cards_per_player):
        card = deck.pop()
        players[player_name].append(card)

# Kártyalapok kiíratása a játékosoknak
for player, hand in players.items():
    print(f"{player} lapjai:")
    for card in hand:
        print(f"{card[0]}-{card[1]}", end = ' ')
    print()