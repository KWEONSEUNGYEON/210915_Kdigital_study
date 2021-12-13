import cv2

img = cv2.imread('aa.jpg')

# roi = img[2000:500, 300:550]
# cv2.imshow('roi', roi)
# cv2.waitKey(0)
#
# img[0:180,0:250] = roi
# cv2.imshow('img',img)
# cv2.waitKey(0)

cv2.imshow('img', img[:,:,0])
cv2.waitKey(0)

img[:,:,0] = 0  # 파란색 부분 제거
cv2.imshow('img',img)
cv2.waitKey(0)