number = int(input(">>> "))
for i in range(1, number + 1):
    buffer = ""
    if i % 3 == 0: 
        buffer += "Fizz"
    if i % 5 == 0:
        buffer += "Buzz" 
    print(buffer or i)