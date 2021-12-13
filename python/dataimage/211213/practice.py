import sys
import time
import pyautogui
from PyQt5.QtWidgets import *
from PyQt5.QtGui import *
import cv2
from tkinter import *

class MyApp(QWidget):
    def __init__(self):
        super().__init__()
        self.initui()

    def imgCopy(self):
        try:
            img = cv2.imread('aa.jpg')
            roi = img[200:400, 800:1000]
            cv2.imshow('roi', roi)
            cv2.waitKey(0)

            img[0:200, 0:250] = roi
            cv2.imshow('img',img)
            cv2.waitKey(0)
        except Exception as e:
            print(e)

    def delete_red(self):
        img = cv2.imread('aa.jpg')
        img[0,0,:] = 0
        cv2.imshow('img',img)
        cv2.waitKey(0)

    def imgRed(self):
        img = cv2.imread('aa.jpg')
        img[0,:,:] = 255
        cv2.imshow('img',img)
        cv2.waitKey(0)

    def imgGrey(self):
        img = cv2.imread('aa.jpg',cv2.IMREAD_COLOR)
        img_gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
        cv2.imshow('gray', img_gray)
        cv2.waitKey(0)

    def initui(self):
        self.lbl = QLabel(self)
        self.lbl.resize(300,300)
        pixmap = QPixmap("aa.jpg")
        pixmap = pixmap.scaledToWidth(500)
        self.lbl.setPixmap(QPixmap(pixmap))

        self.copybtn = QPushButton("이미지추출및복사", self)
        self.copybtn.move(450,40)
        self.copybtn.clicked.connect(self.imgCopy)

        self.delete_red_btn = QPushButton("레드색 제거", self)
        self.delete_red_btn.move(450,90)
        self.delete_red_btn.clicked.connect(self.delete_red)

        self.red_btn = QPushButton("레드색 전체 처리", self)
        self.red_btn.move(450,140)
        self.red_btn.clicked.connect(self.imgRed)

        self.gray_btn = QPushButton("그레이 처리", self)
        self.gray_btn.move(450,190)
        self.gray_btn.clicked.connect(self.imgGrey)

        self.setWindowTitle("Image App")
        self.move(300,300)
        self.resize(600,500)
        self.show()

if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())