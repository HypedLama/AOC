from enum import *

number = Enum('number',['one','two','three','four','five','six','seven','eight','nine'])
def insertnumbers(string:str):
    newstring = string
    for i in range(1,10):
        name =number(i).name
        value = str(number(i).value)
        digitindex=-1
        while newstring.find(name)>=0:
            digitindex = string.find(name,digitindex+1)
            if(digitindex>=0):
                newstring = replace_str_index(newstring,digitindex+1,value)
    return newstring

def replace_str_index(text,index=0,replacement=''):
    return '%s%s%s'%(text[:index],replacement,text[index+1:])

def getfirstdigit(string:str):        
        for char in string:
            if(char.isnumeric()):
                return char

def main():
    print(number.one.value,number.one.name)
    sum=0
    count=0
    with open("input.txt","r") as f:
        lines = f.readlines()
        print(lines[1])
    for line in lines:
        count+=1
        numberstring = insertnumbers(line)
        sum+= int(getfirstdigit(numberstring)+getfirstdigit(reversed(numberstring)))
    print(sum)
main()