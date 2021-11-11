import sys
from PyQt5.QtWidgets import *
from exam import Eexcel

class MyApp(QWidget):
    def __init__(self):
        super().__init__()
        self.initui()
        self.m = Eexcel()

    def initui(self):
        title = QLabel("☆평균, 총점 구하기☆", self)
        title.move(60, 12)
        label_1 = QLabel("국어", self)
        label_1.move(30, 45)
        label_2 = QLabel("영어", self)
        label_2.move(30, 85)
        label_3 = QLabel("수학", self)
        label_3.move(30, 125)

        lineEdit1 = QLineEdit("입력", self)
        lineEdit1.setFixedSize(70, 20)
        lineEdit1.move(60, 41)
        lineEdit2 = QLineEdit("입력", self)
        lineEdit2.setFixedSize(70, 20)
        lineEdit2.move(60, 81)
        lineEdit3 = QLineEdit("입력", self)
        lineEdit3.setFixedSize(70, 20)
        lineEdit3.move(60, 121)

        btnsave = QPushButton("저장", self)
        btnsave.move(140, 40)
        btnload = QPushButton("불러오기", self)
        btnload.move(140, 80)
        btncreate = QPushButton("새로만들기", self)
        btncreate.move(140, 120)

        btnsave.clicked.connect(self.btnsavefunc)
        btnload.clicked.connect(self.btnloadfunc)
        btncreate.clicked.connect(self.btncreatefunc)

        self.setWindowTitle("성적구하기")
        self.move(300, 300)
        self.resize(230, 170)
        self.show()

    def btnsavefunc(self):
        a = self.lineEdit1.text()
        b = self.lineEdit2.text()
        c = self.lineEdit3.text()

        self.m.save(a,b,c)

    def btnloadfunc(self):
        self.m.load()

    def btncreatefunc(self):
        self.m.create()

if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())