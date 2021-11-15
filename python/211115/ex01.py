import sys
from PyQt5.QtWidgets import *

class MyApp(QWidget):
    def __init__(self):
        super().__init__()

        self.row = 0
        self.col = 0

        self.value = 1

        self.initui()
        self.signalfn()

    # Excel 및 화면에 저장
    def mybtnfn(self):
        self.tableW.setItem(self.row,self.col,QTableWidgetItem(str(self.value)))
        print("누름")
        self.value += 1
        # self.row += 1
        self.col += 1
        if(self.col == 4):
            self.row += 1
            self.col = 0
            if (self.row > 9):
                self.tableW.setRowCount(self.row + 1)
        print("self.row =", self.row)


# control 이벤트 다는 곳
    def signalfn(self):
        self.btn1.clicked.connect(self.mybtnfn)

# 디자인 하는 곳
    def initui(self):

        self.btn1 = QPushButton("추가", self)
        self.btn1.move(10,10)

        self.tableW = QTableWidget(self)
        self.tableW.move(100,10)
        self.tableW.setRowCount(10)
        self.tableW.setColumnCount(4)
        self.tableW.setFixedSize(425,325)

        self.setWindowTitle("First App")
        self.move(300,300)
        self.resize(800,600)
        self.show()

if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())