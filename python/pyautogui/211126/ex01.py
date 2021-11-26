import time

from selenium import webdriver

browser = webdriver.Chrome()

browser.get('http://www.naver.com')

element = browser.find_element_by_link_text('카페')

print(element.get_attribute('href'))
print(element.get_attribute('class'))

element.click()
time.sleep(1)
browser.back()
time.sleep(1)
browser.refresh()

inputtag = browser.find_element_by_id('query')
inputtag.send_keys('삼성전자우')

btntag = browser.find_element_by_xpath('/html/body/div[2]/div[2]/div[1]/div/div[3]/form/fieldset/button/span[2]')
btntag.click()

browser.save_screenshot('samsung.png')

time.sleep(5)
browser.close()
