# questions_9장.txt

# 1
ds = list((1,2,3))
print(ds)

ds = list("Hello")
print(ds)

# 2
for i in range(9,0,-1):
    print(i*7, end=" ")
print(" ")

# 3
tpl = tuple(range(1, 100))
addtpl = tuple(range(100,0,-1))
tpl+=addtpl
print(tpl, tpl)