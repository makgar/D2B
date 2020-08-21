#!/usr/bin/python3.6

# Recursive function taken from 
# https://www.geeksforgeeks.org/python-program-to-covert-decimal-to-binary-number/
# Please note that I could have gone with the same approach which I used in the
# Bash solution, i.e. calculate with "while" loop, yet I've already done "while" in Bash
# whereas this approach is new to me and at that shorter.
# I did investigate how it is built. Please see my comments below.

def Dec2Bin(num):
    if num > 1:                 # If the current value is more than 1,
        Dec2Bin(num // 2)       # call the function recursively with result from the floor division (returns the largest possible integer) of the current value as an operand
    print(num % 2, end = '')    # print the modulus of the current value without the new line at the end (which results in all digits being printed inline)

int_check = False
while not int_check:
    print("Input an integer:")
    try:
        dec_val = int(input())
        int_check = True
    except:
        print("The value you have provided can not be converted to integer.\nTry again.")

choice_check = ""
while choice_check != "a" and choice_check != "i":
    print("Tell me which conversion option do you want to use.\nType \"a\" for algorithm.\nType \"i\" for inbuilt \"format\" function.")
    choice_check = input().lower()
    #print(choice_check)
    
if choice_check == "i":
    print(dec_val, "converted to binary with inbuilt \"format\" function equals:")
    print("{0:b}".format(dec_val))
else:
    print(dec_val, "converted to binary with algorithm equals:")
    Dec2Bin(dec_val)
    print()
