import smtplib
import pandas as pd

from PyQt5 import uic, QtGui, QtWidgets, QtCore

import smtplib
from imap_tools import MailBox
from account_PC import * #<- 이걱 각자 이메일 주소,비번 저장된걸로...
from openpyxl import *

from email.message import EmailMessage



from email.mime.multipart import MIMEMultipart
from email.mime.image import MIMEImage
import smtplib

from email.mime.multipart import MIMEMultipart
from email.mime.text import MIMEText
from email.mime.image import MIMEImage
wb=load_workbook("Coupang.xlsx")
ws=wb.active
s = smtplib.SMTP('smtp.gmail.com', 587)
s.starttls()
s.login(EMAIL_ADDRESS,EMAIL_PASSWORD)
msg = MIMEMultipart('alternative')
msg['Subject'] = "subject"
msg['From'] = EMAIL_ADDRESS
msg['To'] = "newruh@naver.com"
for temp in ws.iter_rows(min_row=2):
    img_tag = temp[5].value
    link_tag =temp[4].value
    print(link_tag)

body='''
    '''+img_tag+'''
    '''

body=(body.replace('[',''))
print(img_tag)
text = MIMEText(body, 'html','utf-8')
msg.attach(text)

wb.close()
s.sendmail(EMAIL_ADDRESS, "newruh@naver.com", msg.as_string())
s.quit()
print("성공")












