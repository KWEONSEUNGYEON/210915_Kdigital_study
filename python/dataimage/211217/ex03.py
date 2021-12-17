import cv2

oriimg = cv2.imread('bb.jpg')
oriimg = cv2.resize(oriimg,(250,222))
cv2.imwrite('bb250220.jpg',oriimg)