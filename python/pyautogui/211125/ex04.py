import pyautogui
import pyperclip

pyautogui.hotkey('win', 'r')
pyautogui.write('mspaint')
pyautogui.hotkey('enter')
pyautogui.sleep(2)
fw = pyautogui.getWindowsWithTitle("제목 없음")[0]
if fw.isMaximized == False:
    fw.maximize()

box = pyautogui.locateOnScreen('cc.png', confidence = 0.8)
pyautogui.click(box)
pyautogui.click()
pyautogui.move(10,200, duration=1)
pyautogui.click()

pyautogui.sleep(1)
pyperclip.copy('참 잘했어요')
pyautogui.hotkey('ctrl', 'v')
pyautogui.sleep(5)

fw.close()
pyautogui.sleep(2)
pyautogui.hotkey('n')





