import cv2

img = cv2.imread('cc.jpg', cv2.IMREAD_GRAYSCALE)
cv2.imshow('img',img)
cv2.waitKey(0)

ret,tresh = cv2.threshold(img, 75,255,cv2.THRESH_BINARY)
cv2.imshow('tresh',tresh)
cv2.waitKey(0)

adtresh = cv2.adaptiveThreshold(img, 255, cv2.ADAPTIVE_THRESH_MEAN_C, cv2.THRESH_BINARY,21,3)
cv2.imshow('adtresh', adtresh)
cv2.waitKey(0)

adtresh = cv2.adaptiveThreshold(img, 255, cv2.ADAPTIVE_THRESH_GAUSSIAN_C, cv2.THRESH_BINARY,21,3)
cv2.imshow('adtresh', adtresh)
cv2.waitKey(0)