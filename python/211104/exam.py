class Exam:
    def doTwo(self):
        cnt = 9
        while True:
            print("cnt",cnt)
            cnt-=1
            if cnt == -1:
                break

    def doThree(self):
        num =  1
        while True:
            if (3*num)/2 ==63:
                break
            num += 1
        print("num", num)

    def doFour(self):
        lcm = 45
        while True:
            if (lcm % 6 == 0) and (lcm % 45 == 0):
                break
            lcm += 1
        print("최소공배수 = ", lcm)

    def doFive(self):
        gcm = 42
        while True:
            if(42 % gcm == 0) and (120 % gcm == 0):
                break
            gcm -= 1
        print("최대공약수 = ", gcm)

    def doSix(self):
        for i in range(1, 10):
            if (7*i) % 2 == 0:
                print(7*i, end=" ")
            else:
                continue

    def doSeven(self):
        num = 2
        while True:
            num+=1
            if num % 2 !=0 and num % 3 !=0:
                print(num, end=" ")
            if num > 100:
                break