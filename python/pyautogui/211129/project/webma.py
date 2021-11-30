from selenium import webdriver
import time

# chrom = webdriver('')
def dostart(id,pw) :
    print(id)
    print(pw)
    print('옴???')
    browser = webdriver.Chrome()

    browser.get('http://kb.step.or.kr/main.do')

    ele = browser.find_element(('xpath'))

    time.sleep(5)

    browser.close()
    browser.quit()