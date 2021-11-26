import requests
import re
from bs4 import BeautifulSoup
from openpyxl import Workbook
import smtplib #보내기
from account_PC import *
#account_PC는 본인 이메일을 따로 설정해야 작동합니다!(나도코딩 참조)
#https://youtu.be/exgO1LFl9x8?t=27699
from email.message import EmailMessage
from imap_tools import MailBox #받기

mailbox = MailBox("imap.gmail.com",993)
mailbox.login(EMAIL_ADDRESS,EMAIL_PASSWORD,initial_folder="INBOX")
#EMAIL_ADDRESS,EMAIL_PASSWORD는 위에있는 account_PC 설정해야함!



#받은 메일 체크하는부분(모든 메일을 확인할순 없으니...)--------------------------------------------------------------------------
for msg in mailbox.fetch(limit=1,reverse=True):
    search = msg.subject
    # search = msg.subje를 하는이유: msg.subject는 받은 메일의 제목입니다. 예를들면 받은 메일 제목이 아이폰 이면
    #search = 아이폰 이 되는거에요!
    print("제목",msg.subject)
    print("발신자",msg.from_)
    # print("수신자",msg.to)
    print("날짜",msg.date)
    print("본문",msg.text)


#웹스크래핑(사이트에서 정보 긁어오기) 파트 ---------------------------------------------------------------------------------
                                         #위에 설명한 search가 다나와 검색창에 들어가게됩니다
url = "https://www.coupang.com/np/search?component=&q="+search+"&channel=user"

headers = {
    "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.45 Safari/537.36"}
res = requests.get(url, headers=headers)
res.raise_for_status()
soup = BeautifulSoup(res.text, "html5lib")
       #프로그램이 정상작동 안하면 html5lib 혹은 lxml 을 pip install 등으로 설치하셔야 적상 작동합니다!

items = soup.find_all("li", attrs={"class": re.compile("^search-product")})

mylist = []
#mylist 안에 가격 정보를 배열로 삽입(엑셀에 담기위한)
for item in items:
    name = item.find("div", attrs={"class": "name"}).get_text()
    price = item.find("strong", attrs={"class": "price-value"}).get_text()
    rate = item.find("em", attrs={"class": "rating"})
    if rate:
        rate = rate.get_text()
    else:
        rate = "평점 없음"
    rate_cnt = item.find("span", attrs={"class": "rating-total-count"})
    if rate_cnt:
        rate_cnt = rate_cnt.get_text()
    else:
        rate_cnt = "평점 없음"
    link = item.find("a", attrs={"class": "search-product-link"})['href']
    link = "https://www.coupang.com" + link
    mylist.append((name, price, rate, rate_cnt, link))
    print("이름 : {0}name\n가격 : {1}\n평점 : {2}\n평점 수 : {3}".format(name, price, rate, rate_cnt))
    print("구매링크 : {0}".format(link))
    print()
print("끝")



#웹스크래핑 결과를 이메일로 보내는 작업-----------------------------------------------------
wb = Workbook()
ws = wb.active
ws.append(["이름", "가격", "평점", "평점 수", "구매링크"])
#엑셀 최상단 카테고리 이름 정하기

for temp in mylist:
    ws.append(temp[0:])
    #mylist 안에들어가있는 모든정보를 temp에 한줄씩 엑셀에 삽입하기

wb.save((price+".xlsx"))
#엑셀 저장 파일 명은 웹스크래핑 가격+.xlsx, 지금은 가격이 파일명이지만 추후 이메일을 보낸 고객의 메일주소값+.xlsx
#로 해서 관리 할 예정

msg = EmailMessage()
msg["Subject"] = "쿠팡"+price
msg["From"] = EMAIL_ADDRESS
msg["TO"] = "newruh@naver.com"
msg.set_content(name)


with open((price+".xlsx"), "rb") as f:
    msg.add_attachment(f.read(), maintype="excel", subtype="xls", filename=f.name)

with smtplib.SMTP("smtp.gmail.com", 587) as smtp:
    smtp.ehlo()
    smtp.starttls()
    smtp.login(EMAIL_ADDRESS, EMAIL_PASSWORD)

    smtp.send_message(msg)
print("갔나?")



