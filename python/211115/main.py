import sys
from PyQt5.QtWidgets import *
from PyQt5 import uic
from MyExcel import MyExcel

form_class = uic.loadUiType("assignment.ui")[0]

class MyApp(QMainWindow, QWidget, form_class) :
    def __init__(self) :
        super().__init__()
        self.setupUi(self)
        self.mex = MyExcel()
        self.initui()
        self.signalfn()

    def signalfn(self):
        self.savebtn.clicked.connect(self.savefn)
        self.loadbtn.clicked.connect(self.loadfn)
        self.createbtn.clicked.connect(self.createfn)

    def savefn(self):
            kor = self.koredit.text()
            eng = self.engedit.text()
            math = self.mathedit.text()
            tot = int(kor)+int(eng)+int(math)
            avg = tot/3
            print('tot = ', tot)
            print('avg = ', avg)
            self.mex.savefn(kor, eng, math, tot, avg)

    def loadfn(self):
        self.mex.loadfn()

    def createfn(self):
        self.mex.createfn()

    def tableView(self):
        self.ttt1.setItem(self.row, self.col, QTableWidgetItem(str(self.value)))
        print("누름")
        self.value += 1
        if(self.col == 4):
            self.row += 1
            self.col = 0
            if (self.row > 9):
                self.ttt1.setRowCount(self.row + 1)
        print("self.row =", self.row)

    def initui(self):
        self.ttt1 = QTableWidget(self)
        self.ttt1.setRowCount(10)
        self.ttt1.setColumnCount(5)
        self.ttt1.setFixedSize(520,350)
        self.ttt1.move(60,200)
        colomn_headers = ['국어','영어','수학','평균','총점']
        self.ttt1.setHorizontalHeaderLabels(colomn_headers)

if __name__ == "__main__" :
    app = QApplication(sys.argv)
    myWindow = MyApp()
    myWindow.show()
    app.exec_()