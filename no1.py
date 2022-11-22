import random
def bintang(jml):
    for i in range(15):
        print('**', end='')
nyawa = 3
nilai = 0
bintang(15)
print()
while nyawa > 0 :
    angka1 = random.randint(0,10)
    angka2 = random.randint(0,10)
    print('HP : ',nyawa,'           Nilai : ',nilai)
    print()
    hasil = angka1 + angka2
    print('Berapa hasil dari ',angka1,' + ',angka2,' ? ', end="")
    jawaban = int(input())
    print()
    if jawaban == hasil :
        print('Benar')
        nilai += 1
    else :
        print('Salah')
        nyawa -= 1
    print()    
    bintang(15)
    print()
print('Game Over')
print()
print('Nilai : ',nilai)



