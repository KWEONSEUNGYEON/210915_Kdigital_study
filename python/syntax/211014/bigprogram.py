# bigprogram.py 실행하면 크롬브라우저 실행되면서 주소를 임의적으로 입력해서 자동으로 매크로 수행을 하는 프로그램

from selenium import webdriver

aa = webdriver.Chrome('./chromedriver.exe')

aa.get('http://www.naver.com')

aa.find_element_by_xpath('/html/body/div[2]/div[2]/div[2]/div[1]/div[1]/ul[1]/li[2]/a').click()