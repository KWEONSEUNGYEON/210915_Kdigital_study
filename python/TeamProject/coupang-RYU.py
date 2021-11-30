from openpyxl import Workbook
import smtplib #보내기
from account import *
from email.message import EmailMessage
from imap_tools import MailBox #받기
from coupang import *

mailbox = MailBox("imap.gmail.com",993)
mailbox.login(EMAIL_ADDRESS,EMAIL_PASSWORD,initial_folder="INBOX")

#받은 메일 체크
for msg in mailbox.fetch(limit=1,reverse=True):
    search = msg.subject
    print("제목",msg.subject)
    print("발신자",msg.from_)
    # print("수신자",msg.to)
    print("날짜",msg.date)
    print("본문",msg.text)

#coupang으로 msg.subject 검색한 결과
mylist = cpResult(search)

#검색한 결과 엑셀에 저장
wb = Workbook()
ws = wb.active
ws.append(["이름", "가격", "평점", "평점 수", "구매링크"])

for temp in mylist:
    ws.append(temp[0:])

wb.save(search+" 가격정보.xlsx")
#엑셀 저장 파일 명은 웹스크래핑 가격+.xlsx, 지금은 가격이 파일명이지만 추후 이메일을 보낸 고객의 메일주소값+.xlsx
#로 해서 관리 할 예정

#메시지 작성
for temp in mylist:
    msg = EmailMessage()
    msg["Subject"] = "쿠팡"+temp[1]
    msg["From"] = EMAIL_ADDRESS
    msg["TO"] = "tmddus6396@naver.com"
    msg.set_content(temp[0])

#파일 첨부
with open((search+" 가격정보.xlsx"), "rb") as f:
    msg.add_attachment(f.read(), maintype="excel", subtype="xls", filename=f.name)


with smtplib.SMTP("smtp.gmail.com", 587) as smtp:
    smtp.ehlo()
    smtp.starttls()
    smtp.login(EMAIL_ADDRESS, EMAIL_PASSWORD)
    smtp.send_message(msg)

print("갔나?")



