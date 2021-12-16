import sys

from PyQt5.QtGui import QPixmap
from PyQt5.QtWidgets import *
import cv2

class MyApp(QWidget):
    def __init__(self):
        super().__init__()
        self.initui()

        self.img_filename = 'bb.jpg'

        # print(self.img_basic.shape)
    def ori(self):
        qm=QPixmap('bb.jpg')
        self.imlabel.setPixmap(qm)

    def copy(self):
        self.img_basic = cv2.imread(self.img_filename)
        roi = self.img_basic[100:-1,100:-1]
        he = roi.shape[0]
        wi = roi.shape[1]
        self.img_basic[0:he,0:wi] = roi
        cv2.imwrite('bb_copy.jpg', self.img_basic)
        qm = QPixmap('bb_copy.jpg')
        self.imlabel.setPixmap(qm)


    def red_remove(self):
        self.img_basic = cv2.imread(self.img_filename)
        self.img_basic[:,:,2] = 0
        cv2.imwrite('bb_red_remove.jpg', self.img_basic)
        qm = QPixmap('bb_red_remove.jpg')
        self.imlabel.setPixmap(qm)

    def red_add(self):
        self.img_basic = cv2.imread(self.img_filename)
        self.img_basic[:,:,2] = 255
        cv2.imwrite('bb_red_add.jpg', self.img_basic)
        qm = QPixmap('bb_red_add.jpg')
        self.imlabel.setPixmap(qm)

    def gray_add(self):
        self.img_basic = cv2.imread(self.img_filename,cv2.IMREAD_GRAYSCALE)
        print('bb_gray.jpg',self.img_basic)
        qm = QPixmap('bb_gray.jpg')
        self.imlabel.setPixmap(qm)

    def initui(self):
        qm = QPixmap('bb.jpg')
        self.imlabel = QLabel('',self)
        self.imlabel.setPixmap(qm)

        self.btn_copy = QPushButton('원본이미지',self)
        self.btn_copy.move(350,30)

        self.btn_copy = QPushButton('이미지복사',self)
        self.btn_copy.move(350,60)

        self.btn_red_remove = QPushButton('레드제거',self)
        self.btn_red_remove.move(350,90)

        self.btn_red_add = QPushButton('레드처리',self)
        self.btn_red_add.move(350,120)

        self.btn_gray_add = QPushButton('그레이처리',self)
        self.btn_gray_add.move(350,150)

        self.btn_copy.clicked.connect(self.ori)
        self.btn_copy.clicked.connect(self.copy)
        self.btn_red_remove.clicked.connect(self.red_remove)
        self.btn_red_add.clicked.connect(self.red_add)
        self.btn_gray_add.clicked.connect(self.gray_add)

        self.setWindowTitle("opencv")
        self.move(300,300)
        self.resize(450,300)
        self.show()

if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())