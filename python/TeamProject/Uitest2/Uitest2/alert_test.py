from PyQt5 import uic
from CostomerEmail_xl import Customer_Email
from PyQt5.QtWidgets import *

class alert_test:
    def __init__(self, parent):  # 입력창 호출부
        super(alert_test, self).__init__(parent)
        Email_ui = './name_alert.ui'
        uic.loadUi(Email_ui, self)
        self.xl = Customer_Email()
        self.pushButton.clicked.connect(self.EmailPush)
        self.pushButton_2.clicked.connect(self.EmailRemove)
        self.show()