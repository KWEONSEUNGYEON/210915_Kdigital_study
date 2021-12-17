import cv2

bb_img = cv2.imread('aa.jpg', cv2.IMREAD_GRAYSCALE)
print(bb_img[0,0])
print(bb_img[0,1])
print(bb_img[0,2])
print(bb_img[0,3])
print(bb_img[0,4])
print(bb_img[0,5])


cv2.imshow('bb_img',bb_img)
cv2.waitKey(0)

ret, tresh_img = cv2.threshold(bb_img,60,255,cv2.THRESH_BINARY)
# tresh_img[0:30,0:30] = 255

cv2.imshow('tresh_img',tresh_img)
cv2.waitKey(0)

ret, tresh_img = cv2.threshold(bb_img,60,255,cv2.THRESH_BINARY_INV)
cv2.imshow('tresh_img',tresh_img)
cv2.waitKey(0)

ret, tresh_img = cv2.threshold(bb_img,60,255,cv2.THRESH_TRUNC)
cv2.imshow('tresh_img',tresh_img)
cv2.waitKey(0)

ret, tresh_img = cv2.threshold(bb_img,60,255,cv2.THRESH_TOZERO)
cv2.imshow('tresh_img',tresh_img)
cv2.waitKey(0)

ret, tresh_img = cv2.threshold(bb_img,60,255,cv2.THRESH_TOZERO_INV)
cv2.imshow('tresh_img',tresh_img)
cv2.waitKey(0)

