import sys
from PyQt5.QtWidgets import QApplication, QWidget, QVBoxLayout, QPushButton
import ex04
import chapter5
from random import randint

# from a import doA
#
# doA()
#
# print(__name__)

class MyApp(QWidget):
    def __init__(self):
        super().__init__()
        self.initui()

    def initui(self):
        btn1 = QPushButton("엑셀저장", self)
        btn2 = QPushButton("불러오기", self)
        btn3 = QPushButton("BTN3", self)

        vLout = QVBoxLayout()
        vLout.addWidget(btn1)
        vLout.addWidget(btn2)
        vLout.addWidget(btn3)

        btn1.clicked.connect(self.btn1clickd)
        btn2.clicked.connect(self.btn2clickd)

        self.setLayout(vLout)
        self.setWindowTitle("Qbutton")
        self.setGeometry(300, 300, 400, 200)
        self.show()

    def btn1clickd(self):
        try:
            ex04.loadCxlsx()
        except Exception as e:
            print(e)

    def btn2clickd(self):
        chapter5.dxlsx(str(randint(0,100)))

if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())