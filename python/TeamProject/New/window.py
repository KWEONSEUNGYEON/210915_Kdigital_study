import sys
import os, copy

from PyQt5.QtWidgets import *
import Dialog1
import Dialog2
from CostomerEmail_xl import Customer_Email

from PyQt5 import uic, QtGui, QtWidgets, QtCore

from account_PC import * #<- 이걱 각자 이메일 주소,비번 저장된걸로...
from openpyxl import *


form_class = uic.loadUiType('MainWindow.ui')[0]


class MainWindow(QMainWindow, form_class):
    def __init__(self):
        super().__init__()
        self.setupUi(self)
        self.le =None
        self.xl = Customer_Email()
        self.pushButton.clicked.connect(self.Dialog1)
        self.pushButton_2.clicked.connect(self.Costomer_List)
        self.pushButton_3.clicked.connect(self.Dialog2)
        self.pushButton_5.clicked.connect(self.makexl)
        self.pushButton_4.clicked.connect(self.xl.send_mail)


    def Dialog1(self):  # 버튼으로 아이디 입력창 호출
        Dialog1.Dialog1(self)


    def Costomer_List(self): # 엑셀저장파일 호출


        self.list.clear()
        self.xl.recive_mail()#류경문
        rows = self.xl.Load_List()
        for row in rows:
            self.list.append(row)



        # self.xl.del_list()

    def Dialog2(self): # 쿠팡 상품검색
        try:
            Dialog2.Dialog2(self)
        except Exception as e:
            print(e)

    def makexl(self): # 이메일이 저장될 엑셀 새로만들기(엑셀 초기화)
        self.xl.CreateEmail_xl()


if __name__ == '__main__':
    app = QApplication(sys.argv)
    mywindow = MainWindow()
    mywindow.show()
    sys.exit(app.exec_())