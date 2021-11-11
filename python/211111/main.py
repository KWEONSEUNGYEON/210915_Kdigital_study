import sys
from PyQt5.QtWidgets import *
from myExcel import MExcel

class MyApp(QWidget):
    def __init__(self):
        super().__init__()
        self.initui()
        self.m = MExcel()

    def initui(self):
        label_1 = QLabel("입력1", self)
        label_1.move(20,30)
        label_2 = QLabel("입력3", self)
        label_2.move(20,65)
        label_3 = QLabel("입력3", self)
        label_3.move(20,100)

        self.lineEdit1 = QLineEdit("aaa",self)
        self.lineEdit1.setFixedSize(65,20)
        self.lineEdit1.move(80,32)

        self.lineEdit2 = QLineEdit("bbb",self)
        self.lineEdit2.setFixedSize(65,20)
        self.lineEdit2.move(80,64)

        self.lineEdit3 = QLineEdit("ccc",self)
        self.lineEdit3.setFixedSize(65,20)
        self.lineEdit3.move(80,94)

        btnsave = QPushButton("저장", self)
        btnsave.move(150,30)

        btnload = QPushButton(self)
        btnload.setText("불러오기")
        btnload.move(150,60)

        btncreate = QPushButton(self)
        btncreate.setText("Excel생성")
        btncreate.move(150,90)

        btnsave.clicked.connect(self.btnsavefunc)
        btnload.clicked.connect(self.btnloadfunc)
        btncreate.clicked.connect(self.btncreatefunc)

        self.setWindowTitle("Excel...")
        self.move(300,300)
        self.resize(230,150)
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