import pyautogui
import a

pyautogui.moveTo(100,100)
print(pyautogui.__path__) #pyautogui 설치위치

print('ex01에서...',__name__)
a.doA()

def main():
    print("main 입니다.")

if __name__ == '__main__':
    main()