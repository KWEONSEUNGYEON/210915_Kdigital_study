import time

import pyautogui

fw = pyautogui.getActiveWindow()
print(fw.title)
print(fw.size)
print(fw.left, fw.top)

pyautogui.click(fw.left + 60, fw.top + 10) #file 메뉴 클릭하기

# for fw in pyautogui.getAllWindows():
#     print(fw) #모든 윈도우 가져오기

fw = pyautogui.getWindowsWithTitle("제목 없음")[0]
if fw.isActive == False:
    fw.activate()

if fw.isMaximized == False:
    fw.maximize()

time.sleep(3)
fw.restore()
fw.close()

