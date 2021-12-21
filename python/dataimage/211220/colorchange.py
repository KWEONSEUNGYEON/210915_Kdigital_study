import sys
from PyQt5.QtWidgets import *
from PyQt5.QtCore import Qt
import cv2


class MyApp(QWidget):

    def __init__(self):
        super().__init__()
        self.initUI()

    def initUI(self):
        self.slider = QSlider(Qt.Horizontal, self)
        self.slider.move(450,150)
        self.slider.setRange(0,255)
        self.slider.setSingleStep(1)

        btn = QPushButton('초기화',self)
        btn.move(450,250)


# self.dial.valueChanged.connect(self.dial.setValue) -> 라벨과 연결?
        btn.clicked.connect(self.button_clicked)

    def button_clicked(self):
        self.slider.setValue(0)





        self.setWindowTitle('ColorChange Application')
        self.move(300, 300)
        self.resize(600, 600)
        self.show()



if __name__ == '__main__':
   app = QApplication(sys.argv)
   ex = MyApp()
   sys.exit(app.exec_())